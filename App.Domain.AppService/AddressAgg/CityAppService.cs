using App.Domain.Core.AddressAgg.Contracts.CityContract;
using App.Domain.Core.AddressAgg.Entity;

namespace App.Domain.AppService.AddressAgg
{
	public class CityAppService : ICityAppService
    {
        private readonly ICityService _cityService;

        public CityAppService(ICityService cityService)
        {            
            _cityService = cityService;
        }

        public async Task<List<City>> GetAll(CancellationToken cancellationToken)
            => await _cityService.GetAll(cancellationToken);
    }
}

