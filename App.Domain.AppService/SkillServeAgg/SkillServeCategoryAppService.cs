using System;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts;
using App.Domain.Core.SkillServeAgg.DTOs;
using App.Domain.Core.SkillServeAgg.ModelViews;

namespace App.Domain.AppService.SkillServeAgg
{
	public class SkillServeCategoryAppService : ISkillServeCategoryAppService
    {
        #region Fields

        private readonly ISkillServeCategoryService _skillServeCategoryService;

        #endregion


        #region Constructors
        public SkillServeCategoryAppService(ISkillServeCategoryService skillServeCategoryService)
        {
            _skillServeCategoryService = skillServeCategoryService;
        }

        #endregion


        #region Implementations
        public async Task<List<ShowDetailsSkillCategoryDto>> GetCategoriesWithDetails(CancellationToken cancellationToken)
            => await _skillServeCategoryService.GetCategoriesWithDetails(cancellationToken);


        public async Task Add(AddSkillServeCategoryModelView categoryModelView, CancellationToken cancellationToken)
            => await _skillServeCategoryService.Add(categoryModelView, cancellationToken);

        public async Task<UpdateSkillServeCategoryDto> UpdateGetById(int id, CancellationToken cancellationToken)
            => await _skillServeCategoryService.UpdateGetById(id, cancellationToken);

        public async Task Update(UpdateSkillServeCategoryDto category, CancellationToken cancellationToken)
            => await _skillServeCategoryService.Update(category, cancellationToken);

        public async Task DeleteById(int id, CancellationToken cancellationToken)
            => await _skillServeCategoryService.DeleteById(id, cancellationToken);

        #endregion

    }
}

