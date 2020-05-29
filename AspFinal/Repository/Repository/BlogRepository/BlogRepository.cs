using Microsoft.EntityFrameworkCore;
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
        IEnumerable<Blog> GetBlogText();
        Blog AddBlog(Blog blog);
        Blog GetBlogById(int id);
        void UpdateBlog(Blog updateBlog, Blog blog);
        void RemoveBlog(Blog blog);
        IEnumerable<BlogText> GetBlogTextLIst();
        BlogText AddBlogtext(BlogText model);
        IEnumerable<Settings> GetStatusList();
        BlogText GetBlogTextById(int id);
        void UpdateBlogtext(BlogText updateBlogTExt, BlogText model);
        void RemoveBlogText(BlogText model);
        IEnumerable<BlogText> GetBlogStatus();
        Settings AddSetting(Settings setting);
        Settings GetSettingById(int id);
        void UpdateSetting(Settings updateSetting, Settings setting);
        void RemoveSetting(Settings settings);
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

        public IEnumerable<Blog> GetBlogText()
        {
            return _context.Blogs.ToList();
        }

        public Blog GetBlogById(int id)
        {
            return _context.Blogs.Find(id);
        }

        public void RemoveBlog(Blog blog)
        {
             _context.Blogs.Remove(blog);
            _context.SaveChanges();
            
        }

        public void UpdateBlog(Blog updateBlog, Blog blog)
        {
            updateBlog.Status = blog.Status;
            updateBlog.ActionText = blog.ActionText;
            updateBlog.Title = blog.Title;
            updateBlog.ConpanyName = blog.ConpanyName;
            updateBlog.Image = blog.Image;
            _context.SaveChanges();
        }

        public IEnumerable<BlogText> GetBlogTextLIst()
        {
            return _context.BlogTexts.Include(b => b.Blog).ToList();
        }

        public BlogText AddBlogtext(BlogText model)
        {
            _context.BlogTexts.Add(model);
            _context.SaveChanges();
            return model;
        }

        public BlogText GetBlogTextById(int id)
        {
            return _context.BlogTexts.Find(id);
        }

        public void UpdateBlogtext(BlogText updateBlogTExt, BlogText model)
        {
            updateBlogTExt.BlogId = model.BlogId;
            updateBlogTExt.Text = model.Text;
            _context.SaveChanges();
        }

        public void RemoveBlogText(BlogText model)
        {
            _context.BlogTexts.Remove(model);
            _context.SaveChanges();
        }

        public IEnumerable<BlogText> GetBlogStatus()
        {
            return _context.BlogTexts.Include(b => b.Blog).ToList();
        }

        public IEnumerable<Settings> GetStatusList()
        {
            return _context.Settings.ToList();
        }

        public Settings AddSetting(Settings setting)
        {
            _context.Settings.Add(setting);
            _context.SaveChanges();
            return setting;
        }

        public Settings GetSettingById(int id)
        {
            return _context.Settings.Find(id);
        }

        public void UpdateSetting(Settings updateSetting, Settings setting)
        {
            updateSetting.Status = setting.Status;
            updateSetting.Adress = setting.Adress;
            updateSetting.Phone = setting.Phone;
            updateSetting.QueryNumber = setting.QueryNumber;
            updateSetting.Logo = setting.Logo;
            updateSetting.Logo2 = setting.Logo2;

            updateSetting.CoverImage = setting.CoverImage;
            updateSetting.Email = setting.Email;
            updateSetting.WorkTime = setting.WorkTime;
            _context.SaveChanges();
        }

        public void RemoveSetting(Settings settings)
        {
            _context.Settings.Remove(settings);
            _context.SaveChanges();
        }
    }
}
