using Microsoft.AspNetCore.Http;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Areas.Admin.Models.BlogTables
{
    public class BlogImagesViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage ="Seciminizi edin...")]
        public int BlogId { get; set; }
        public string Image { get; set; }
        public IFormFile File { get; set; }
        public Blog Blog { get; set; }
    }
}
