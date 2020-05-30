using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models.Contact
{
    public class DetailViewModel
    {
        public ContactViewModel Contact { get; set; }
        public IEnumerable<ContactUss> ContactUs { get; set; }
        public IEnumerable<Settings> Settings { get; set; }
    }
}
