using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Areas.Admin.Models.Services
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad daxil edin...")]
        [MaxLength(50,ErrorMessage ="Maksimum 50 xarekter olmalidir...")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Sayini daxil edin...")]     
        public int Count { get; set; }
        [Required(ErrorMessage = "Veziyyeti daxil edin")]
        public bool Status { get; set; }
        [Required(ErrorMessage ="Metin daxil edin...")]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Logo daxil edin...")]
        [MaxLength(50)]
        public string Logo { get; set; }
        public string Image { get; set; }
        public IFormFile Images { get; set; }
    }
}
