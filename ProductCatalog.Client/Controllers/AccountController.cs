using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductCatalog.DTO;
using ProductCatalog.DTO.Infrastructure;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;
using static ProductCatalog.Constants.Constants.Controllers;
using static ProductCatalog.Constants.Constants.ErrorMessages;
using static ProductCatalog.Constants.Constants.SuccessMessages;

namespace ProductCatalog.Client.Controllers
{
    public class AccountController : BaseController
    {
        private readonly string loginUrl = "https://localhost:44301/Auth/login";
        private readonly string registerUrl = "https://localhost:44301/Auth/register";

        public AccountController(IHttpClientFactory factory) : base(factory)
        {
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegistrationModelDTO model)
        {
            try
            {
                var content = JsonContent.Create(model);
                var jsonResponse = await HttpClient.PostAsync(registerUrl, content);

                if (!jsonResponse.IsSuccessStatusCode)
                {
                    TempData[ErrorMessage] = await jsonResponse.Content.ReadAsStringAsync();
                    return View();
                }

                TempData[SuccessMessage] = await jsonResponse.Content.ReadAsStringAsync();
                return RedirectToAction(Views.Login);
            }
            catch (Exception ex)
            {
                TempData[ErrorMessage] = ServerError + ex.Message;
                return RedirectToAction(Views.Login);
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AuthentificationModelDTO request)
        {
            try
            { 
                var content = JsonContent.Create(request);
                var jsonResponseMessage = await HttpClient.PostAsync(loginUrl, content);

                if (!jsonResponseMessage.IsSuccessStatusCode)
                {
                    TempData[ErrorMessage] = await jsonResponseMessage.Content.ReadAsStringAsync();
                    return View();
                }

                var responseContent = await jsonResponseMessage.Content.ReadAsStringAsync();
                var authDetails = JsonConvert.DeserializeObject<AuthentificationDetails>(responseContent);

                await Authenticate(authDetails);
                return RedirectToAction(Views.Index, Product);
            }
            catch(Exception ex)
            {
                TempData[ErrorMessage] = ServerError + ex.Message;
                return RedirectToAction(Views.Login);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(Views.Login);
        }

        private async Task Authenticate(AuthentificationDetails user)
        {
            SetTokenCookie(user.Token);
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Username),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
            };

            var identity = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
        }
    }
}