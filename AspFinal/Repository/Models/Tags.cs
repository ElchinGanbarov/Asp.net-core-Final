using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Tags:BaseEntity
    {
        [Required(ErrorMessage ="Ad yazin...")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
