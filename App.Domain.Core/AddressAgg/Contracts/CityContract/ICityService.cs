using System;
using App.Domain.Core.AddressAgg.Entity;

namespace App.Domain.Core.AddressAgg.Contracts.CityContract
{
	public interface ICityService
	{
        Task<List<City>> GetAll(CancellationToken cancellationToken);
    }
}

