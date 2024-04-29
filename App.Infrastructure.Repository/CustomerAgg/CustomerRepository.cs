using System;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;
using App.Domain.Core.CustomerAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.CustomerAgg
{
	public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();            
        }

        public void DeleteById(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            customer.IsDeleted = true;
            _context.SaveChanges();
        }

        public List<Customer> GetAll() => _context.Customers.ToList();


        public Customer GetById(int id) => _context.Customers.AsNoTracking().FirstOrDefault(c => c.Id == id);
        

        public void Update(Customer customer)
        {
            var customerInDatabase = _context.Customers.FirstOrDefault(c => c.Id == customer.Id);
            if (customer.FirstName != null)
                customerInDatabase.FirstName = customer.FirstName;
            if (customer.LastName != null)
                customerInDatabase.LastName = customer.LastName;

            _context.SaveChanges();

        }
    }
}

