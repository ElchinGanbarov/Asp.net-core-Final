using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Agent:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        [MaxLength(50)]
        public string WorkExperience { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
