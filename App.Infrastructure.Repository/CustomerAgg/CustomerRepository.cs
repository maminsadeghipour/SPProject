using System;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;
using App.Domain.Core.CustomerAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.CustomerAgg
{
	public class CustomerRepository : ICustomerRepository
    {

        #region Fields
        private readonly AppDbContext _context;

        #endregion

        #region Constructors
        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        #endregion

        #region Implementations
        public async Task<List<Customer>> GetAll(CancellationToken cancellationToken) => await _context.Customers.AsNoTracking().ToListAsync(cancellationToken);

        public async Task Add(Customer customer, CancellationToken cancellationToken)
        {
            await _context.Customers.AddAsync(customer,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);            
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
        {
            var customer = await GetCustomerById(id, cancellationToken);
            customer.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<Customer> GetById(int id, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
            if (customer != null)
                return customer;
            throw new Exception($"Customer with id {id} did not found");
        }

        public async Task Update(Customer customer, CancellationToken cancellationToken)
        {
            var customerInDatabase = await GetCustomerById(customer.Id, cancellationToken);
            if (customer.FirstName != null)
                customerInDatabase.FirstName = customer.FirstName;
            if (customer.LastName != null)
                customerInDatabase.LastName = customer.LastName;

            await _context.SaveChangesAsync(cancellationToken);

        }


        #endregion

        #region Privates
        private async Task<Customer> GetCustomerById(int id, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
            if (customer != null)
                return customer;
            throw new Exception($"Customer with id {id} did not found");

        }

        #endregion
    }
}

