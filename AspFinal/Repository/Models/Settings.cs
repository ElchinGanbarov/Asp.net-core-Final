using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Settings : BaseEntity
    {
        public string Logo { get; set; }
        public string Logo2 { get; set; }

        public string CoverImage { get; set; }
        [Required(ErrorMessage ="Nomre daxil edin...")]
        [MaxLength(50)]
        public string QueryNumber { get; set; }
        [Required(ErrorMessage = "Adress daxil edin...")]
        [MaxLength(100)]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Nomre daxil edin...")]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email daxil edin...")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Is vaxdini daxil edin...")]
        [MaxLength(50)]
        public string WorkTime { get; set; }

    }
}