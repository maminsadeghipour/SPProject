using System;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts;
using App.Domain.Core.SkillServeAgg.DTOs;
using App.Domain.Core.SkillServeAgg.Entity;
using App.Domain.Core.SkillServeAgg.ModelViews;

namespace App.Domain.Service.SkillServeAgg
{
	public class SkillServeService : ISkillServeService
    {
		#region Fields

		private readonly ISkillServeRepository _repo;


        #endregion

        #region Constructors
        public SkillServeService(ISkillServeRepository repo)
        {
            _repo = repo;
        }

       
        #endregion

        #region Implementations

        public async Task<int> Count(CancellationToken cancellationToken)
            => await _repo.Count(cancellationToken);

        public async Task<List<ShowDetalisSkillServeDto>> GetSkillServesWithDetails(CancellationToken cancellationToken)
            => await _repo.GetSkillServesWithDetails(cancellationToken);

        public async Task Add(AddSkillServeModelView skillServe, CancellationToken cancellationToken)
        {
            SkillServe skillToAdd = new()
            {
                Title = skillServe.Title,
                Description = skillServe.Description,
                MinWage = skillServe.MinWage,
                CategoryId = skillServe.CategoryId,
                CreatedAt = DateTime.Now
            };

            await _repo.Add(skillToAdd,cancellationToken);
        }

        public async Task<UpdateSkillServeDto> UpdateDtoGetById(int id, CancellationToken cancellationToken)
        {
            var skill = await _repo.GetById(id, cancellationToken);
            UpdateSkillServeDto updateDto = new()
            {
                Id = skill.Id,
                Category = skill.Category,
                CategoryId = skill.CategoryId,
                Description = skill.Description,
                MinWage = skill.MinWage,
                Title = skill.Title
            };
            return updateDto;
        }

        public async Task Update(UpdateSkillServeDto skill, CancellationToken cancellationToken)
            => await _repo.Update(skill, cancellationToken);

        public async Task DeleteById(int id, CancellationToken cancellationToken)
            => await _repo.DeleteById(id, cancellationToken);
        

        #endregion

    }
}

