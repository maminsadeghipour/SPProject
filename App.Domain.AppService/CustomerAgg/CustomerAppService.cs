using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;
using App.Domain.Core.CustomerAgg.DTOs;

namespace App.Domain.AppService.CustomerAgg
{
	public class CustomerAppService : ICustomerAppService
    {
        #region Fields
        private readonly ICustomerService _customerService;

        #endregion

        #region Constructors

        public CustomerAppService(ICustomerService repo)
        {
            _customerService = repo;
        }


        #endregion

        #region Implementations

        public async Task<int> Count(CancellationToken cancellationToken)
            => await _customerService.Count(cancellationToken);

        public async Task<ProfileCustomerDto> GetProfileById(int applicationUserId, CancellationToken cancellationToken)
            => await _customerService.GetProfileById(applicationUserId, cancellationToken);

        public async Task<List<Address>> GetCustomerAddressByApplicationUserId(int applicationUserId, CancellationToken cancellationToken)
            => await _customerService.GetCustomerAddressByApplicationUserId(applicationUserId, cancellationToken);

        #endregion

    }
}

