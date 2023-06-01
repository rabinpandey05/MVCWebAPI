using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using MvcWebApi.Models;

namespace MvcWebApi.Controllers
{
    public class IPController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://api.ipify.org/?format=json");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var ipResponse = JsonSerializer.Deserialize<MvcWebApi.Models.IPResponse>(content);
                    ViewBag.IP = ipResponse.IP;
                }
            }

            return View();
        }
    }



}