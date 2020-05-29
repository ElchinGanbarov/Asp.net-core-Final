using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class AboutUs:BaseEntity
    {
        [Required]
        [MaxLength(1000)]
        public string AboutText { get; set; }
        [Required]
        [MaxLength(500)]
        public string AboutTitle { get; set; }
        [Required]
        [MaxLength(50)]
        public string  Phone { get; set; }
        public string  Image { get; set; }
        public IEnumerable<AboutClaim> AboutClaims { get; set; }
        public IEnumerable<AboutPolicy> AboutPolicies { get; set; }
        public IEnumerable<AboutDetail> AboutDetails { get; set; }
    }
}
