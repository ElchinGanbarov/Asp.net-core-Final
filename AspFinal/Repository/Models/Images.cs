using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Images:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        public IEnumerable<HomeSlider> HomeSliders { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<AboutUs> AboutUs { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Agent> Agents { get; set; }
    }
}
