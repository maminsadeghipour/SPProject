using System;
namespace App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts
{
	public interface ISkillServeAppService
	{
        Task<int> Count(CancellationToken cancellationToken);
    }
}

