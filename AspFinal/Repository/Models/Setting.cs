using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Settings : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Logo { get; set; }
        public string CoverImage { get; set; }
        [Required]
        [MaxLength(50)]
        public string QueryNumber { get; set; }
        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string WorkTime { get; set; }
    }
}