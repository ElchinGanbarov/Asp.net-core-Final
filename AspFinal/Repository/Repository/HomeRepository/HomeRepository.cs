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
        Settings GetSettings();
        IEnumerable<Agent> GetAgents();
        IEnumerable<Brand> GetBrands();
        IEnumerable<LikeableArea> GetLikeableAreas();
        IEnumerable<Testimonial> GetTestimonials();
        IEnumerable<Blog> GetBlogs();
        IEnumerable<Agent> GetCaseAgent();
        Contact CreateComment(Contact home);
        IEnumerable<ContactUss> GetContactUs();
    }
    public class HomeRepository : IHomeRepository
    {
        private readonly JotexDbContext _context;
        public HomeRepository(JotexDbContext context)
        {
            _context = context;
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

        public IEnumerable<AboutUs> GetAboutUs()
        {
            return _context.AboutUs.Where(a => a.Status).Include(a => a.AboutDetails).ToList();
        }

        public IEnumerable<Agent> GetAgents()
        {
            return _context.Agents.Where(a => a.Status).Include(a=>a.Category).ToList();
        }

        public IEnumerable<Blog> GetBlogs()
        {
            return _context.Blogs.Where(b => b.Status).ToList();
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

        public IEnumerable<HomeSlider> GetHomeSliders()
        {
            return _context.HomeSliders.Where(h => h.Status).OrderBy(h => h.OrderBy).ToList();
        }

        public IEnumerable<LikeableArea> GetLikeableAreas()
        {
            return _context.LikeableAreas.Where(l => l.Status).ToList();
        }

        public Settings GetSettings()
        {
            return _context.Settings.Where(s => s.Status).FirstOrDefault();
        }

        public IEnumerable<Testimonial> GetTestimonials()
        {
            return _context.Testimonials.Where(t => t.Status).ToList();
        }
    }
}
