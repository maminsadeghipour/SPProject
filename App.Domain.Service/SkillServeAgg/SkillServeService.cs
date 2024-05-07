using System;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts;

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

        #endregion

    }
}

