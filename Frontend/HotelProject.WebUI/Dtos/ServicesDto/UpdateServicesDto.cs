using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServicesDto
{
    public class UpdateServicesDto
    {
        public int ServicesId { get; set; }
        [Required(ErrorMessage = "Hizmet İkon Linki Giriniz!")]
        public string ServicesIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı Giriniz!")]
        [StringLength(100, ErrorMessage = "Hızmet Başlığı En Fazla 100 Karakterden Oluşabilir")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet Açıklaması Giriniz!")]
        [StringLength(500, ErrorMessage = "Hızmet Açıklaması En Fazla 500 Karakterden Oluşabilir")]
        public string Description { get; set; }
    }
}
