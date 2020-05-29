using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public  class AboutClaim:BaseEntity
    {
        [Required(ErrorMessage ="Basliq daxil edin...")]
        [MaxLength(50)]
        public string ClaimSubtitle { get; set; }
        [Required(ErrorMessage ="Texti daxil edin...")]
        [MaxLength(100)]
        public string ClaimSubtext { get; set; }
        [Required(ErrorMessage ="Logo adini daxil edin...")]
        [MaxLength(50)]
        public string ClaimLogo { get; set; }
        [Required(ErrorMessage = "Seciminizi daxil edin...")]
        public int AboutUsId { get; set; }
        public AboutUs AboutUs { get; set; }
    }
}
