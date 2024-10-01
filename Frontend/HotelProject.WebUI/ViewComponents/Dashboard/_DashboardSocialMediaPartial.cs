using HotelProject.WebUI.Dtos.FoolowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSocialMediaPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/vanifestoo"),
                Headers =
    {
        { "x-rapidapi-key", "4ea8e76323msh8098c39f62699ebp1e81adjsn2b2af98790ab" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDto = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1 = resultInstagramFollowersDto.followers;
                ViewBag.v2 = resultInstagramFollowersDto.following;
               
            }
        
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=netflixturkiye"),
                Headers =
    {
        { "x-rapidapi-key", "4ea8e76323msh8098c39f62699ebp1e81adjsn2b2af98790ab" },
        { "x-rapidapi-host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.T1 = resultTwitterFollowersDto.data.user_info.followers_count;
                ViewBag.T2 = resultTwitterFollowersDto.data.user_info.friends_count;
                return View(resultTwitterFollowersDto);
            }

          
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Ftubabalkan%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
                Headers =
    {
        { "x-rapidapi-key", "4ea8e76323msh8098c39f62699ebp1e81adjsn2b2af98790ab" },
        { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLinkedlnFollowersDto resultLinkedlnFollowersDto = JsonConvert.DeserializeObject<ResultLinkedlnFollowersDto>(body3);
                ViewBag.I1 = resultLinkedlnFollowersDto.data.follower_count;
            }
            return View();
        }
    }
}
