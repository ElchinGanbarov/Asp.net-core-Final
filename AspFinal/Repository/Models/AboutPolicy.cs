using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class AboutPolicy:BaseEntity
    {
        [Required(ErrorMessage ="Sayini daxil edin...")]
        public int PolicyCount { get; set; }
        [Required(ErrorMessage = "Basliqi daxil edin...")]
        [MaxLength(50)]
        public string PolicySubTitle { get; set; }
        [Required(ErrorMessage ="Texti daxil edin...")]
        [MaxLength(100)]
        public string PolicySubText { get; set; }
        [Required(ErrorMessage = "Urli daxil edin...")]
        [MaxLength(100)]
        public string ActionText { get; set; }
        [Required(ErrorMessage = "Seciminizi daxil edin...")]
        public int AboutUsId { get; set; }
        public AboutUs AboutUs { get; set; }
    }
}
