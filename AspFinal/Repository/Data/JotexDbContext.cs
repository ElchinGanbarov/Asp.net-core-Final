using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Repository.Data
{
    public class JotexDbContext : DbContext
    {
        public JotexDbContext(DbContextOptions<JotexDbContext> options) : base(options)
        {

        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<CategorySpecs> CategorySpecs { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<AboutDetail> AboutDetails { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<LikeableArea> LikeableAreas { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogText> BlogTexts { get; set; }






    }
}
