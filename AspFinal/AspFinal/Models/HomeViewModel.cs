using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models
{
    public class HomeViewModel
    {
        public IEnumerable<HomeSlider> HomeSliders { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
