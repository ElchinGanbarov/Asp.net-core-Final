using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models.Blogs
{
    public class CommentViewModel
    {
        [Required(ErrorMessage ="Ad daxil edin...")]
        [MaxLength(50,ErrorMessage ="Maksimum 50 karekter olmalidir...")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Text daxil edin...")]
        [MaxLength(500,ErrorMessage ="Maksimum 500 xarekter olmalidir...")]
        public string Text { get; set; }
        [Required(ErrorMessage ="Email daxil edin..")]
        [MaxLength(50,ErrorMessage ="Maksimum 50 xarekter olmalidir...")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Website daxil edin...")]
        [MaxLength(50,ErrorMessage ="Maksimum 50 xarakter olmalidir")]
        public string Website { get; set; }
    }
}
