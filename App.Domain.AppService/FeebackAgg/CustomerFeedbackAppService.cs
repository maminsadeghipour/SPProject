using System;
using App.Domain.Core.FeedBackAgg.Contracts;
using App.Domain.Core.FeedBackAgg.DTOs;

namespace App.Domain.AppService.FeebackAgg
{
	public class CustomerFeedbackAppService : ICustomerFeedbackAppService
    {
        #region Fields
        private readonly ICustomerFeedbackService _customerFeedbackService;
        #endregion

        #region Constructors
        public CustomerFeedbackAppService(ICustomerFeedbackService customerFeedbackService)
        {
            _customerFeedbackService = customerFeedbackService;
        }

        #endregion

        #region Implementations
        public async Task<List<ShowDetailsCustomerFeedbackDto>> GetAllFeedbackWithDetails(CancellationToken cancellationToken)
            => await _customerFeedbackService.GetAllFeedbackWithDetails(cancellationToken);

        public async Task UpdateIsAcceptedByAdmin(int id, bool isAccepted, CancellationToken cancellationToken)
            => await _customerFeedbackService.UpdateIsAcceptedByAdmin(id, isAccepted, cancellationToken);
        #endregion
    }
}

