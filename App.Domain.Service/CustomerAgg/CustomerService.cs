using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;
using App.Domain.Core.CustomerAgg.DTOs;

namespace App.Domain.Service.CustomerAgg
{
	public class CustomerService : ICustomerService
    {
        #region Fields
        private readonly ICustomerRepository _repo;

        #endregion

        #region Constructors

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }


        #endregion

        #region Implementations

        public async Task<int> Count(CancellationToken cancellationToken)
            => await _repo.Count(cancellationToken);

        public async Task<List<Address>> GetCustomerAddressByApplicationUserId(int applicationUserId, CancellationToken cancellationToken)
            => await _repo.GetCustomerAddressByApplicationUserId(applicationUserId, cancellationToken);

        public async Task<int> GetIdByApplicationUserId(int applicationUserId, CancellationToken cancellationToken)
            => await _repo.GetIdByApplicationUserId(applicationUserId, cancellationToken);

        public async Task<ProfileCustomerDto> GetProfileById(int applicationUserId, CancellationToken cancellationToken)
            => await _repo.GetProfileById(applicationUserId, cancellationToken);
        #endregion


    }
}

