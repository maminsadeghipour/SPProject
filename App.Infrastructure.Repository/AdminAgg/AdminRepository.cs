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
        #region Fields
        private readonly AppDbContext _context;

        #endregion

        #region Constructors
        public AdminRepository(AppDbContext context)
        {
            _context = context;
        }


        #endregion

        #region Implemantation
        public async Task<List<Admin>> GetAll(CancellationToken cancellationToken) => await _context.Admins.AsNoTracking().ToListAsync(cancellationToken);


        public async Task Add(Admin admin, CancellationToken cancellationToken)
        {
            await _context.Admins.AddAsync(admin,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
        {
            var admin = await GetAdminById(id, cancellationToken);
            admin.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<Admin> GetById(int id, CancellationToken cancellationToken)
        {
            var admin = await _context.Admins.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id && !a.IsDeleted, cancellationToken);
            if (admin != null)
                return admin;
            throw new Exception($"Admin with id {id} did not found");
        }

        public async Task Update(Admin admin, CancellationToken cancellationToken)
        {
            var adminInDatabase = await GetAdminById(admin.Id, cancellationToken);
                 

            if (admin.Username != null)
                adminInDatabase.Username = admin.Username;
            if (admin.Password != null)
                adminInDatabase.Password = admin.Password;

            adminInDatabase.LastUpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();
        }

        #endregion

        #region Privates
        private async Task<Admin> GetAdminById(int id, CancellationToken cancellationToken)
        {
            var admin = await _context.Admins.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
            if (admin != null)
                return admin;
            throw new Exception($"Admin with id {id} did not found");

        }

        #endregion
    }
}

