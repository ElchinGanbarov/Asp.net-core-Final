using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class CaseStudiesSingle:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Subtitle { get; set; }
        [Required]
        [Column(TypeName ="ntext")]
        public string Text { get; set; }
        public string Image { get; set; }
        public IEnumerable<CaseStudiesSpec> CaseStudiesSpecs { get; set; }
    }
}
