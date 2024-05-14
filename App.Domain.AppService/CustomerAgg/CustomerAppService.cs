using System;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;

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

        #endregion

    }
}

