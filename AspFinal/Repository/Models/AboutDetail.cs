using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class AboutDetail:BaseEntity
    {
        [Required(ErrorMessage ="Acar sozu daxil edin...")]
        [MaxLength(100)]
        public string Key { get; set; }
        [Required(ErrorMessage ="Deyeri daxil edin...")]
        [MaxLength(100)]
        public string Value { get; set; }
        [Required(ErrorMessage ="Logo adi daxil edin...")]
        [MaxLength(100)]
        public string Logo { get; set; }
        [Required(ErrorMessage = "Secimini daxil edin...")]
        public int AboutUsId { get; set; }
        public AboutUs AboutUs { get; set; }
    }
}
