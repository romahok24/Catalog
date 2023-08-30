using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using ProductCatalog.Client.Models;
using ProductCatalog.DTO;
using ProductCatalog.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;
using static ProductCatalog.Constants.Constants.Controllers;

namespace ProductCatalog.Client.Controllers
{
    [Authorize(Roles = "User, SuperUser")]
    public class ProductController : BaseController
    {
        private readonly string url = "https://localhost:44301/Product";
        private readonly string categoryUrl = "https://localhost:44301/Category";

        public ProductController(IHttpClientFactory factory) : base(factory)
        {
        }

        public async Task<ActionResult> Index()
        {
            var token = GetTokenFromCookie();
            
            if (string.IsNullOrWhiteSpace(token))
                return RedirectToAction(Views.Login, Account);

            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonString = await HttpClient.GetStringAsync(url);

            if (!string.IsNullOrEmpty(jsonString) && jsonString.Contains(ErrorMessages.Unauthorized))
            {
                return RedirectToAction(Views.Login, Account);
            }

            var response = JsonConvert.DeserializeObject<IEnumerable<ProductDTO>>(jsonString).ToList();

            var vm = new ProductViewModel
            {
                Categories = await GetCategorySelectList(),
                Products = response
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> Filter(ProductFilterDTO filter = null)
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{url}/{RoutingValues.Filter}"),
                Content = JsonContent.Create(filter)
            };

            var response = await HttpClient.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var responseBody = JsonConvert.DeserializeObject<IEnumerable<ProductDTO>>(responseString);

            var vm = new ProductViewModel
            {
                Filter = filter,
                Categories = await GetCategorySelectList(),
                Products = responseBody
            };

            return View(Views.Index, vm);
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            var categories = await GetCategorySelectList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(ProductDTO model)
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            try
            { 
                var content = JsonContent.Create(model);
                var jsonResponse = await HttpClient.PostAsync(url, content);
                return RedirectToAction(Views.Index);
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonResponse = await HttpClient.GetAsync($"{url}/{id}");
            var response = await jsonResponse.Content.ReadFromJsonAsync<ProductDTO>();

            var categories = await GetCategorySelectList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            return View(response);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(ProductDTO model)
        {
            try
            {
                var token = GetTokenFromCookie();
                HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var content = JsonContent.Create(model);
                var jsonResponse = await HttpClient.PutAsync(url, content);
                
                return RedirectToAction(Views.Index);
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        [Authorize(Roles = Roles.SuperUser)]
        public async Task<ActionResult> Delete(int id)
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

        private async Task<IEnumerable<CategoryDTO>> GetCategorySelectList()
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonString = await HttpClient.GetStringAsync(categoryUrl);
            var categories = JsonConvert.DeserializeObject<IEnumerable<CategoryDTO>>(jsonString);

            return categories;
        }
    }
}