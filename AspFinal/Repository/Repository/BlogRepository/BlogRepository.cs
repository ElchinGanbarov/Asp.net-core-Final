using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository.BlogRepository
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetAllBlogs();
        Blog AddBlog(Blog blog);
    }
    public class BlogRepository : IBlogRepository
    {
        private readonly JotexDbContext _context;
        public BlogRepository(JotexDbContext context)
        {
            _context = context;
        }

        public Blog AddBlog(Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return blog;
        }

        public IEnumerable<Blog> GetAllBlogs()
        {
            return _context.Blogs.ToList();
        }
    }
}
