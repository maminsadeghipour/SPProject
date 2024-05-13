using System;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;

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

        #endregion

        
    }
}

