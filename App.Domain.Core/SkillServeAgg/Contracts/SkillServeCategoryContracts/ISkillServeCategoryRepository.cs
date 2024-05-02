using System;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.SkillServeAgg.Entity;

namespace App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts
{
	public interface ISkillServeCategoryRepository
	{
        Task Add(SkillServeCategory category,CancellationToken cancellationToken);
        Task<List<SkillServeCategory>> GetAll(CancellationToken cancellationToken);
        Task<SkillServeCategory> GetById(int id, CancellationToken cancellationToken);
        Task Update(SkillServeCategory category, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);
    }
}

