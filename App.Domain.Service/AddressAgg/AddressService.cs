using System;
using App.Domain.Core.AddressAgg.Contracts.AddressContract;
using App.Domain.Core.AddressAgg.DTOs;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;

namespace App.Domain.Service.AddressAgg
{
	public class AddressService : IAddressService
    {
        private readonly ICustomerService _customerService;
        private readonly IAddressRepository _repo;

        public AddressService(ICustomerService customerService, IAddressRepository repo)
        {
            _customerService = customerService;
            _repo = repo;
        }

        public async Task Add(int applicationUserId, AddAddressDto address, CancellationToken cancellationToken)
        {
            var customerId = await _customerService.GetIdByApplicationUserId(applicationUserId, cancellationToken);

            var addressToAdd = new Address()
            {
                Title = address.Title,
                CityId = address.CityId,
                Street = address.Street,
                CustomerId = customerId,
                CreatedAt = DateTime.Now,
            };
            await _repo.Add(addressToAdd, cancellationToken);

        }
    }
}

