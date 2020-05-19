using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class CategorySpecs:BaseEntity
    {
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(100)]
        public string Key { get; set; }
        [Required]
        [MaxLength(100)]
        public string Value { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
