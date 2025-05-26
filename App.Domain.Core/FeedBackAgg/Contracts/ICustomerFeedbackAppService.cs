using System;
using App.Domain.Core.FeedBackAgg.DTOs;
using App.Domain.Core.FeedBackAgg.ModelViews;

namespace App.Domain.Core.FeedBackAgg.Contracts
{
	public interface ICustomerFeedbackAppService
	{
        Task<List<ShowDetailsCustomerFeedbackDto>> GetAllFeedbackWithDetails(CancellationToken cancellationToken);
        Task UpdateIsAcceptedByAdmin(int id, bool isAccepted, CancellationToken cancellationToken);
        Task Add(int applicationUserId, AddCustomerFeedbackModelView feedback, CancellationToken cancellationToken);
    }
}

