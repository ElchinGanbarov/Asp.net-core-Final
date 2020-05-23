using AspFinal.Areas.Admin.Models.Account;
using AspFinal.Areas.Admin.Models.Agents;
using AspFinal.Areas.Admin.Models.BlogTables;
using AspFinal.Areas.Admin.Models.HomeImages;
using AspFinal.Areas.Admin.Models.Services;
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
            CreateMap<HomeSlider, HomeSliderViewModel>();

            CreateMap<ContactViewModel, Contact>();
            CreateMap<CommentViewModel, Comments>();

            CreateMap<RegisterViewModel, Repository.Models.Admin>();


            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();

            CreateMap<HomeSlider, SlideViewModel>();
            CreateMap<SlideViewModel, HomeSlider>();

            CreateMap<Agent, AgentViewModel>();
            CreateMap<AgentViewModel, Agent>();

            CreateMap<Blog, BlogTablesViewModel>();
            CreateMap<BlogTablesViewModel, Blog>();





        }
    }
}
