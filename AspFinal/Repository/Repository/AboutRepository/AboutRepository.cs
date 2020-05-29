using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository.AboutRepository
{
    public interface IAboutRepository
    {
        IEnumerable<Tags> GetTags();
        Tags TagCreat(Tags model);
        Tags GetTagsById(int id);
        void UpdateTag(Tags updatetag, Tags model);
        void RemoveTags(Tags tags);
        IEnumerable<Brand> GetBrandsAll();
        Brand AddBrand(Brand brand);
        Brand GetBrandById(int id);
        void UpdateBrand(Brand updateBrand, Brand brand);
        void RemoveBrand(Brand brand);
        IEnumerable<Testimonial> GetTestmonials();
        Testimonial CreatTestmonial(Testimonial model);
        Testimonial TestmonialById(int id);
        void TestmonialUpdate(Testimonial updatetestmonial, Testimonial model);
        IEnumerable<AboutDetail> GetAboutDetail();
        void RemoveTestmonial(Testimonial testmonial);
        IEnumerable<LikeableArea> GetLikeAbleAreas();
        LikeableArea AddLikeAble(LikeableArea like);
        IEnumerable<AboutUs> GetAboutFull();
        LikeableArea GetLikeAreById(int id);
        void UpdateLikeArea(LikeableArea updateLike, LikeableArea like);
        void RemoveLikeArea(LikeableArea like);
        AboutDetail CreateAboutUs(AboutDetail model);
        AboutDetail GetAboutUsById(int id);
        void UpdateDetail(AboutDetail updateAboutDetail, AboutDetail model);
        void RemoveAboutDetail(AboutDetail casespecs);
    }
    public class AboutRepository : IAboutRepository
    {
        private readonly JotexDbContext _context;
        public AboutRepository(JotexDbContext context)
        {
            _context = context;
        }

        public Brand AddBrand(Brand brand)
        {
            _context.Brands.Add(brand);
            _context.SaveChanges();
            return brand;
        }

        public LikeableArea AddLikeAble(LikeableArea like)
        {
            _context.LikeableAreas.Add(like);
            _context.SaveChanges();
            return like;
        }

        public AboutDetail CreateAboutUs(AboutDetail model)
        {
            _context.AboutDetails.Add(model);
            _context.SaveChanges();
            return model;
        }

        public Testimonial CreatTestmonial(Testimonial model)
        {
            _context.Testimonials.Add(model);
            _context.SaveChanges();
            return model;
        }

        public IEnumerable<AboutDetail> GetAboutDetail()
        {
            return _context.AboutDetails.Include(a => a.AboutUs).ToList();
        }

        public IEnumerable<AboutUs> GetAboutFull()
        {
            return _context.AboutUs.Where(a => a.Status).ToList();
        }

        public AboutDetail GetAboutUsById(int id)
        {
            return _context.AboutDetails.Include(a => a.AboutUs).FirstOrDefault(b=>b.Id==id);
        }
        public Brand GetBrandById(int id)
        {
            return _context.Brands.Find(id);
        }

        public IEnumerable<Brand> GetBrandsAll()
        {
            return _context.Brands.ToList();
        }

        public IEnumerable<LikeableArea> GetLikeAbleAreas()
        {
            return _context.LikeableAreas.Include(l=>l.AboutUs).ToList();
        }

        public LikeableArea GetLikeAreById(int id)
        {
            return _context.LikeableAreas.Find(id);
        }

        public IEnumerable<Tags> GetTags()
        {
            return _context.Tags.ToList();
        }

        public Tags GetTagsById(int id)
        {
            return _context.Tags.Find(id);
        }

        public IEnumerable<Testimonial> GetTestmonials()
        {
            return _context.Testimonials.ToList();
        }

        public void RemoveAboutDetail(AboutDetail casespecs)
        {
            _context.AboutDetails.Remove(casespecs);
            _context.SaveChanges();
        }

        public void RemoveBrand(Brand brand)
        {
            _context.Brands.Remove(brand);
            _context.SaveChanges();
        }

        public void RemoveLikeArea(LikeableArea like)
        {
            _context.LikeableAreas.Remove(like);
            _context.SaveChanges();
        }

        public void RemoveTags(Tags tags)
        {
            _context.Tags.Remove(tags);
            _context.SaveChanges();
        }

        public void RemoveTestmonial(Testimonial testmonial)
        {
            _context.Testimonials.Remove(testmonial);
            _context.SaveChanges();
        }

        public Tags TagCreat(Tags model)
        {
            _context.Tags.Add(model);
            _context.SaveChanges();
            return model;
        }

        public Testimonial TestmonialById(int id)
        {
            return _context.Testimonials.Find(id);
        }

        public void TestmonialUpdate(Testimonial updatetestmonial, Testimonial model)
        {
            updatetestmonial.Status = model.Status;
            updatetestmonial.Name = model.Name;

            updatetestmonial.Review = model.Review;

            updatetestmonial.WorkExperience = model.WorkExperience;
            _context.SaveChanges();



        }

        public void UpdateBrand(Brand updateBrand, Brand brand)
        {
            updateBrand.Status = brand.Status;
            updateBrand.Name = brand.Name;

            updateBrand.Logo = brand.Logo;

            _context.SaveChanges();

        }

        public void UpdateDetail(AboutDetail updateAboutDetail, AboutDetail model)
        {
            updateAboutDetail.Status = model.Status;
            updateAboutDetail.Logo = model.Logo;
            updateAboutDetail.Key = model.Key;
            updateAboutDetail.AboutUsId = model.AboutUsId;
            updateAboutDetail.Value = model.Value;
            _context.SaveChanges();



        }

        public void UpdateLikeArea(LikeableArea updateLike, LikeableArea like)
        {
            updateLike.Status = like.Status;
            updateLike.Text = like.Text;

            updateLike.ActionText = like.ActionText;

            updateLike.Experince = like.Experince;
            updateLike.AboutUsId = like.AboutUsId;
            updateLike.Title = like.Title;
            updateLike.Photo = like.Photo;

            _context.SaveChanges();




        }

        public void UpdateTag(Tags updatetag, Tags model)
        {
            updatetag.Status = model.Status;
            updatetag.Name = model.Name;
            _context.SaveChanges();
        }
    }
}
