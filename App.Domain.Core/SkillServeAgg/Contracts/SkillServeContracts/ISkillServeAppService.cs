using System;
using App.Domain.Core.SkillServeAgg.DTOs;
using App.Domain.Core.SkillServeAgg.ModelViews;

namespace App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts
{
	public interface ISkillServeAppService
	{
        Task<int> Count(CancellationToken cancellationToken);
        Task<List<ShowDetalisSkillServeDto>> GetSkillServesWithDetails(CancellationToken cancellationToken);
        Task Add(AddSkillServeModelView skillServe, CancellationToken cancellationToken);
        Task<UpdateSkillServeDto> UpdateDtoGetById(int id, CancellationToken cancellationToken);
        Task Update(UpdateSkillServeDto skill, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);

    }
}

