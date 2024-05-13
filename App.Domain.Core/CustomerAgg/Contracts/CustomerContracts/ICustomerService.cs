using System;
namespace App.Domain.Core.CustomerAgg.Contracts.CustomerContracts
{
	public interface ICustomerService
	{
        Task<int> Count(CancellationToken cancellationToken);
    }
}

