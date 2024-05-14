using System;
using App.Domain.Core.RequestAgg.DTOs;

namespace App.Domain.Core.RequestAgg.Contracts.RequestContracts
{
	public interface IRequestService
	{
        Task<int> Count(CancellationToken cancellationToken);
        Task<List<ShowDetailsRequestDto>> GetAllRequestsWithDetails(CancellationToken cancellationToken);
        Task<UpdateRequestDto> GetUpdateDtoById(int id, CancellationToken cancellationToken);
        Task Update(UpdateRequestDto request, CancellationToken cancellationToken);

    }
}

