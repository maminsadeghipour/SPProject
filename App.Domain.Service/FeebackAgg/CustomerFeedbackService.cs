using System;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;
using App.Domain.Core.FeedBackAgg.Contracts;
using App.Domain.Core.FeedBackAgg.DTOs;
using App.Domain.Core.FeedBackAgg.ModelViews;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;

namespace App.Domain.Service.FeebackAgg
{
    public class CustomerFeedbackService : ICustomerFeedbackService
    {
        #region Fields
        private readonly ICustomerFeedbackRepository _repo;
        private readonly ICustomerService _customerService;
        private readonly IRequestService _requestService;
        #endregion

        #region Constructors
        public CustomerFeedbackService(ICustomerFeedbackRepository repo, ICustomerService customerService, IRequestService requestService = null)
        {
            _repo = repo;
            _customerService = customerService;
            _requestService = requestService;
        }

        #endregion

        #region Implementations
        public async Task<List<ShowDetailsCustomerFeedbackDto>> GetAllFeedbackWithDetails(CancellationToken cancellationToken)
            => await _repo.GetAllFeedbackWithDetails(cancellationToken);

        public async Task UpdateIsAcceptedByAdmin(int id, bool isAccepted, CancellationToken cancellationToken)
            => await _repo.UpdateIsAcceptedByAdmin(id, isAccepted, cancellationToken);

        public async Task Add(int applicationUserId, AddCustomerFeedbackModelView feedback, CancellationToken cancellationToken)
        {
            var customerId = await _customerService.GetIdByApplicationUserId(applicationUserId, cancellationToken);
            var expertId = await _requestService.GetExpertIdByAcceptedBid(feedback.RequestId, cancellationToken);

            var feedbackToAdd = new AddCustomerFeedbackDto()
            {
                Description = feedback.Description,
                Rate = feedback.Rate,
                RequestId = feedback.RequestId,

                CustomerId = customerId,
                ExpertId = expertId,

                CreatedAt = DateTime.Now
            };

            await _repo.Add(feedbackToAdd, cancellationToken);

            await _requestService.UpdateRequsestState(feedback.RequestId, Core.RequestAgg.Enum.RequestSate.Finished, cancellationToken);


        }

        #endregion

    }
}

