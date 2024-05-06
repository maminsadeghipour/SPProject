using System;
namespace App.Domain.Core.ExpertAgg.Contracts.ExpertContract
{
	public interface IExpertService
	{
        Task<int> Count(CancellationToken cancellationToken);
    }
}

