using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public  class AboutClaim:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string ClaimSubtitle { get; set; }
        [Required]
        [MaxLength(100)]
        public string ClaimSubtext { get; set; }
        [Required]
        [MaxLength(50)]
        public string ClaimLogo { get; set; }
        public int AboutUsId { get; set; }
        public AboutUs AboutUs { get; set; }
    }
}
