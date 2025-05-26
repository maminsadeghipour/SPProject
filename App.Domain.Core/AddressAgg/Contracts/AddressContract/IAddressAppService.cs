using System;
using App.Domain.Core.AddressAgg.DTOs;
using App.Domain.Core.AddressAgg.Entity;

namespace App.Domain.Core.AddressAgg.Contracts.AddressContract
{
	public interface IAddressAppService
	{
        Task Add(int applicationUserId, AddAddressDto address, CancellationToken cancellationToken);
    }
}

