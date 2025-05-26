using System;
using App.Domain.Core.RequestAgg.DTOs;
using App.Domain.Core.RequestAgg.Enum;

namespace App.Domain.Core.RequestAgg.Contracts.RequestContracts
{
	public interface IRequestService
	{
        Task<int> Count(CancellationToken cancellationToken);
        Task<List<ShowDetailsRequestDto>> GetAllRequestsWithDetails(CancellationToken cancellationToken);
        Task<UpdateRequestDto> GetUpdateDtoById(int id, CancellationToken cancellationToken);
        Task Update(UpdateRequestDto request, CancellationToken cancellationToken);
        Task AddRequest(int userApplicationId, AddRequestDto request, CancellationToken cancellationToken);

        Task<List<ShowDetailsRequestDto>> GetRequestByUserId(int applicationUserId, CancellationToken cancellationToken);

        Task<ShowDetailBidsRequestDto> GetReequestWithBids(int requestId, int applicationUserId, CancellationToken cancellationToken);

        Task AcceptBid(int requestId, int bidId, CancellationToken cancellationToken);

        Task<int> GetExpertIdByAcceptedBid(int requestId, CancellationToken cancellationToken);

        Task UpdateRequsestState(int requestId, RequestSate requestSate, CancellationToken cancellationToken);
    }
}

