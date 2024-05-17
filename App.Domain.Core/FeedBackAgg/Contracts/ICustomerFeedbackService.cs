using System;
using App.Domain.Core.FeedBackAgg.DTOs;

namespace App.Domain.Core.FeedBackAgg.Contracts
{
	public interface ICustomerFeedbackService
	{
        Task<List<ShowDetailsCustomerFeedbackDto>> GetAllFeedbackWithDetails(CancellationToken cancellationToken);
        Task UpdateIsAcceptedByAdmin(int id, bool isAccepted, CancellationToken cancellationToken);
    }
}

