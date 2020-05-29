using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Areas.Admin.Models.SettingView
{
    public class SettingViewModel
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Logo2 { get; set; }

        public bool Status { get; set; }
        public string CoverImage { get; set; }
        [Required(ErrorMessage = "Nomre daxil edin...")]
        [MaxLength(50)]
        public string QueryNumber { get; set; }
        [Required(ErrorMessage = "Adress daxil edin...")]
        [MaxLength(100)]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Nomre daxil edin...")]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email daxil edin...")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Is vaxdini daxil edin...")]
        [MaxLength(50)]
        public string WorkTime { get; set; }
        public IFormFile LogoFile { get; set; }
        public IFormFile LogoFile2 { get; set; }

        public IFormFile CoverImageFile { get; set; }

    }
}
