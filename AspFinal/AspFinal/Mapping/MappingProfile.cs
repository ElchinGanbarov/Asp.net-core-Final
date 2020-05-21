using AspFinal.Models;
using AspFinal.Models.Blogs;
using AspFinal.Models.Contact;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<HomeSlider, HomeSliderViewModel>();
            CreateMap<ContactViewModel, Contact>();
            CreateMap<CommentViewModel, Comments>();

        }
    }
}
