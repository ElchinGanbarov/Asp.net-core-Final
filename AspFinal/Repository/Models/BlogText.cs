using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class BlogText : BaseEntity
    {
        [Required]
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
