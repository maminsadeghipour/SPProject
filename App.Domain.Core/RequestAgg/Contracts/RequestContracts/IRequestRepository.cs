using System;
using App.Domain.Core.RequestAgg.DTOs;
using App.Domain.Core.RequestAgg.Entity;

namespace App.Domain.Core.RequestAgg.Contracts.RequestContracts
{
	public interface IRequestRepository
	{
        Task Add(Request request, CancellationToken cancellationToken);
        Task<List<Request>> GetAll(CancellationToken cancellationToken);
        Task<Request> GetById(int id, CancellationToken cancellationToken);
        Task Update(UpdateRequestDto request, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);

        Task<int> Count(CancellationToken cancellationToken);

        Task<List<ShowDetailsRequestDto>> GetAllRequestsWithDetails(CancellationToken cancellationToken);

        Task<UpdateRequestDto> GetUpdateDtoById(int id, CancellationToken cancellationToken);

        Task<List<ShowDetailsRequestDto>> GetRequestByCustomerId(int customerId, CancellationToken cancellationToken);

        Task<ShowDetailBidsRequestDto> GetReequestWithBids(int requestId, int customerId, CancellationToken cancellationToken);

        Task Update(Request request, CancellationToken cancellationToken);

        Task<int?> GetRequestAcceptedBidId(int id, CancellationToken cancellationToken);
    }
}

