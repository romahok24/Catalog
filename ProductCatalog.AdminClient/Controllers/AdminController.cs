using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductCatalog.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.AdminClient.Controllers
{
    [Authorize(Roles = Roles.Admin)]
    public class AdminController : BaseController
    {
        private readonly string url = "https://localhost:44301/Admin";

        public AdminController(IHttpClientFactory factory) : base(factory)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonString = await HttpClient.GetStringAsync(url);
            var response = JsonConvert.DeserializeObject<IEnumerable<UserDTO>>(jsonString).ToList();

            return View(response);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Roles = await GetRoles();
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(UserDTO model)
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            try
            {
                var content = JsonContent.Create(model);
                var jsonResponse = await HttpClient.PostAsync(url, content);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                var token = GetTokenFromCookie();
                HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var jsonResponse = await HttpClient.DeleteAsync($"{url}/{id}");
                return RedirectToAction(Views.Index);
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<ActionResult> Block(string id)
        {
            try
            {
                var token = GetTokenFromCookie();
                HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var content = JsonContent.Create(id);
                var jsonResponse = await HttpClient.PostAsync($"{url}/block?id={id}", null);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public async  Task<IActionResult> UpdatePassword(string id)
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonResponse = await HttpClient.GetAsync($"{url}/{id}");
            var response = await jsonResponse.Content.ReadFromJsonAsync<UserDTO>();
            var changePasswordDTO = new ChangePasswordDTO { Id = response.Id, Name = response.UserName };

            return View(changePasswordDTO);
        }

        [HttpPost]
        public async Task<ActionResult> UpdatePassword(ChangePasswordDTO model)
        {
            try
            {
                var token = GetTokenFromCookie();
                HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var content = JsonContent.Create(model);
                var jsonResponse = await HttpClient.PostAsync($"{url}/{RoutingValues.UpdatePassword}", content);
                return RedirectToAction(Views.Index);
            }
            catch
            {
                return View();
            }
        }

        public async Task<IEnumerable<string>> GetRoles()
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonString = await HttpClient.GetStringAsync($"{url}/{RoutingValues.Roles}");
            var response = JsonConvert.DeserializeObject<IEnumerable<string>>(jsonString).ToList();

            return response;
        }
    }
}
