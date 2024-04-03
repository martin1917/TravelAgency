using Analytics.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text.Json;

namespace Analytics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyticsController : ControllerBase
    {
        private readonly IHttpClientFactory httpClientFactory;

        private static readonly JsonSerializerOptions options = new() { PropertyNameCaseInsensitive = true };

        public AnalyticsController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        [HttpGet("client_stats")]
        [Authorize(Roles = "touragent")]
        public async Task<IActionResult> GetClientsStatistics()
        {
            var tourHttpClient = httpClientFactory.CreateClient("Requests");
            tourHttpClient.DefaultRequestHeaders.Add("Authorization", new string[] { Request.Headers.Authorization });

            List<Request>? requests;
            using (var response = await tourHttpClient.GetAsync("requests?status=paid"))
            {
                var stream = await response.Content.ReadAsStreamAsync();
                requests = await JsonSerializer.DeserializeAsync<List<Request>>(stream, options);
            }

            if (requests is null)
            {
                return NotFound();
            }

            var stats = (from req in requests
                         group req by req.UserId into g
                         select new
                         {
                             ClientId = g.Key,
                             Count = g.Count(),
                             TotalMoney = g.Sum(r => r.Tour!.PriceSale)
                         }).OrderByDescending(g => g.TotalMoney);

            return Ok(stats);
        }

        [HttpGet("top_country")]
        [Authorize(Roles = "touragent")]
        public async Task<IActionResult> GetTopCountry()
        {
            var tourHttpClient = httpClientFactory.CreateClient("Requests");
            tourHttpClient.DefaultRequestHeaders.Add("Authorization", new string[] { Request.Headers.Authorization });

            List<Request>? requests;
            using (var response = await tourHttpClient.GetAsync("requests?status=paid"))
            {
                var stream = await response.Content.ReadAsStreamAsync();
                requests = await JsonSerializer.DeserializeAsync<List<Request>>(stream, options);
            }

            if (requests is null)
            {
                return NotFound();
            }

            var stats = (from req in requests
                         group req by req.Tour!.Country into g
                         select new
                         {
                             Country = g.Key,
                             Count = g.Count(),
                             TotalProfit = g.Sum(r => r.Tour!.PriceSale - r.Tour!.PricePurchase)
                         }).OrderByDescending(g => g.TotalProfit);

            return Ok(stats);
        }
    }
}
