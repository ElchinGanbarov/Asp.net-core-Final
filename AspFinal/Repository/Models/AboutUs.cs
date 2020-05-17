using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class AboutUs:BaseEntity
    {
        public int ImagesId { get; set; }
        [Required]
        [MaxLength(500)]
        public string AboutText { get; set; }
        [Required]
        [MaxLength(50)]
        public string  Phone { get; set; }
        public Images Images { get; set; }
    }
}
