using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index() 
        { 
            List<ApiMoviViewModel> apiMoviViewModels = new List<ApiMoviViewModel>();
            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://movies-tv-shows-database.p.rapidapi.com/?year=2020&page=1"),
                Headers =
    {
        { "x-rapidapi-key", "4ea8e76323msh8098c39f62699ebp1e81adjsn2b2af98790ab" },
        { "x-rapidapi-host", "movies-tv-shows-database.p.rapidapi.com" },
        { "Type", "get-shows-byyear" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMoviViewModels=JsonConvert.DeserializeObject<List<ApiMoviViewModel>>(body);
                return View(apiMoviViewModels);

               
            }
         
        }
    }
}
