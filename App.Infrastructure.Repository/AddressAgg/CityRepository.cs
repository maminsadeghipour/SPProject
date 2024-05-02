using System;
using App.Domain.Core.AddressAgg.Contracts.CityContract;
using App.Domain.Core.AddressAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.AddressAgg
{
	public class CityRepository : ICityRepository
	{

        #region Fields
        private readonly AppDbContext _context;

        #endregion

        #region Constructors
        public CityRepository(AppDbContext context)
		{
            _context = context;
        }

        #endregion

        #region Implementation
        public async Task<List<City>> GetAll(CancellationToken cancellationToken) => await _context.Cities.AsNoTracking().ToListAsync(cancellationToken);

        public async Task Add(City city, CancellationToken cancellationToken)
        {           
            await _context.AddAsync(city,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
        {
            var city = GetCityById(id,cancellationToken);
            _context.Remove(city);
            await _context.SaveChangesAsync();
        }

        public async Task<City> GetById(int id, CancellationToken cancellationToken)
        {
            var city = await _context.Cities.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
            if (city != null)
                return city;
            throw new Exception($"City with Id {id} did not found");
        }

        #endregion

        #region Privates
        private async Task<City> GetCityById(int id, CancellationToken cancellationToken)
        {
            var city = await _context.Cities.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
            if (city != null)
                return city;
            throw new Exception($"City with Id {id} did not found");
        }

        #endregion

    }
}

