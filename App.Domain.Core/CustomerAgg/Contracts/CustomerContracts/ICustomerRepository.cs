using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.CustomerAgg.Entity;

namespace App.Domain.Core.CustomerAgg.Contracts.CustomerContracts
{
	public interface ICustomerRepository
	{
        void Add(Customer customer);
        List<Customer> GetAll();
        Customer GetById(int id);
        void Update(Customer customer);
        void DeleteById(int id);
    }
}

