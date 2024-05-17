using System;
using App.Domain.Core.CacheAgg.Contracts;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts;
using App.Domain.Core.SkillServeAgg.DTOs;
using App.Domain.Core.SkillServeAgg.ModelViews;
using Microsoft.Extensions.Caching.Memory;


namespace App.Domain.AppService.SkillServeAgg
{
	public class SkillServeCategoryAppService : ISkillServeCategoryAppService
    {
        #region Fields

        private readonly ISkillServeCategoryService _skillServeCategoryService;
        private readonly IRedisCacheService _redisCacheService;

        #endregion


        #region Constructors
        public SkillServeCategoryAppService(ISkillServeCategoryService skillServeCategoryService, IRedisCacheService redisCacheService)
        {
            _skillServeCategoryService = skillServeCategoryService;
            _redisCacheService = redisCacheService;
        }

        #endregion


        #region Implementations
        public async Task<List<ShowDetailsSkillCategoryDto>> GetCategoriesWithDetails(CancellationToken cancellationToken)
        {
            List<ShowDetailsSkillCategoryDto> categoriesWithDetail = await _redisCacheService.Get<List<ShowDetailsSkillCategoryDto>>("categoriesWithDetail", cancellationToken);

            if (categoriesWithDetail != null)
                return categoriesWithDetail;

            categoriesWithDetail = await _skillServeCategoryService.GetCategoriesWithDetails(cancellationToken);

            await _redisCacheService.Set("categoriesWithDetail", categoriesWithDetail, 1, cancellationToken);

            return categoriesWithDetail;

        }

        //public async Task<List<ShowDetailsSkillCategoryDto>> GetCategoriesWithDetails(CancellationToken cancellationToken)
        //    => await _skillServeCategoryService.GetCategoriesWithDetails(cancellationToken);


        public async Task Add(AddSkillServeCategoryModelView categoryModelView, CancellationToken cancellationToken)
            => await _skillServeCategoryService.Add(categoryModelView, cancellationToken);

        public async Task<UpdateSkillServeCategoryDto> UpdateGetById(int id, CancellationToken cancellationToken)
            => await _skillServeCategoryService.UpdateGetById(id, cancellationToken);

        public async Task Update(UpdateSkillServeCategoryDto category, CancellationToken cancellationToken)
            => await _skillServeCategoryService.Update(category, cancellationToken);

        public async Task DeleteById(int id, CancellationToken cancellationToken)
            => await _skillServeCategoryService.DeleteById(id, cancellationToken);

        public async Task<List<TitleSkillServeCategoryModelView>> GetTitles(CancellationToken cancellationToken)
            => await _skillServeCategoryService.GetTitles(cancellationToken);

        #endregion

    }
}

