using System;
namespace App.Domain.Core.CustomerAgg.Contracts.CustomerContracts
{
	public interface ICustomerAppService
	{
        Task<int> Count(CancellationToken cancellationToken);
    }
}

