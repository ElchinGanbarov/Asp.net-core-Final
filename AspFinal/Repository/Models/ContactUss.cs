using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class ContactUss:BaseEntity    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Key { get; set; }
        [Required]
        [MaxLength(50)]
        public string Value { get; set; }
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
    }
}
