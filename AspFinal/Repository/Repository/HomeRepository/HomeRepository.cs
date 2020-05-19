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
    }
    public class HomeRepository : IHomeRepository
    {
        private readonly JotexDbContext _context;
        public HomeRepository(JotexDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AboutUs> GetAboutUs()
        {
            return _context.AboutUs.Where(a => a.Status).Include(a=>a.AboutDetails).ToList();
        }

        public IEnumerable<Agent> GetAgents()
        {
            return _context.Agents.Where(a => a.Status).ToList();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.Where(b => b.Status).ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.Where(c => c.Status).Include(c=>c.CategorySpecs).ToList();
        }

        public IEnumerable<HomeSlider> GetHomeSliders()
        {
            return _context.HomeSliders.Where(h => h.Status).OrderBy(h => h.OrderBy).ToList();
        }

        public Settings GetSettings()
        {
            return _context.Settings.Where(s => s.Status).FirstOrDefault();
        }
    }
}
