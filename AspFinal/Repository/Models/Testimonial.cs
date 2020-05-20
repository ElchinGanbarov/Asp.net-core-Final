using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Testimonial : BaseEntity
    {
        [Required]
        public int AboutUsId { get; set; }
        [Required]
        [MaxLength(500)]
        public string Review { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string WorkExperience { get; set; }
        public AboutUs AboutUs { get; set; }
    }
}