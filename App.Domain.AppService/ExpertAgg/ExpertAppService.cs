using System;
using App.Domain.Core.ExpertAgg.Contracts.ExpertContract;

namespace App.Domain.AppService.ExpertAgg
{
	public class ExpertAppService : IExpertAppService
    {

        #region Fields
        private readonly IExpertService _expertService;



        #endregion

        #region Constructors

        public ExpertAppService(IExpertService expertService)
        {
            _expertService = expertService;
        }

        #endregion



        public async Task<int> Count(CancellationToken cancellationToken) => await _expertService.Count(cancellationToken);
        
    }
}

