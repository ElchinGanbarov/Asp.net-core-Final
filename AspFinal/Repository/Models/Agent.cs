using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Agent:BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int ImagesId { get; set; }
        public Images Images { get; set; }
        public IEnumerable<Insurance> Insurances { get; set; }
    }
}
