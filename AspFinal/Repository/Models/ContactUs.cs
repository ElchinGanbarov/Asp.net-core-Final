using Repository.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ContactUs:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email1 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email2 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Adress  { get; set; }
        [Required]
        [MaxLength(50)]
        public string PhoneNum1 { get; set; }
        [Required]
        [MaxLength(50)]
        public string PhoneNum2 { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int ImagesId { get; set; }
        public Images Images { get; set; }

    }
}
