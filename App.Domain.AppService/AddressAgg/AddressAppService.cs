using System;
using App.Domain.Core.AddressAgg.Contracts.AddressContract;
using App.Domain.Core.AddressAgg.DTOs;

namespace App.Domain.AppService.AddressAgg
{
	public class AddressAppService : IAddressAppService
    {
        private readonly IAddressService _addressService;

        public AddressAppService(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public async Task Add(int applicationUserId, AddAddressDto address, CancellationToken cancellationToken)
            => await _addressService.Add(applicationUserId, address, cancellationToken);
    }
}

