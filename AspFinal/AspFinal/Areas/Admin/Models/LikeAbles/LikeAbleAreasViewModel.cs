using Microsoft.AspNetCore.Http;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Areas.Admin.Models.LikeAbles
{
    public class LikeAbleAreasViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        [Required]
        public int Experince { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        public string Photo { get; set; }
        public IFormFile File { get; set; }
        public int AboutUsId { get; set; }
        public AboutUs AboutUs { get; set; }

    }
}
