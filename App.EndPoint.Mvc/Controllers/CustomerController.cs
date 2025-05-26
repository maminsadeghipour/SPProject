using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using App.Domain.Core.AddressAgg.DTOs;
using App.Domain.Core.AddressAgg.Contracts.AddressContract;
using App.Domain.Core.RequestAgg.DTOs;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;
using App.Domain.Core.FeedBackAgg.Contracts;
using App.Domain.Core.FeedBackAgg.ModelViews;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.EndPoint.Mvc.Controllers
{
    [Authorize(Roles ="Customer")]
    public class CustomerController : Controller
    {

        private readonly ICustomerAppService _customerAppService;
        private readonly IAddressAppService _addressAppService;
        private readonly IRequestAppService _requestAppService;
        private readonly ICustomerFeedbackAppService _customerFeedbackAppService;

        public CustomerController(ICustomerAppService customerAppService, IAddressAppService addressAppService,
            IRequestAppService requestAppService, ICustomerFeedbackAppService customerFeedbackAppService)
        {
            _customerAppService = customerAppService;
            _addressAppService = addressAppService;
            _requestAppService = requestAppService;
            _customerFeedbackAppService = customerFeedbackAppService;
        }


        public async Task<IActionResult>Profile(CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var customer = await _customerAppService.GetProfileById(userId, cancellationToken);
            return View(customer);
        }

        // Add Address
        public IActionResult AddAddress()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAddress(AddAddressDto address ,CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return View(address);

            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            await _addressAppService.Add(userId, address, cancellationToken);
            return RedirectToAction(nameof(Profile));
        }

        // Add Request
        public async Task<IActionResult> AddRequest(int skillServeId, CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            ViewBag.SkillServeId = skillServeId;
            ViewBag.CustomerAddresses = await _customerAppService.GetCustomerAddressByApplicationUserId(userId, cancellationToken);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRequest(AddRequestDto request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return View(request);

            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            await _requestAppService.AddRequest(userId, request, cancellationToken);

            return RedirectToAction(nameof(Profile));          
        }

        public async Task<IActionResult> UserRequests(CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var requests = await _requestAppService.GetRequestByUserId(userId, cancellationToken);
            return View(requests);
        }

        public async Task<IActionResult> RequestById(int requestId, CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var request = await _requestAppService.GetReequestWithBids(requestId, userId, cancellationToken);

            return View(request);
        }


        public async Task<IActionResult> AcceptBid(int requestId, int bidId, CancellationToken cancellationToken)
        {
            await _requestAppService.AcceptBid(requestId, bidId, cancellationToken);
            return RedirectToAction(nameof(RequestById), new {requestId = requestId});
        }

        public async Task AddFeedBack(CancellationToken cancellationToken)
        {
            
        }
        [HttpPost]
        public async Task<IActionResult> AddFeedBack(string Description, int Rate, int RequestId, CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var feedback = new AddCustomerFeedbackModelView() { Description = Description, Rate = Rate, RequestId = RequestId };
            await _customerFeedbackAppService.Add(userId , feedback, cancellationToken);

            return RedirectToAction(nameof(UserRequests));
        }





    }
}

