using System;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.SkillServeAgg.DTOs;
using App.Domain.Core.SkillServeAgg.Entity;
using App.Domain.Core.SkillServeAgg.ModelViews;

namespace App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts
{
	public interface ISkillServeCategoryRepository
	{
        Task Add(SkillServeCategory category,CancellationToken cancellationToken);
        Task<List<SkillServeCategory>> GetAll(CancellationToken cancellationToken);
        Task<SkillServeCategory> GetById(int id, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);

        Task<List<ShowDetailsSkillCategoryDto>> GetCategoriesWithDetails(CancellationToken cancellationToken);
        Task<UpdateSkillServeCategoryDto> UpdateGetById(int id, CancellationToken cancellationToken);
        Task Update(UpdateSkillServeCategoryDto category, CancellationToken cancellationToken);

        Task<List<TitleSkillServeCategoryModelView>> GetTitles(CancellationToken cancellationToken);

        //Task Update(SkillServeCategory category, CancellationToken cancellationToken);
    }
}

