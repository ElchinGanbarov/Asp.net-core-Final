using AspFinal.Models.Contact;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models
{
    public class HomeViewModel
    {
        public IEnumerable<AboutUs> AboutUs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Settings> Settings { get; set; }
        public IEnumerable<Agent> Agents { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<LikeableArea> LikeableAreas { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Blog> Cases { get; set; }
        public ContactUsViewModel ContactUs { get; set; }
        public ContactViewModel Contact { get; set; }
        public CaseStudiesSingle CaseStudies { get; set; }
        public IEnumerable<Solution> Solutions { get; set; }







    }
}
