using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
     public class Solution:BaseEntity
    {
        [Required(ErrorMessage ="Acar sozu daxil edin...")]
        [MaxLength(100)]
        public string Key { get; set; }
        [Required(ErrorMessage ="Valuesini daxil edin...")]
        [Column(TypeName ="ntext")]
        public string Value { get; set; }

    }
}
