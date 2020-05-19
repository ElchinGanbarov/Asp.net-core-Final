using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Brand:BaseEntity
    {
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
