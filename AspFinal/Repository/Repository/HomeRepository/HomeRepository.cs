using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository.HomeRepository
{
    public interface IHomeRepository
    {
        IEnumerable<HomeSlider> GetHomeSliders();
        IEnumerable<AboutUs> GetAboutUs();
        IEnumerable<Category> GetCategories();
        IEnumerable<Settings> GetSettings();
        IEnumerable<Agent> GetAgents();
        IEnumerable<Brand> GetBrands();
        IEnumerable<LikeableArea> GetLikeableAreas();
        IEnumerable<Testimonial> GetTestimonials();
        IEnumerable<HomeSlider> GetFullHomeSlider();
        IEnumerable<Blog> GetBlogs(int count);
        IEnumerable<Agent> GetCaseAgent();
        Contact CreateComment(Contact home);
        Settings SingleSetting();
        IEnumerable<ContactUss> GetContactUs();
        IEnumerable<Agent> GetAllAgents();
        HomeSlider CreateHomeSlider(HomeSlider homeslider);
        AboutUs GetSingleAbout();
        HomeSlider GEtHomeSliderById(int id);
        void UpdateSlide(HomeSlider updateslide, HomeSlider slide);
        void DeleteSlide(HomeSlider slide);
        Agent AddAgent(Agent agent);
        Agent GetAgentById(int id);
        IEnumerable<FAQ> GetFaqs(int count);
        void UpdateAgent(Agent updateAgent, Agent agent);
        void RemoveAgent(Agent agent);
        Comments CreateCommented(Comments home);
        IEnumerable<Comments> CommentsList();
    }
    public class HomeRepository : IHomeRepository
    {
        private readonly JotexDbContext _context;
        public HomeRepository(JotexDbContext context)
        {
            _context = context;
        }

        public Agent AddAgent(Agent agent)
        {
            _context.Agents.Add(agent);
            _context.SaveChanges();
            return agent;
        }

        public IEnumerable<Comments> CommentsList()
        {
            return _context.Comments.Where(c => c.Status).ToList();
        }

        public Contact CreateComment(Contact home)
        {
            home.AddedBy = "System";
            home.Status = true;
            home.AddedDate = DateTime.Now;
            _context.Contacts.Add(home);
            _context.SaveChanges();
            return home;
        }

        public Comments CreateCommented(Comments home)
        {
            _context.Comments.Add(home);
            _context.SaveChanges();
            return home;
        }

        public HomeSlider CreateHomeSlider(HomeSlider homeslider)
        {
            _context.HomeSliders.Add(homeslider);
            _context.SaveChanges();
            return homeslider;
        }

        public void DeleteSlide(HomeSlider slide)
        {
             _context.HomeSliders.Remove(slide);
            _context.SaveChanges();

        }

        public IEnumerable<AboutUs> GetAboutUs()
        {
            return _context.AboutUs.Where(a => a.Status).Include(a => a.AboutDetails).ToList();
        }

        public Agent GetAgentById(int id)
        {
            var agent = _context.Agents.Find(id);
            return agent;
        }

        public IEnumerable<Agent> GetAgents()
        {
            return _context.Agents.Where(a => a.Status).Include(a=>a.Category).ToList();
        }

        public IEnumerable<Agent> GetAllAgents()
        {
            return _context.Agents.Include(a=>a.Category).ToList();
        }

        public IEnumerable<Blog> GetBlogs(int count)
        {
            return _context.Blogs.Where(b => b.Status).Include(b=>b.Images).Take(count).ToList();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.Where(b => b.Status).ToList();
        }

        public IEnumerable<Agent> GetCaseAgent()
        {
            return _context.Agents.Where(a => a.Status).Take(3).ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.Where(c => c.Status).Include(c => c.CategorySpecs).ToList();
        }

        public IEnumerable<ContactUss> GetContactUs()
        {
            return _context.ContactUs.Where(c => c.Status).ToList();
        }

        public IEnumerable<FAQ> GetFaqs(int count)
        {
            return _context.FAQs.Where(f => f.Status).Take(count).ToList();
        }

        public IEnumerable<HomeSlider> GetFullHomeSlider()
        {
            return _context.HomeSliders.ToList();
        }

        public HomeSlider GEtHomeSliderById(int id)
        {
            return _context.HomeSliders.Find(id);
        }

        public IEnumerable<HomeSlider> GetHomeSliders()
        {
            return _context.HomeSliders.Where(h => h.Status).OrderBy(h => h.OrderBy).ToList();
        }

        public IEnumerable<LikeableArea> GetLikeableAreas()
        {
            return _context.LikeableAreas.Where(l => l.Status).ToList();
        }

        public AboutUs GetSingleAbout()
        {
            return _context.AboutUs.Include(a => a.AboutClaims).Include(a => a.AboutDetails).Include(a => a.AboutPolicies).FirstOrDefault();
        }

        public IEnumerable<Testimonial> GetTestimonials()
        {
            return _context.Testimonials.Where(t => t.Status).ToList();
        }

        public void RemoveAgent(Agent agent)
        {
            _context.Agents.Remove(agent);
            _context.SaveChanges();
        }

        public IEnumerable<Settings> Setting()
        {
            return _context.Settings.Where(b=>b.Status).ToList();
        }

        public Settings SingleSetting()
        {
            return _context.Settings.FirstOrDefault();
        }

        public void UpdateAgent(Agent updateAgent, Agent agent)
        {
            updateAgent.Status = agent.Status;
            updateAgent.Name = agent.Name;
            updateAgent.WorkExperience = agent.WorkExperience;
            updateAgent.CategoryId = agent.CategoryId;
            _context.SaveChanges();
        }

        public void UpdateSlide(HomeSlider updateslide, HomeSlider slide)
        {
            updateslide.Status = slide.Status;
            updateslide.Slogan = slide.Slogan;
            updateslide.ActionText = slide.ActionText;
            updateslide.EndPoint = slide.EndPoint;
            updateslide.Title = slide.Title;
            updateslide.OrderBy = slide.OrderBy;
            updateslide.Image = slide.Image;
            _context.SaveChanges();

        }

        IEnumerable<Settings> IHomeRepository.GetSettings()
        {
            return _context.Settings.Where(s => s.Status).ToList();
        }
    }
}
