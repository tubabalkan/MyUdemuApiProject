using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServicesDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMappingConfig:Profile
    {
        public AutoMappingConfig()
        {
               CreateMap<ResultServicesDto,Services>().ReverseMap();
               CreateMap<UpdateServicesDto,Services>().ReverseMap();
               CreateMap<CreateServicesDto,Services>().ReverseMap();
               CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
               CreateMap<LoginUserDto,AppUser>().ReverseMap();
               CreateMap<ResultAboutDto, About>().ReverseMap();
               CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
