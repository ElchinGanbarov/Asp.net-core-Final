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
    }
    public class HomeRepository : IHomeRepository
    {
        private readonly JotexDbContext _context;
        public HomeRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<HomeSlider> GetHomeSliders()
        {
            return _context.HomeSliders.Include(h=>h.Images).ToList();
        }
    }
}
