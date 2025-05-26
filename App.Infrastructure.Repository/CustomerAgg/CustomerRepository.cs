using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;
using App.Domain.Core.CustomerAgg.DTOs;
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
        public async Task<List<Customer>> GetAll(CancellationToken cancellationToken)
            => await _context.Customers.AsNoTracking().ToListAsync(cancellationToken);

        public async Task<int> Count(CancellationToken cancellationToken)
            => await _context.Customers.Where(c => !c.IsDeleted).CountAsync(cancellationToken);

        public async Task<int> GetIdByApplicationUserId(int applicationUserId, CancellationToken cancellationToken)
            => await _context.Customers.Where(c => c.ApplicationUserId == applicationUserId)
                                    .Select(c => c.Id).FirstOrDefaultAsync(cancellationToken);

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


        public async Task<ProfileCustomerDto> GetProfileById(int applicationUserId, CancellationToken cancellationToken)
            => await _context.Customers.Where(c => c.ApplicationUserId == applicationUserId)
            .Select(c =>
            new ProfileCustomerDto()
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                RegisteredAt = c.RegisteredAt,
                Addresses = c.Addresses,
                NumberOfRequests = c.Requests.Count(),
                PhoneNumber = c.ApplicationUser.PhoneNumber,
                Username = c.ApplicationUser.UserName
            }
            )
            .FirstAsync(cancellationToken);

        #endregion

        #region Privates
        private async Task<Customer> GetCustomerById(int id, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
            if (customer != null)
                return customer;
            throw new Exception($"Customer with id {id} did not found");

        }

        public async Task<List<Address>> GetCustomerAddressByApplicationUserId(int applicationUserId, CancellationToken cancellationToken)
            => await _context.Customers.Where(c => c.ApplicationUserId == applicationUserId)
                                .Select(c => c.Addresses).FirstAsync(cancellationToken);






        #endregion
    }
}

