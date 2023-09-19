using IKProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace YourFrontendNamespace.Controllers
{
    public class GenderController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GenderController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            var response = await client.GetAsync("http://localhost:7100/api/Gender"); // Gender API'nin adresini doğru şekilde güncelleyin

            if (response.IsSuccessStatusCode)
            {
                var genders = await response.Content.ReadFromJsonAsync<Gender[]>(); // Gender modelinize uygun bir sınıf kullanın
                return View(genders);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult AddGender()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGender(Gender gender)
        {
            var client = _httpClientFactory.CreateClient();

            var response = await client.PostAsJsonAsync("http://localhost:7100/api/Gender", gender); // Gender API'nin adresini doğru şekilde güncelleyin

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditGender(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var response = await client.GetAsync($"http://localhost:7100/api/Gender/{id}"); 

            if (response.IsSuccessStatusCode)
            {
                var gender = await response.Content.ReadFromJsonAsync<Gender>(); // Gender modelinize uygun bir sınıf kullanın
                return View(gender);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditGender(Gender gender)
        {
            var client = _httpClientFactory.CreateClient();

            var response = await client.PutAsJsonAsync("http://localhost:5001/api/Gender/UpdateGender", gender); // Gender API'nin adresini doğru şekilde güncelleyin

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> DeleteGender(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var response = await client.DeleteAsync($"http://localhost:5001/api/Gender/{id}"); // Gender API'nin adresini doğru şekilde güncelleyin

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
