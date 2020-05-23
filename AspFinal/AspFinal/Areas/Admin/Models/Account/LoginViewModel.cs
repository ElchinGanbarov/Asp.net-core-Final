using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Areas.Admin.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail vacibdir")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Duzgun email daxil edin")]
        [MaxLength(50, ErrorMessage = "Email maximum 50 xarakter ola bilər")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Duzgun E-mail daxil edin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrə vacibdir")]
        [MaxLength(50, ErrorMessage = "Şifrə maximum 50 xarakter ola bilər")]
        [MinLength(6, ErrorMessage = "Şifrə minumum 6 xarakter ola bilər")]
        [Compare("Password", ErrorMessage = "Şifrə və şifrə təsdiqi eyni olmalıdır")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
