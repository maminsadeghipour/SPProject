
using System;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts;

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

        #endregion
    }
}

