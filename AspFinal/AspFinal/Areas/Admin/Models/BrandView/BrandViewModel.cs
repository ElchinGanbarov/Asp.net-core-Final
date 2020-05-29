using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Areas.Admin.Models.BrandView
{
    public class BrandViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Veziyyeti daxil et..")]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Adi daxil et..")]
        [MaxLength(50,ErrorMessage ="Maksimum 50 xarakter daxil edin..")]
        public string Name { get; set; }
        public string Logo { get; set; }
        public IFormFile File { get; set; }
    }
}
