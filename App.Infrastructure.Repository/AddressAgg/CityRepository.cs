using System;
using App.Domain.Core.AddressAgg.Contracts.CityContract;
using App.Domain.Core.AddressAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.AddressAgg
{
	public class CityRepository : ICityRepository
	{
        private readonly AppDbContext _context;

        public CityRepository(AppDbContext context)
		{
            _context = context;
        }

        public void Add(City city)
        {           
            _context.Add(city);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        { 
            _context.Remove(_context.Cities.FirstOrDefault(c => c.Id == id));
            _context.SaveChanges();
        }

        public List<City> GetAll() => _context.Cities.ToList();


        public City GetById(int id) => _context.Cities.AsNoTracking().FirstOrDefault(c => c.Id == id);
        

        
    }
}

