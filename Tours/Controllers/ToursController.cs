using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Tours.Data;
using Tours.Dto;
using Tours.Models;

namespace Tours.Controllers
{
    [Route("api/tours")]
    [ApiController]
    public class ToursController : ControllerBase
    {
        private readonly Context ctx;

        public ToursController(Context ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if (!Request.Headers.Authorization.Any())
            {
                return Ok(ctx.Tours.Where(t => t.IsActive == 1));
            }

            var authHeader = Request.Headers.Authorization[0];
            if (!string.IsNullOrEmpty(authHeader) && authHeader.StartsWith("Bearer "))
            {
                var encodedJwt = authHeader["Bearer ".Length..];
                try
                {
                    var jwt = new JwtSecurityTokenHandler().ReadJwtToken(encodedJwt);
                    var role = jwt.Claims.First(c => c.Type.Equals("role"));
                    if (role.Value.Equals("touragent"))
                    {
                        return Ok(ctx.Tours);
                    }
                }
                catch(Exception e) {}
            }

            return Ok(ctx.Tours.Where(t => t.IsActive == 1));
        }

        [HttpGet("{tourId}")]
        public IActionResult GetById(long tourId)
        {
            return Ok(ctx.Tours.FirstOrDefault(t => t.Id == tourId));
        }

        [HttpPost]
        [Authorize(Roles = "touragent")]
        public async Task<IActionResult> CreateTour(CreateTourDto createTourDto)
        {
            var tour = new Tour
            {
                Name = createTourDto.Name,
                Country = createTourDto.Country,
                HotelName = createTourDto.HotelName,
                TypeRoom = createTourDto.TypeRoom,
                TypeFood = createTourDto.TypeFood,
                PricePurchase = createTourDto.PricePurchase,
                PriceSale = createTourDto.PriceSale,
                DateStart = createTourDto.DateStart,
                DateEnd = createTourDto.DateStart.AddDays(createTourDto.CountDays),
                IsActive = 1
            };

            await ctx.Tours.AddAsync(tour);
            await ctx.SaveChangesAsync();
            return Ok($"Tour with id = ${tour.Id} has created");
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "touragent")]
        public async Task<IActionResult> UpdateTour(long id, UpdateTourDto updateTourDto)
        {
            var tour = await ctx.Tours.FirstOrDefaultAsync(t => t.Id == id);
            if (tour is null)
            {
                return NotFound($"Tour with id = {id} doesn't exist");
            }
            if (!string.IsNullOrEmpty(updateTourDto.Name))
            {
                tour.Name = updateTourDto.Name;
            }
            if (!string.IsNullOrEmpty(updateTourDto.Country))
            {
                tour.Country = updateTourDto.Country;
            }
            if (!string.IsNullOrEmpty(updateTourDto.HotelName))
            {
                tour.HotelName = updateTourDto.HotelName;
            }
            if (!string.IsNullOrEmpty(updateTourDto.TypeRoom))
            {
                tour.TypeRoom = updateTourDto.TypeRoom;
            }
            if (!string.IsNullOrEmpty(updateTourDto.TypeFood))
            {
                tour.TypeFood = updateTourDto.TypeFood;
            }
            if (!string.IsNullOrEmpty(updateTourDto.Name))
            {
                tour.Name = updateTourDto.Name;
            }
            if (updateTourDto.PricePurchase is not null)
            {
                tour.PricePurchase = updateTourDto.PricePurchase.Value;
            }
            if (updateTourDto.PriceSale is not null)
            {
                tour.PriceSale = updateTourDto.PriceSale.Value;
            }
            if (updateTourDto.DateStart is not null)
            {
                tour.DateStart = updateTourDto.DateStart.Value;
            }
            if (updateTourDto.CountDays is not null)
            {
                tour.DateEnd = tour.DateStart.AddDays(updateTourDto.CountDays.Value);
            }

            ctx.Tours.Update(tour);
            await ctx.SaveChangesAsync();
            return Ok($"Tour with id = {id} has updated");
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "touragent")]
        public async Task<IActionResult> DeleteTour(long id)
        {
            var tour = await ctx.Tours.FirstOrDefaultAsync(t => t.Id == id);
            if (tour is null)
            {
                return NotFound($"Tour with id = {id} doesn't exist");
            }

            ctx.Tours.Remove(tour);
            await ctx.SaveChangesAsync();
            return Ok($"Tour with id = {id} has deleted");
        }
    }
}
