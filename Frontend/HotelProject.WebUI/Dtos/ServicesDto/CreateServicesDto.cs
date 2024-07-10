using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServicesDto
{
    public class CreateServicesDto
    {
        [Required(ErrorMessage = "Hizmet İkon Linki Giriniz!")]
        public string ServicesIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı Giriniz!")]
        [StringLength(100, ErrorMessage="Hızmet Başlığı En Fazla 100 Karakterden Oluşabilir")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
