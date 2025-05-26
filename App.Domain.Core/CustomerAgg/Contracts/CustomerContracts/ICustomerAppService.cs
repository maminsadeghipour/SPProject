using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.CustomerAgg.DTOs;

namespace App.Domain.Core.CustomerAgg.Contracts.CustomerContracts
{
	public interface ICustomerAppService
	{
        Task<int> Count(CancellationToken cancellationToken);

        Task<ProfileCustomerDto> GetProfileById(int applicationUserId, CancellationToken cancellationToken);
        Task<List<Address>> GetCustomerAddressByApplicationUserId(int applicationUserId, CancellationToken cancellationToken);
    }
}

