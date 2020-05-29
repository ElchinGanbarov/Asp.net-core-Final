using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class LikeableArea : BaseEntity
    {
        [Required]
        public int Experince { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        public string Photo { get; set; }
        public int AboutUsId { get; set; }
        public AboutUs AboutUs { get; set; }

    }
}