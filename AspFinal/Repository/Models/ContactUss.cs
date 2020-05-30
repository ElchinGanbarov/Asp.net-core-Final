using System;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
   public class ContactUss:BaseEntity   
    {
        [Required(ErrorMessage ="Basliq daxil edin...")]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Text daxil edin...")]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required(ErrorMessage = "Acar sozu daxil edin...")]
        [MaxLength(50)]
        public string Key { get; set; }
        [Required(ErrorMessage = "Deyeri daxil edin...")]
        [MaxLength(50)]
        public string Value { get; set; }
        [Required(ErrorMessage = "Logonu daxil edin...")]
        [MaxLength(50)]
        public string Logo { get; set; }
    }
}
