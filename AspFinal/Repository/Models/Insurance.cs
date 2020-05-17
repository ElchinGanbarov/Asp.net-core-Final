using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Insurance:BaseEntity
    {
        public int AgentId { get; set; }
        public int CategoryId { get; set; }
        public Agent Agent { get; set; }
        public Category Category { get; set; }
    }
}
