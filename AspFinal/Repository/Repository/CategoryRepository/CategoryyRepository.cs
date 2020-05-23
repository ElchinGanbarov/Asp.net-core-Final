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
        IEnumerable<Category> GetFullCategories();
        Comments CreateContact(Comments model);
        Category AddCategory(Category category);
        IEnumerable<CategorySpecs> GetFullCategorySpecs();
        Category GetCategoryById(int id);
        void UpdateCategory(Category updateCategory, Category category);
        void RemoveCategoryId(Category category);
        CategorySpecs CreateCategorySpecs(CategorySpecs model);
        CategorySpecs GetCategorySpecsById(int id);
        void UpdateCategorySpecs(CategorySpecs updatecategoryspecs, CategorySpecs model);
        void RemoveCategoryspecsId(CategorySpecs categoryspecs);
    }
    public class CategoryyRepository : ICategoryyRepository
    {
        private readonly JotexDbContext _context;
        public CategoryyRepository(JotexDbContext context)
        {
            _context = context;
        }

       

        public Category AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public CategorySpecs CreateCategorySpecs(CategorySpecs model)
        {
            _context.CategorySpecs.Add(model);
            _context.SaveChanges();
            return model;
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

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public CategorySpecs GetCategorySpecsById(int id)
        {
            return _context.CategorySpecs.Include(c=>c.Category).FirstOrDefault(c=>c.Id==id);
        }

        public IEnumerable<Category> GetFullCategories()
        {
            return _context.Categories.ToList();
        }

        public IEnumerable<CategorySpecs> GetFullCategorySpecs()
        {
            return _context.CategorySpecs.Include(c=>c.Category).ToList();
        }

        public IEnumerable<Post> GetPosts()
        {
            return _context.Posts.Where(a => a.Status).ToList();
        }

        public IEnumerable<Tags> GetTags()
        {
            return _context.Tags.Where(a => a.Status).ToList();
        }

        public void RemoveCategoryId(Category category)
        {
             
            _context.RemoveRange(category);
            _context.SaveChanges();
        }

        public void RemoveCategoryspecsId(CategorySpecs categoryspecs)
        {
            _context.CategorySpecs.Remove(categoryspecs);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category updateCategory, Category category)
        {
            updateCategory.Status = category.Status;
            updateCategory.Name = category.Name;
            updateCategory.Image = category.Image;
            updateCategory.Logo = category.Logo;
            updateCategory.Count = category.Count;
            updateCategory.Description = category.Description;

            _context.SaveChanges();
        }

        public void UpdateCategorySpecs(CategorySpecs updatecategoryspecs, CategorySpecs model)
        {
            updatecategoryspecs.Status = model.Status;
            updatecategoryspecs.Key = model.Key;
            updatecategoryspecs.Value = model.Value;
            updatecategoryspecs.CategoryId = model.CategoryId;
            updatecategoryspecs.OrderBy = model.OrderBy;
            _context.SaveChanges();

        }
    }
}
