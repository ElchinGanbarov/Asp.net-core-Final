using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AspFinal.Areas.Admin.Models.AboutModel
{
    public class AboutModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage = "Texti daxil edin...")]
        [MaxLength(1000)]
        public string AboutText { get; set; }
        [Required(ErrorMessage = "Basliq adi daxil edin...")]
        [MaxLength(500)]
        public string AboutTitle { get; set; }
        [Required(ErrorMessage = "Nomrenizi daxil edin...")]
        [MaxLength(50)]
        public string Phone { get; set; }
        public string Image { get; set; }
        public IFormFile File { get; set; }
    }
}
