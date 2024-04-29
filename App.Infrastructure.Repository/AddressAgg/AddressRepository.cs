using System;
using App.Domain.Core.AddressAgg.Contracts.AddressContract;
using App.Domain.Core.AddressAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.AddressAgg
{
	public class AddressRepository : IAddressRepository
	{
        private readonly AppDbContext _context;

        public AddressRepository(AppDbContext appDbContext )
		{
            _context = appDbContext;
        }

        public void Add(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var address = _context.Addresses.FirstOrDefault(a => a.Id == id);
            address.IsDeleted = true;
            _context.SaveChanges();
        }

        public List<Address> GetAll() => _context.Addresses.ToList();


        public Address GetById(int id) => _context.Addresses.AsNoTracking().FirstOrDefault(a => a.Id == id);
        

        public void Update(Address address)
        {
            var addressInDatabase = _context.Addresses.First(a => a.Id == address.Id);

            if (address.Title != null)
                addressInDatabase.Title = address.Title;
            if (address.Street != null)
                addressInDatabase.Street = address.Street;

            addressInDatabase.LastUpdatedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}

