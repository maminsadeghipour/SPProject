using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.AdminAgg.Contracts.AdminContracts;
using App.Domain.Core.AdminAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.AdminAgg
{
	public class AdminRepository : IAdminRepository
	{
		

        private readonly AppDbContext _context;

        public AdminRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var address = _context.Admins.FirstOrDefault(a => a.Id == id);
            address.IsDeleted = true;
            _context.SaveChanges();
        }

        public List<Admin> GetAll() => _context.Admins.AsNoTracking().ToList();


        public Admin GetById(int id) => _context.Admins.AsNoTracking().FirstOrDefault(a => a.Id == id);


        public void Update(Admin admin)
        {
            var adminInDatabase = _context.Addresses.First(a => a.Id == admin.Id);

            if (admin.Username != null)
                adminInDatabase.Title = admin.Username;
            if (admin.Password != null)
                adminInDatabase.Street = admin.Password;

            adminInDatabase.LastUpdatedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}

