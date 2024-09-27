﻿using HotelProject.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5023/api/DashboardWidget/StaffCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync(); 
            ViewBag.StaffCount = jsonData;

            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("http://localhost:5023/api/DashboardWidget/BookingCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.BookingCount = jsonData1;

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5023/api/DashboardWidget/AppUserCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.AppUserCount = jsonData2;


            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("http://localhost:5023/api/DashboardWidget/RoomCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.RoomCount = jsonData3;
            return View();
        }
    }
}
