using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]

        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var appUser = new AppUser()
            {
                Name = createNewUserDto.Name,
                Surname = createNewUserDto.Surname,
                UserName = createNewUserDto.UserName,
                Email = createNewUserDto.Mail,
                City = createNewUserDto.City,
                WorkLocationID = 1, // Varsayılan olarak 1 veriliyor
                ImageUrl = "test",
                WorkDepartment = string.IsNullOrEmpty(createNewUserDto.WorkDepartment) ? "Default Department" : createNewUserDto.WorkDepartment
            };

            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                // Hata mesajlarını ModelState'e ekliyoruz ve tekrar view'a gönderiyoruz
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description); // Hata mesajlarını ekliyoruz
                }

                return View(createNewUserDto); // Modeli tekrar view'a gönderiyoruz
            }
        }
    }
}
