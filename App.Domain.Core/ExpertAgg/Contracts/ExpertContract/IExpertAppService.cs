using System;
namespace App.Domain.Core.ExpertAgg.Contracts.ExpertContract
{
	public interface IExpertAppService
	{
		Task<int> Count(CancellationToken cancellationToken);
	}
}

