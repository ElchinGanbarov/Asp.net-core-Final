using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class CategorySpecs:BaseEntity
    {
        [Required(ErrorMessage ="Sirasini daxil edin...")]
        public int OrderBy { get; set; }
        [Required(ErrorMessage ="Acar sozu daxil edin...")]
        [MaxLength(100)]
        public string Key { get; set; }
        [Required(ErrorMessage = "Acar sozu daxil edin...")]
        [MaxLength(100)]
        public string Value { get; set; }
        [Required(ErrorMessage ="Servisini secin...")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
