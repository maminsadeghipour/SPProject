using System;
using App.Domain.Core.SkillServeAgg.Entity;

namespace App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts
{
	public interface ISkillServeRepository
	{
        Task Add(SkillServe skillServe, CancellationToken cancellationToken);
        Task<List<SkillServe>> GetAll(CancellationToken cancellationToken);
        Task<SkillServe> GetById(int id, CancellationToken cancellationToken);
        Task Update(SkillServe skillServe, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);

        Task<int> Count(CancellationToken cancellationToken);
    }
}

