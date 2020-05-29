using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models.AboutUsFolder
{
    public class AboutUsViewModel
    {
        public Settings Settings { get; set; }
        public AboutUs AboutUs { get; set; }
        public IEnumerable<Agent> Agents { get; set; }
        public IEnumerable<Brand> Brands { get; set; }

    }
}
