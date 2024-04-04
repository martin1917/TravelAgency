using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Claims;
using Tours.Data;
using Tours.Dto;
using Tours.Models;

namespace Tours.Controllers
{
    [Route("api/requests")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly Context ctx;
        private static readonly string[] states = { "new", "paid", "cancel", "wait_operator_answer" };

        public RequestsController(Context ctx)
        {
            this.ctx = ctx;
        }

        [HttpPost]
        [Authorize(Roles = "client")]
        public async Task<IActionResult> BookToor(BookTourDto bookTourDto)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            long id = long.Parse(claimsIdentity!.FindFirst("id")!.Value);

            var newRequest = new Request
            {
                TourId = bookTourDto.ToorId,
                UserId = id,
                TourAgentId = null,
                Status = "new",
                Date = DateTime.UtcNow
            };

            await ctx.Requests.AddAsync(newRequest);

            var bookedTour = ctx.Tours.First(t => t.Id == bookTourDto.ToorId);
            bookedTour.IsActive = 0;

            await ctx.SaveChangesAsync();
            return Ok(newRequest);
        }

        [HttpPost("change_status")]
        [Authorize(Roles = "touragent")]
        public async Task<IActionResult> ChangeStatus(ChangeStatusDto changeStatusDto)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            long id = long.Parse(claimsIdentity!.FindFirst("id")!.Value);

            if (!states.Contains(changeStatusDto.NewState))
            {
                return BadRequest($"Status invalid ({changeStatusDto.NewState})");
            }

            if (changeStatusDto.NewState.Equals("wait_operator_answer"))
            {
                return await TakeRequest(changeStatusDto.RequestId, id);
            } 
            else if (changeStatusDto.NewState.Equals("paid"))
            {
                return await ConfirmRequest(changeStatusDto.RequestId);
            }
            else if (changeStatusDto.NewState.Equals("cancel"))
            {
                return await CancelRequest(changeStatusDto.RequestId);
            }

            return BadRequest($"Bad status");
        }

        [NonAction]
        private async Task<IActionResult> TakeRequest(long requestId, long tourAgentId)
        {
            var request = ctx.Requests.FirstOrDefault(r => r.Id == requestId);
            if (request is null)
            {
                return BadRequest("Request not exist");
            }

            if (!request.Status.Equals("new"))
            {
                return BadRequest("Request already in work");
            }

            request.Status = "wait_operator_answer";
            request.TourAgentId = tourAgentId;

            var tour = ctx.Tours.FirstOrDefault(t => t.Id == request.TourId);
            if (tour is null)
            {
                return BadRequest("Tour not exist for this request");
            }
            tour.IsActive = 0;

            await ctx.SaveChangesAsync();
            return Ok($"Request ({request.Id}) in work");
        }

        [NonAction]
        public async Task<IActionResult> ConfirmRequest(long requestId)
        {
            var request = ctx.Requests.FirstOrDefault(r => r.Id == requestId);
            if (request is null)
            {
                return BadRequest("Request not exist");
            }

            if (!request.Status.Equals("wait_operator_answer"))
            {
                return BadRequest("Request already confirmed");
            }

            request.Status = "paid";

            await ctx.SaveChangesAsync();
            return Ok($"Request ({request.Id}) has confirmed ");
        }

        [NonAction]
        public async Task<IActionResult> CancelRequest(long requestId)
        {
            var request = ctx.Requests.FirstOrDefault(r => r.Id == requestId);
            if (request is null)
            {
                return BadRequest("Request not exist");
            }

            if (!request.Status.Equals("paid") && !request.Status.Equals("wait_operator_answer"))
            {
                return BadRequest("Request has not been paid");
            }

            request.Status = "cancel";

            var tour = ctx.Tours.FirstOrDefault(t => t.Id == request.TourId);
            if (tour is null)
            {
                return BadRequest("Tour not exist for this request");
            }
            tour.IsActive = 1;

            await ctx.SaveChangesAsync();
            return Ok($"Request ({request.Id}) has canceled ");
        }

        [HttpGet]
        [Authorize(Roles = "touragent")]
        public IActionResult GetAllRequests([FromQuery] string? status)
        {
            if (string.IsNullOrEmpty(status) || !states.Contains(status))
            {
                return Ok(ctx.Requests
                    .Include(r => r.Tour));
            }

            return Ok(ctx.Requests
                .Where(r => r.Status.Equals(status))
                .Include(r => r.Tour));
        }

        [HttpGet("{clientId}")]
        [Authorize(Roles = "touragent")]
        public IActionResult GetRequestsForClient(long clientId, [FromQuery] string? status)
        {
            if (string.IsNullOrEmpty(status) || !states.Contains(status))
            {
                return Ok(ctx.Requests
                    .Where(r => r.UserId == clientId)
                    .Include(r => r.Tour));
            }

            return Ok(ctx.Requests
                .Where(r => r.UserId == clientId)
                .Where(r => r.Status.Equals(status))
                .Include(r => r.Tour));
        }

        [HttpGet("me")]
        [Authorize(Roles = "client")]
        public IActionResult GetSelfRequests([FromQuery] string? status)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            long id = long.Parse(claimsIdentity!.FindFirst("id")!.Value);

            if (string.IsNullOrEmpty(status) || !states.Contains(status))
            {
                return Ok(ctx.Requests
                    .Where(r => r.UserId == id)
                    .Include(r => r.Tour));
            }

            return Ok(ctx.Requests
                .Where(r => r.UserId == id)
                .Where(r => r.Status.Equals(status))
                .Include(r => r.Tour));
        }
    }
}
