using System;
using App.Domain.Core.AddressAgg.Contracts.CityContract;
using App.Domain.Core.AddressAgg.Entity;

namespace App.Domain.Service.AddressAgg
{
	public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<List<City>> GetAll(CancellationToken cancellationToken)
            => await _cityRepository.GetAll(cancellationToken);
    }
}

