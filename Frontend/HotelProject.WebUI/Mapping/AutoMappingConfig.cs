using AutoMapper;
using HotelProject.EntityLayer.Concrete;
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
        }
    }
}
