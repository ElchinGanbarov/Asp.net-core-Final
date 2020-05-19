using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository.CategoryRepository
{
    public interface ICategoryRepository
    {

    }
    public class CategoryRepository : ICategoryRepository
    {
        private readonly JotexDbContext _context;
        public CategoryRepository(JotexDbContext context)
        {
            _context = context;
        }

     
    }
}
