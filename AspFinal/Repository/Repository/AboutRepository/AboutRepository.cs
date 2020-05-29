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
        IEnumerable<AboutClaim> GetAboutClaim();
        IEnumerable<AboutPolicy> GetAboutPolicy();
        IEnumerable<AboutDetail> GetAboutDetail();
        void RemoveTestmonial(Testimonial testmonial);
        IEnumerable<LikeableArea> GetLikeAbleAreas();
        IEnumerable<AboutUs> GetFullAbouts();
        LikeableArea AddLikeAble(LikeableArea like);
        IEnumerable<AboutUs> GetAboutFull();
        LikeableArea GetLikeAreById(int id);
        void UpdateLikeArea(LikeableArea updateLike, LikeableArea like);
        void RemoveLikeArea(LikeableArea like);
        AboutDetail CreateAboutUs(AboutDetail model);
        AboutClaim CreateAboutClaim(AboutClaim model);
        AboutDetail GetAboutUsById(int id);
        AboutPolicy CreateAboutPolicy(AboutPolicy model);
        void UpdateDetail(AboutDetail updateAboutDetail, AboutDetail model);
        void RemoveAboutDetail(AboutDetail casespecs);
        AboutClaim AboutClaimById(int id);
        AboutPolicy AboutPolicylById(int id);
        void UpdatePolicy(AboutPolicy updateAboutPolicy, AboutPolicy model);
        void RemovePolicy(AboutPolicy policy);
        void UpdateClaim(AboutClaim updateAboutClaim, AboutClaim model);
        AboutUs AddAbout(AboutUs about);
        void RemoveClaim(AboutClaim claim);
        AboutUs GetAboutById(int id);
        void UpdateAbout(AboutUs updateAbout, AboutUs about);
        void RemoveAbout(AboutUs about);
    }
    public class AboutRepository : IAboutRepository
    {
        private readonly JotexDbContext _context;
        public AboutRepository(JotexDbContext context)
        {
            _context = context;
        }

        public AboutClaim AboutClaimById(int id)
        {
            return _context.AboutClaims.Include(a => a.AboutUs).FirstOrDefault(a => a.Id == id);
        }

        public AboutPolicy AboutPolicylById(int id)
        {
            return _context.AboutPolicies.Include(a => a.AboutUs).FirstOrDefault(b => b.Id == id);
        }

        public AboutUs AddAbout(AboutUs about)
        {
            _context.AboutUs.Add(about);
            _context.SaveChanges();
            return about;
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

        public AboutClaim CreateAboutClaim(AboutClaim model)
        {
            _context.AboutClaims.Add(model);
            _context.SaveChanges();
            return model;
        }

        public AboutPolicy CreateAboutPolicy(AboutPolicy model)
        {
            _context.AboutPolicies.Add(model);
            _context.SaveChanges();
            return model;
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

        public AboutUs GetAboutById(int id)
        {
            return _context.AboutUs.Find(id);
        }

        public IEnumerable<AboutClaim> GetAboutClaim()
        {
            return _context.AboutClaims.Include(a => a.AboutUs).ToList();
        }

        public IEnumerable<AboutDetail> GetAboutDetail()
        {
            return _context.AboutDetails.Include(a => a.AboutUs).ToList();
        }

        public IEnumerable<AboutUs> GetAboutFull()
        {
            return _context.AboutUs.Where(a => a.Status).ToList();
        }

        public IEnumerable<AboutPolicy> GetAboutPolicy()
        {
            return _context.AboutPolicies.Include(a=>a.AboutUs).ToList();
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

        public IEnumerable<AboutUs> GetFullAbouts()
        {
            return _context.AboutUs.ToList();
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

        public void RemoveAbout(AboutUs about)
        {
            _context.AboutUs.Remove(about);
            _context.SaveChanges();
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

        public void RemoveClaim(AboutClaim claim)
        {
            _context.AboutClaims.Remove(claim);
            _context.SaveChanges();
        }

        public void RemoveLikeArea(LikeableArea like)
        {
            _context.LikeableAreas.Remove(like);
            _context.SaveChanges();
        }

        public void RemovePolicy(AboutPolicy policy)
        {
            _context.AboutPolicies.Remove(policy);
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

        public void UpdateAbout(AboutUs updateAbout, AboutUs about)
        {
            updateAbout.Status = about.Status;
            updateAbout.AboutText = about.AboutText;
            updateAbout.AboutTitle = about.AboutTitle;
            updateAbout.Phone = about.Phone;
            updateAbout.Image = about.Image;
            _context.SaveChanges();

        }

        public void UpdateBrand(Brand updateBrand, Brand brand)
        {
            updateBrand.Status = brand.Status;
            updateBrand.Name = brand.Name;

            updateBrand.Logo = brand.Logo;

            _context.SaveChanges();

        }

        public void UpdateClaim(AboutClaim updateAboutClaim, AboutClaim model)
        {
            updateAboutClaim.Status = model.Status;
            updateAboutClaim.ClaimLogo = model.ClaimLogo;
            updateAboutClaim.ClaimSubtext = model.ClaimSubtext;
            updateAboutClaim.ClaimSubtitle = model.ClaimSubtitle;
            updateAboutClaim.AboutUsId = model.AboutUsId;
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

        public void UpdatePolicy(AboutPolicy updateAboutPolicy, AboutPolicy model)
        {
            updateAboutPolicy.PolicyCount = model.PolicyCount;
            updateAboutPolicy.PolicySubText = model.PolicySubText;
            updateAboutPolicy.PolicySubTitle = model.PolicySubTitle;
            updateAboutPolicy.Status = model.Status;
            updateAboutPolicy.ActionText = model.ActionText;
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
