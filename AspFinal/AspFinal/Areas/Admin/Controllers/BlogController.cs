using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Allaia.Libs;
using AspFinal.Areas.Admin.Models.Agents;
using AspFinal.Areas.Admin.Models.BlogTables;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.BlogRepository;
using Repository.Repository.CategoryRepository;
using Repository.Repository.HomeRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class BlogController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IBlogRepository _blogrepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public BlogController(IBlogRepository blogrepository, IMapper mapper, IFileManager fileManager)
        {
            _blogrepository = blogrepository;
            _mapper = mapper;
            _fileManager = fileManager;
            
        }
        public IActionResult Index()
        {
            var blogs = _blogrepository.GetAllBlogs();
            var model = _mapper.Map<IEnumerable<Blog>, IEnumerable<BlogTablesViewModel>>(blogs);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogTablesViewModel model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                var blog = _mapper.Map<BlogTablesViewModel, Blog>(model);
                blog.AddedBy = _admin.Name;
                blog.AddedDate = DateTime.Now;
                if (model.File != null)
                {
                    blog.Image = _fileManager.Upload(model.File);

                }
                else
                {
                    blog.Image = null;
                }
                _blogrepository.AddBlog(blog);
                return RedirectToAction("index");
            }
            return View(model);
        }
        //public IActionResult Edit(int id)
        //{
        //    ViewBag.Categories = _categoryyRepository.GetFullCategories();
        //    var agent = _homeRepository.GetAgentById(id);
        //    var model = _mapper.Map<Agent, AgentViewModel>(agent);
        //    return View(model);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(AgentViewModel model)
        //{
        //    var agent = _mapper.Map<AgentViewModel, Agent>(model);

        //    if (model == null) return NotFound();

        //    if (ModelState.IsValid)
        //    {
        //        var updateAgent = _homeRepository.GetAgentById(model.Id);

        //        updateAgent.ModifiedBy = _admin.Name;
        //        updateAgent.ModifiedDate = DateTime.Now;
        //        if (model.File == null)
        //        {
        //            agent.Image = updateAgent.Image;
        //        }
        //        else
        //        {
        //            agent.Image = _fileManager.Upload(model.File);

        //        }
        //        _homeRepository.UpdateAgent(updateAgent, agent);

        //        return RedirectToAction("index");
        //    }
        //    return View(model);
        //}
        //public IActionResult Remove(int id)
        //{
        //    var agent = _homeRepository.GetAgentById(id);
        //    _homeRepository.RemoveAgent(agent);
        //    _fileManager.Delete(agent.Image);
        //    var agents = _homeRepository.GetAllAgents();
        //    var model = _mapper.Map<IEnumerable<Agent>, IEnumerable<AgentViewModel>>(agents);
        //    return PartialView("index", model);
        //}
    }
}