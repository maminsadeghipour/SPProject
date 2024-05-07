using System;
namespace App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts
{
	public interface ISkillServeService
	{
        Task<int> Count(CancellationToken cancellationToken);
    }
}

