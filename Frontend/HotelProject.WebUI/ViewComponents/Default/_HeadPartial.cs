using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
