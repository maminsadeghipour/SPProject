using System;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;
using App.Domain.Core.RequestAgg.DTOs;

namespace App.Domain.AppService.RequestAgg
{
	public class RequestAppService : IRequestAppService
	{
        #region Fields
        private readonly IRequestService _requestService;

        #endregion

        #region Constructors
        public RequestAppService(IRequestService requestService)
        {
            _requestService = requestService;
        }

        
        #endregion

        #region Implementations
        public async Task<int> Count(CancellationToken cancellationToken)
            => await _requestService.Count(cancellationToken);

        public async Task<List<ShowDetailsRequestDto>> GetAllRequestsWithDetails(CancellationToken cancellationToken)
            => await _requestService.GetAllRequestsWithDetails(cancellationToken);

        public async Task<UpdateRequestDto> GetUpdateDtoById(int id, CancellationToken cancellationToken)
            => await _requestService.GetUpdateDtoById(id, cancellationToken);

        public async Task Update(UpdateRequestDto request, CancellationToken cancellationToken)
            => await _requestService.Update(request, cancellationToken);

        public async Task AddRequest(int userApplicationId, AddRequestDto request, CancellationToken cancellationToken)
            => await _requestService.AddRequest(userApplicationId, request, cancellationToken);

        public async Task<List<ShowDetailsRequestDto>> GetRequestByUserId(int applicationUserId, CancellationToken cancellationToken)
            => await _requestService.GetRequestByUserId(applicationUserId, cancellationToken);

        public async Task<ShowDetailBidsRequestDto> GetReequestWithBids(int requestId, int applicationUserId, CancellationToken cancellationToken)
            => await _requestService.GetReequestWithBids(requestId, applicationUserId, cancellationToken);

        public async Task AcceptBid(int requestId, int bidId, CancellationToken cancellationToken)
            => await _requestService.AcceptBid(requestId, bidId, cancellationToken);

        #endregion
    }
}

