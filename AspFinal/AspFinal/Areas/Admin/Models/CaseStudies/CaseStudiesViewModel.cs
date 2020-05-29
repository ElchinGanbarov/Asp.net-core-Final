using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspFinal.Areas.Admin.Models.CaseStudies
{
    public class CaseStudiesViewModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Basliq daxil edin..")]
        [MaxLength(50)]
        public string Title { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage ="Kicik basliq daxil edin...")]
        [MaxLength(200)]
        public string Subtitle { get; set; }
        [Required(ErrorMessage ="Metn daxil edin...")]
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        public string Image { get; set; }
        public IFormFile File { get; set; }
    }
}
