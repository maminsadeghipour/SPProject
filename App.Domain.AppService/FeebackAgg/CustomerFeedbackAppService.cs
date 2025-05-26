using System;
using App.Domain.Core.FeedBackAgg.Contracts;
using App.Domain.Core.FeedBackAgg.DTOs;
using App.Domain.Core.FeedBackAgg.ModelViews;

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

        public async Task Add(int applicationUser, AddCustomerFeedbackModelView feeback, CancellationToken cancellationToken)
            => await _customerFeedbackService.Add(applicationUser, feeback, cancellationToken);
        #endregion
    }
}

