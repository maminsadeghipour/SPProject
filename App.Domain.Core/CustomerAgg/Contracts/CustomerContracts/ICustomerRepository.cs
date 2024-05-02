using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.CustomerAgg.Entity;

namespace App.Domain.Core.CustomerAgg.Contracts.CustomerContracts
{
	public interface ICustomerRepository
	{
        Task Add(Customer customer, CancellationToken cancellationToken);
        Task<List<Customer>> GetAll(CancellationToken cancellationToken);
        Task<Customer> GetById(int id, CancellationToken cancellationToken);
        Task Update(Customer customer, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);
    }
}

