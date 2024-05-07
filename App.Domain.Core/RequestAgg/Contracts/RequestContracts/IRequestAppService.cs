using System;
namespace App.Domain.Core.RequestAgg.Contracts.RequestContracts
{
	public interface IRequestAppService
	{
        Task<int> Count(CancellationToken cancellationToken);
    }
}

