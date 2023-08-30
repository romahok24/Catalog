using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductCatalog.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;
using static ProductCatalog.Constants.Constants.Roles;

namespace ProductCatalog.Client.Controllers
{
    [Authorize(Roles = "User, SuperUser")]
    public class CategoryController : BaseController
    {
        private readonly string url = "https://localhost:44301/Category";

        public CategoryController(IHttpClientFactory factory) : base(factory)
        {
        }

        public async Task<ActionResult> Index()
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            string jsonString = await HttpClient.GetStringAsync(url);
            var response = JsonConvert.DeserializeObject<IEnumerable<CategoryDTO>>(jsonString).ToList();

            return View(response);
        }

        [Authorize(Roles = SuperUser)]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = SuperUser)]
        public async Task<ActionResult> Create(CategoryDTO model)
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var content = JsonContent.Create(model);
            var jsonResponse = await HttpClient.PostAsync(url, content);

            return RedirectToAction(Views.Index);
        }

        [Authorize(Roles = SuperUser)]
        public async Task<ActionResult> Edit(int id)
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonResponse = await HttpClient.GetAsync($"{url}/{id}");
            var response = await jsonResponse.Content.ReadFromJsonAsync<CategoryDTO>();

            return View(response);
        }

        [HttpPost]
        [Authorize(Roles = SuperUser)]
        public async Task<ActionResult> Edit(CategoryDTO model)
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var content = JsonContent.Create(model);
            var jsonResponse = await HttpClient.PutAsync(url, content);

            return RedirectToAction(Views.Index);
        }

        [HttpGet]
        [Authorize(Roles = SuperUser)]
        public async Task<ActionResult> Delete(int id)
        {
            var token = GetTokenFromCookie();
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonResponse = await HttpClient.DeleteAsync($"{url}/{id}");
            return RedirectToAction(Views.Index);
        }
    }
}
