using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants.Cookie;

namespace ProductCatalog.Client.Controllers
{
    [Authorize(Roles = "User, SuperUser")]
    public class ExchangeRateController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string url = "https://localhost:44301/ExchangeRate";

        public ExchangeRateController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<IActionResult> GetExchangeRate()
        {
            var token = Request.Cookies[AccessToken];
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonResponse = await _httpClient.GetStringAsync($"{url}");
            var response = JsonConvert.DeserializeObject<decimal>(jsonResponse);

            return Ok(response);
        }
    }
}
