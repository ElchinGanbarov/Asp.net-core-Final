using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Areas.Admin.Models.Account
{
    [MetadataType(typeof(RegisterViewModel))]
    public class RegisterViewModel
    {
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
        ErrorMessage = "Characters are not allowed.")]
        [Required(ErrorMessage = "Ad daxil edin...")]
        [MaxLength(50, ErrorMessage = "Ad maximum 50 xarakter ola bilər...")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadi daxil edin...")]
        [MaxLength(50, ErrorMessage = "Soayd maximum 50 xarakter ola bilər")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "E-mail daxil edin...")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Duzgun email daxil edin")]
        [MaxLength(50, ErrorMessage = "Email maximum 50 xarakter ola bilər")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Duzgun E-mail daxil edin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrə daxil edin...")]
        [MaxLength(50, ErrorMessage = "Şifrə maximum 50 xarakter ola bilər")]
        [MinLength(6, ErrorMessage = "Şifrə minumum 6 xarakter ola bilər")]
        [Compare("Password", ErrorMessage = "Şifrə və şifrə təsdiqi eyni olmalıdır")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifrə daxil edin..")]
        [MaxLength(50, ErrorMessage = "Şifrə maximum 50 xarakter ola bilər")]
        [MinLength(6, ErrorMessage = "Şifrə minumum 6 xarakter ola bilər")]
        [Compare("Password", ErrorMessage = "Şifrə və şifrə təsdiqi eyni olmalıdır")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}

