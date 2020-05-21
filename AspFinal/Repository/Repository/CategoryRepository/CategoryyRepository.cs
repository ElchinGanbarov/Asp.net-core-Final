using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository.CategoryRepository
{
    public interface ICategoryyRepository
    {
        Comments CreateCommetns(Comments comments);
        IEnumerable<Post> GetPosts();
        IEnumerable<Tags> GetTags();
        IEnumerable<AboutUs> GetAbouts();
        IEnumerable<Category> GetCategories();

        Comments CreateContact(Comments model);
    }
    public class CategoryyRepository : ICategoryyRepository
    {
        private readonly JotexDbContext _context;
        public CategoryyRepository(JotexDbContext context)
        {
            _context = context;
        }

        public Comments CreateCommetns(Comments comments)
        {
            comments.AddedDate = DateTime.Now;
            comments.Status = true;
            comments.AddedBy = "System";
            _context.Comments.Add(comments);
            _context.SaveChanges();
            return comments;
        }

        public Comments CreateContact(Comments model)
        {
            model.AddedDate = DateTime.Now;
            model.Status = true;
            model.AddedBy = "System";        
            _context.Add(model);
            _context.SaveChanges();
            return model;
        }

        public IEnumerable<AboutUs> GetAbouts()
        {
            return _context.AboutUs.Where(a => a.Status).ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.Where(a => a.Status).ToList();
        }

        public IEnumerable<Post> GetPosts()
        {
            return _context.Posts.Where(a => a.Status).ToList();
        }

        public IEnumerable<Tags> GetTags()
        {
            return _context.Tags.Where(a => a.Status).ToList();
        }
    }
}
