using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Areas.Admin.Models.BlogTables
{
    public class BlogTablesViewModel
    {
        [Required(ErrorMessage ="Veziyyeti daxil edin...")]
        public bool Status { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage ="Basliq daxil edin...")]
        [MaxLength(100,ErrorMessage ="Maksimum 100 xarekter ola biler...")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Metn daxil edin...")]
        [MaxLength(500, ErrorMessage = "Maksimum 500 xarekter ola biler...")]
        public string Text { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Sirket adi daxil edin...")]
        [MaxLength(100)]
        public string ConpanyName { get; set; }
        [Required(ErrorMessage = "Action texti adi daxil edin...")]
        [MaxLength(100)]
        public string ActionText { get; set; }
        public IFormFile File { get; set; }
    }
}
