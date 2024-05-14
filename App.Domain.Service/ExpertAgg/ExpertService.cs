using System;
using App.Domain.Core.ExpertAgg.Contracts.ExpertContract;

namespace App.Domain.Service.ExpertAgg
{
	public class ExpertService : IExpertService
    {
        #region Fields
        private readonly IExpertRepository _repo;


        #endregion

        #region Constructors

        public ExpertService(IExpertRepository repo)
        {
            _repo = repo;
        }

        #endregion

        #region Implementations

        public async Task<int> Count(CancellationToken cancellationToken) => await _repo.Count(cancellationToken);

        #endregion

        
    }
}

