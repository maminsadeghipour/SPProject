using System;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;
using App.Domain.Core.RequestAgg.Contracts.BidContracts;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;
using App.Domain.Core.RequestAgg.Contracts.RequestPictureContracts;
using App.Domain.Core.RequestAgg.DTOs;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.RequestAgg.Enum;

namespace App.Domain.Service.RequestAgg
{
	public class RequestService : IRequestService
    {

        #region Fields
        private readonly IRequestRepository _repo;
        private readonly ICustomerService _customerService;
        private readonly IBidService _bidService;
        private readonly IRequestPictureService _requestPictureService;

        #endregion

        #region Constructors
        public RequestService(IRequestRepository requestRepository, ICustomerService customerService, IBidService bidService, IRequestPictureService requestPictureService)
        {
            _repo = requestRepository;
            _customerService = customerService;
            _bidService = bidService;
            _requestPictureService = requestPictureService;
        }



        #endregion

        #region Implementations
        public async Task<int> Count(CancellationToken cancellationToken)
            => await _repo.Count(cancellationToken);

        public async Task<List<ShowDetailsRequestDto>> GetAllRequestsWithDetails(CancellationToken cancellationToken)
            => await _repo.GetAllRequestsWithDetails(cancellationToken);

        public async Task<UpdateRequestDto> GetUpdateDtoById(int id, CancellationToken cancellationToken)
            => await _repo.GetUpdateDtoById(id, cancellationToken);

        public async Task Update(UpdateRequestDto request, CancellationToken cancellationToken)
            => await _repo.Update(request, cancellationToken);

        public async Task AddRequest(int userApplicationId, AddRequestDto request, CancellationToken cancellationToken)
        {
            var customerId = await _customerService.GetIdByApplicationUserId(userApplicationId, cancellationToken);
            List<RequestPicture> pics = new();           
            pics = await _requestPictureService.AddPicturesToDisk(request.Pictures);
           
            var requestToAdd = new Request()
            {
                Title = request.Title,
                Description = request.Description,
                DeadLine = request.DeadLine,
                SkillServeId = request.SkillServeId,
                CustomerId = customerId,
                RequestState = Core.RequestAgg.Enum.RequestSate.WaitingForBids,
                CreatedAt = DateTime.Now,
                AddressId = request.AddressId,
                Pictures = pics
            };

            await _repo.Add(requestToAdd, cancellationToken);
        }

        public async Task<List<ShowDetailsRequestDto>> GetRequestByUserId(int applicationUserId, CancellationToken cancellationToken)
        {
            var customerId = await _customerService.GetIdByApplicationUserId(applicationUserId, cancellationToken);

            return await _repo.GetRequestByCustomerId(customerId, cancellationToken);
        }

        public async Task<ShowDetailBidsRequestDto> GetReequestWithBids(int requestId, int applicationUserId, CancellationToken cancellationToken)
        {
            var customerId = await _customerService.GetIdByApplicationUserId(applicationUserId, cancellationToken);

            return await _repo.GetReequestWithBids(requestId, customerId, cancellationToken);
        }

        public async Task AcceptBid(int requestId, int bidId, CancellationToken cancellationToken)
        {
            var request = await _repo.GetById(requestId, cancellationToken);

            if (!request.Bids.Any(b => b.Id == bidId))
                throw new Exception($"Bid id : {bidId} is not for request id :  {requestId}");

            request.AcceptedBidId = bidId;
            request.RequestState = Core.RequestAgg.Enum.RequestSate.WaitingToExpertServeToCostumer;

            await _repo.Update(request, cancellationToken);

        }

        public async Task<int> GetExpertIdByAcceptedBid(int requestId, CancellationToken cancellationToken)
        {
            var bidId = await _repo.GetRequestAcceptedBidId(requestId, cancellationToken);
            return await _bidService.GetExpertIdById((int)bidId, cancellationToken);
        }

        public async Task UpdateRequsestState(int requestId, RequestSate requestSate, CancellationToken cancellationToken)
        {
            var request = await _repo.GetById(requestId, cancellationToken);
            request.RequestState = requestSate;
            await _repo.Update(request, cancellationToken);
        }

        #endregion


    }
}

