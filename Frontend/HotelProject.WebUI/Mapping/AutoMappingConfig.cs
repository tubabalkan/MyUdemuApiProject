using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.SendMessageDto;
using HotelProject.WebUI.Dtos.ServicesDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Dtos.TestimonialDto;
using System.Security.Cryptography.X509Certificates;

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
               CreateMap<ResultRoomDto, Room>().ReverseMap();
               CreateMap<CreateRoomDto, Room>().ReverseMap();
               CreateMap<UpdateRoomDto, Room>().ReverseMap();
               CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
               CreateMap<ResultStaffDto, Staff>().ReverseMap();
               CreateMap<ResultSubscribeDto, Subscribe>().ReverseMap();
               CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
               CreateMap<CreateBookingDto, Booking>().ReverseMap();
               CreateMap<ResultBookingDto, Booking>().ReverseMap();
               CreateMap<ApprovedRezervationBookingDto, Booking>().ReverseMap();
               CreateMap<CreateContactDto, Contact>().ReverseMap();
               CreateMap<InboxContactDto, Contact>().ReverseMap();
               CreateMap<ResultContactDto, Contact>().ReverseMap();
               CreateMap<ResultGuestDto, Guest>().ReverseMap();
               CreateMap<CreateGuestDto, Guest>().ReverseMap();
               CreateMap<UpdateGuestDto, Guest>().ReverseMap();
               CreateMap<CreateSendMessageDto, SendMessage>().ReverseMap();
               CreateMap<ResultSendBoxDto, SendMessage>().ReverseMap();
               CreateMap<GetMessageByIdDto, Contact>().ReverseMap();
            
        }
    }
}
