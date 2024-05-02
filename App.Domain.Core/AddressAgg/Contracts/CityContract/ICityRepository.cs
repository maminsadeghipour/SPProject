using System;
using App.Domain.Core.AddressAgg.Entity;

namespace App.Domain.Core.AddressAgg.Contracts.CityContract
{
	public interface ICityRepository
	{
        Task Add(City city, CancellationToken cancellationToken);
        Task<List<City>> GetAll(CancellationToken cancellationToken);
        Task<City> GetById(int id, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);
    }
}

