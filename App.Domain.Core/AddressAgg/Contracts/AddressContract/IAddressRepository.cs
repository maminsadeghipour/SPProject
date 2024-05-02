using System;
using App.Domain.Core.AddressAgg.Entity;

namespace App.Domain.Core.AddressAgg.Contracts.AddressContract
{
	public interface IAddressRepository
	{
		Task Add(Address address, CancellationToken cancellationToken);
		Task<List<Address>> GetAll(CancellationToken cancellationToken);
		Task<Address> GetById(int id, CancellationToken cancellationToken);
		Task Update(Address address, CancellationToken cancellationToken);
		Task DeleteById(int id, CancellationToken cancellationToken);

	}
}

