using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models.Contact
{
    public class DetailViewModel
    {
        public ContactViewModel Comment { get; set; }
        public IEnumerable<ContactUss> ContactUs { get; set; }
    }
}
