using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class AboutPolicy:BaseEntity
    {
        [Required]
        public int PolicyCount { get; set; }
        [Required]
        [MaxLength(50)]
        public string PolicySubTitle { get; set; }
        [Required]
        [MaxLength(100)]
        public string PolicySubText { get; set; }
        [Required]
        [MaxLength(100)]
        public string ActionText { get; set; }
        public int AboutUsId { get; set; }
        public AboutUs AboutUs { get; set; }
    }
}
