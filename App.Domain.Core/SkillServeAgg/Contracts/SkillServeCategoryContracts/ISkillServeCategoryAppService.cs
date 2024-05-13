using System;
using App.Domain.Core.SkillServeAgg.DTOs;
using App.Domain.Core.SkillServeAgg.ModelViews;

namespace App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts
{
	public interface ISkillServeCategoryAppService
	{
        Task<List<ShowDetailsSkillCategoryDto>> GetCategoriesWithDetails(CancellationToken cancellationToken);
        Task Add(AddSkillServeCategoryModelView categoryModelView, CancellationToken cancellationToken);
        Task<UpdateSkillServeCategoryDto> UpdateGetById(int id, CancellationToken cancellationToken);
        Task Update(UpdateSkillServeCategoryDto category, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);
        Task<List<TitleSkillServeCategoryModelView>> GetTitles(CancellationToken cancellationToken);
    }
}

