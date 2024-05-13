using System;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts;
using App.Domain.Core.SkillServeAgg.DTOs;
using App.Domain.Core.SkillServeAgg.Entity;
using App.Domain.Core.SkillServeAgg.ModelViews;

namespace App.Domain.Service.SkillServeAgg
{
	public class SkillServeCategoryService : ISkillServeCategoryService
    {
        #region Fields

        private readonly ISkillServeCategoryRepository _repo;





        #endregion


        #region Constructors
        public SkillServeCategoryService(ISkillServeCategoryRepository repo)
        {
            _repo = repo;
        }



        #endregion

        #region Implmentations

        
        public async Task<List<ShowDetailsSkillCategoryDto>> GetCategoriesWithDetails(CancellationToken cancellationToken)
            => await _repo.GetCategoriesWithDetails(cancellationToken);

        public async Task<UpdateSkillServeCategoryDto> UpdateGetById(int id, CancellationToken cancellationToken)
            => await _repo.UpdateGetById(id, cancellationToken);

        public async Task Update(UpdateSkillServeCategoryDto category, CancellationToken cancellationToken)
            => await _repo.Update(category, cancellationToken);

        public async Task<List<TitleSkillServeCategoryModelView>> GetTitles(CancellationToken cancellationToken)
            => await _repo.GetTitles(cancellationToken);

        public async Task Add(AddSkillServeCategoryModelView categoryModelView, CancellationToken cancellationToken)
        {
            SkillServeCategory category = new() { Title = categoryModelView.Title, Description = categoryModelView.Description,CreatedAt = DateTime.Now };
            await _repo.Add(category, cancellationToken);         
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
            => await _repo.DeleteById(id, cancellationToken);





        #endregion


    }
}

