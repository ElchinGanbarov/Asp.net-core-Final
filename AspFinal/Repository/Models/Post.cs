using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Post:BaseEntity
    {
        public int ImagesId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public Images Images { get; set; }
    }
}
