using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "User, SuperUser")]
    public class ExchangeRateController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public ExchangeRateController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<ActionResult<decimal>> GetExchangeRate()
        {
            var response = await _httpClient.GetAsync(BelarusBank.Url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(content);

                if (jObject.TryGetValue(BelarusBank.ExchangeRateField, out var officialRateValue))
                {
                    if (decimal.TryParse(officialRateValue.ToString(), out var officialRate))
                    {
                        return Ok(officialRate);
                    }
                }
            }

            return BadRequest();
        }
    }
}