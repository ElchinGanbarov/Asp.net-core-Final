using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Testimonial : BaseEntity
    {
        [Required(ErrorMessage ="Texti daxil edin...")]
        [MaxLength(500)]
        public string Review { get; set; }
        [Required(ErrorMessage = "Adi daxil edin...")]
        [MaxLength(50,ErrorMessage ="Maksimum 50 xarekter olmalidir...")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Is tecrubesini qeyd edin...")]
        [MaxLength(50, ErrorMessage = "Maksimum 50 xarekter olmalidir...")]
        public string WorkExperience { get; set; }
    }
}