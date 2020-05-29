using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
     public class FAQ:BaseEntity
    {
        [Required (ErrorMessage ="Sual daxil edin...")]
        [MaxLength(100,ErrorMessage ="Maksimum 100 xarakter ola biler...")]
        public string Question { get; set; }
        [Required(ErrorMessage = "Cavab daxil edin...")]
        [MaxLength(500, ErrorMessage = "Maksimum 500 xarakter ola biler...")]
        public string Answer { get; set; }

    }
}
