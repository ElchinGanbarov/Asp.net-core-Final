using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class BlogImages:BaseEntity
    {
        public int BlogId { get; set; }
        public string Image { get; set; }
        public Blog Blog { get; set; }
    }
}
