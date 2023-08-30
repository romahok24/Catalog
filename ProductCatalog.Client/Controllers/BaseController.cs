using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using static ProductCatalog.Constants.Constants.Cookie;

namespace ProductCatalog.Client.Controllers
{
    public class BaseController : Controller
    {
        protected HttpClient HttpClient { get; set; }

        public BaseController(IHttpClientFactory httpClientFactory)
        {
            HttpClient = httpClientFactory.CreateClient();
        }

        public void SetTokenCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.UtcNow.AddMinutes(30),
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None,
            };

            Response.Cookies.Append(AccessToken, token, cookieOptions);
        }

        public string GetTokenFromCookie()
        {
            return Request.Cookies[AccessToken];
        }
    }
}
