using System;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;

namespace App.Domain.Service.RequestAgg
{
	public class RequestService : IRequestService
    {

        #region Fields
        private readonly IRequestRepository _repo;

        #endregion

        #region Constructors
        public RequestService(IRequestRepository requestRepository)
        {
            _repo = requestRepository;
        }

        #endregion

        #region Implementations
        public async Task<int> Count(CancellationToken cancellationToken)
            => await _repo.Count(cancellationToken);

        #endregion


    }
}

