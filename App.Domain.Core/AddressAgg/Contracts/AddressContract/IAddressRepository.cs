using System;
using App.Domain.Core.AddressAgg.Entity;

namespace App.Domain.Core.AddressAgg.Contracts.AddressContract
{
	public interface IAddressRepository
	{
		void Add(Address address);
		List<Address> GetAll();
		Address GetById(int id);
		void Update(Address address);
		void DeleteById(int id);

	}
}

