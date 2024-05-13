
using System;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts;
using App.Domain.Core.SkillServeAgg.DTOs;
using App.Domain.Core.SkillServeAgg.ModelViews;

namespace App.Domain.AppService.SkillServeAgg
{
	public class SkillServeAppService : ISkillServeAppService
    {
        #region Fields

        private readonly ISkillServeService _skillServeService;


        #endregion

        #region Constructors
        public SkillServeAppService(ISkillServeService skillServeService)
        {
            _skillServeService = skillServeService;
        }

       
        #endregion

        #region Implementations

        public async Task<int> Count(CancellationToken cancellationToken)
            => await _skillServeService.Count(cancellationToken);

        public async Task<List<ShowDetalisSkillServeDto>> GetSkillServesWithDetails(CancellationToken cancellationToken)
            => await _skillServeService.GetSkillServesWithDetails(cancellationToken);

        public async Task Add(AddSkillServeModelView skillServe, CancellationToken cancellationToken)
            => await _skillServeService.Add(skillServe, cancellationToken);

        public async Task<UpdateSkillServeDto> UpdateDtoGetById(int id, CancellationToken cancellationToken)
            => await _skillServeService.UpdateDtoGetById(id, cancellationToken);

        public async Task Update(UpdateSkillServeDto skill, CancellationToken cancellationToken)
            => await _skillServeService.Update(skill, cancellationToken);

        public async Task DeleteById(int id, CancellationToken cancellationToken)
            => await _skillServeService.DeleteById(id, cancellationToken);

        #endregion
    }
}

