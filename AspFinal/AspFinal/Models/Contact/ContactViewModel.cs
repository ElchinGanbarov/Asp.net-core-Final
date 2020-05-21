using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models.Contact
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Ad daxil edin...")]
        [MaxLength(50,ErrorMessage ="Maksimum 50 xarakter olmalidir...")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email daxil edin...")]
        [MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalidir...")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Nomrenizi daxil edin...")]
        [MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalidir...")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Bir subject secin...")]
        [MaxLength(50)]
        public string Contactsubject { get; set; }
        [Required(ErrorMessage = "Text daxil edin...")]
        [MaxLength(500,ErrorMessage ="Maksimum 500 xarakter olmalidir")]
        public string Description { get; set; }
    }
}
