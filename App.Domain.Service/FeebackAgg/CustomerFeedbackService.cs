using System;
using App.Domain.Core.FeedBackAgg.Contracts;
using App.Domain.Core.FeedBackAgg.DTOs;

namespace App.Domain.Service.FeebackAgg
{
	public class CustomerFeedbackService : ICustomerFeedbackService
    {
        #region Fields
        private readonly ICustomerFeedbackRepository _repo;
        #endregion

        #region Constructors
        public CustomerFeedbackService(ICustomerFeedbackRepository repo)
        {
            _repo = repo;
        }

        #endregion

        #region Implementations
        public async Task<List<ShowDetailsCustomerFeedbackDto>> GetAllFeedbackWithDetails(CancellationToken cancellationToken)
            => await _repo.GetAllFeedbackWithDetails(cancellationToken);

        public async Task UpdateIsAcceptedByAdmin(int id, bool isAccepted, CancellationToken cancellationToken)
            => await _repo.UpdateIsAcceptedByAdmin(id, isAccepted, cancellationToken);

        #endregion

    }
}

