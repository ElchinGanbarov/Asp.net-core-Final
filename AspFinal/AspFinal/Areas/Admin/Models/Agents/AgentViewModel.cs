using Microsoft.AspNetCore.Http;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspFinal.Areas.Admin.Models.Agents
{
    public class AgentViewModel
    {
        [Required(ErrorMessage = "Veziyyeti daxil edin..")]
        public bool Status { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad daxil edin..")]
        [MaxLength(50)]
        public string Name { get; set; }
        public IFormFile File { get; set; }
        [Required(ErrorMessage = "Is tecrubesini daxil edin..")]
        [MaxLength(50)]
        public string WorkExperience { get; set; }
        [Required(ErrorMessage = "Servisi secin...")]
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
    }
}
