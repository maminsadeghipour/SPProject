using System;
using App.Domain.Core.AddressAgg.Contracts.AddressContract;
using App.Domain.Core.AddressAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.AddressAgg
{
	public class AddressRepository : IAddressRepository
	{

        #region Fields
        private readonly AppDbContext _context;

        #endregion

        #region Constructors        
        public AddressRepository(AppDbContext appDbContext)
		{
            _context = appDbContext;
        }

        #endregion


        #region Implementations
        public async Task<List<Address>> GetAll(CancellationToken cancellationToken) => await _context.Addresses.AsNoTracking().ToListAsync(cancellationToken);

        public async Task Add(Address address, CancellationToken cancellationToken)
        {
            await _context.Addresses.AddAsync(address, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
        {
            var address = await GetAddreesById(id,cancellationToken);
            address.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<Address> GetById(int id, CancellationToken cancellationToken)
        {            
            var address = await _context.Addresses.FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
            if (address != null)
                return address;
            throw new Exception($"Address with id {id} did not found");
        }

        public async Task Update(Address address, CancellationToken cancellationToken)
        {
            var addressInDatabase = await GetAddreesById(address.Id,cancellationToken);

            if (address.Title != null)
                addressInDatabase.Title = address.Title;
            if (address.Street != null)
                addressInDatabase.Street = address.Street;

            addressInDatabase.LastUpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);
        }

        #endregion

           
        #region Privates
        private async Task<Address> GetAddreesById(int id, CancellationToken cancellationToken)
        {
            var address = await _context.Addresses.FirstOrDefaultAsync(a => a.Id == id,cancellationToken);
            if (address != null)
                return address;
            throw new Exception($"Address with id {id} did not found");
        }

        #endregion
    }
}

