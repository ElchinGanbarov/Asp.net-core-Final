using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Category:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Count { get; set; }
        [Required]
        [Column(TypeName ="ntext")]
        public string Description { get; set; } 
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
        public string Image { get; set; }
        public IEnumerable<Agent> Agents { get; set; }
        public IEnumerable<CategorySpecs> CategorySpecs { get; set; }
    }
}
