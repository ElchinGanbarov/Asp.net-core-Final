using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminRepository
{
    public interface IAdminRepository
    {
        Admin Register(Admin user);
        Admin Login(string email, string password);
        Admin CheckByToken(string token);
        void UpdateToken(int id, string token);
        bool CheckEmail(string email);
    }
    public class AdminRepository : IAdminRepository
    {
        private readonly JotexDbContext _context;
        public AdminRepository(JotexDbContext context)
        {
            _context = context;
        }
        public Admin CheckByToken(string token)
        {
            return _context.Admins.FirstOrDefault(b => b.Token == token);
        }

        public bool CheckEmail(string email)
        {
            return _context.Admins.Any(a => a.Email == email);
        }

        public Admin Login(string email, string password)
        {
            Admin admin = _context.Admins.FirstOrDefault(b => b.Email == email);

            if (admin != null && CryptoHelper.Crypto.VerifyHashedPassword(admin.Password, password))
            {
                return admin;
            }
            return null;
        }

        public Admin Register(Admin admin)
        {
            admin.Password = CryptoHelper.Crypto.HashPassword(admin.Password);
            admin.AddedBy = "System";
            admin.AddedDate = DateTime.Now;
            admin.ModifiedDate = DateTime.Now;
            admin.ModifiedBy = "System";

            _context.Admins.Add(admin);
            _context.SaveChanges();
            return admin;
        }

        public void UpdateToken(int id, string token)
        {
            Admin admin = _context.Admins.Find(id);
            admin.Token = token;
            _context.SaveChanges();
        }
    }
}
