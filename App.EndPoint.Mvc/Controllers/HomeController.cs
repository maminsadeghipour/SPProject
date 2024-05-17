using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.EndPoint.Mvc.Models;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;
using App.Domain.Core.FeedBackAgg.Contracts;
using App.Domain.Core.FeedBackAgg.Entity;

namespace App.EndPoint.Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly IRequestRepository _requestRepository;
    private readonly ICustomerFeedbackRepository customerFeedbackRepository;

    public HomeController(ILogger<HomeController> logger, IRequestRepository requestRepository,
        ICustomerFeedbackRepository customerFeedbackRepository)
    {
        _logger = logger;
        _requestRepository = requestRepository;
        this.customerFeedbackRepository = customerFeedbackRepository;
    }

    public IActionResult Index()
    {        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public async Task<IActionResult> SeedRequestData(CancellationToken cancellationToken)
    {
        Request request = new Request()
        {
            Title = "test",
            Description = "test",
            RequestState = Domain.Core.RequestAgg.Enum.RequestSate.Added,
            CustomerId = 1,
            SkillServeId = 13,
            CreatedAt = DateTime.Now
        };

        await _requestRepository.Add(request, cancellationToken);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> SeedFeedbackData(CancellationToken cancellationToken)
    {
        CostumerFeedback feedback = new CostumerFeedback()
        {            
            Description = "test",
            Rate = 10,
            CustomerId = 1,
            RequestId = 1,
            ExpertId = 1,
            CreatedAt = DateTime.Now
        };

        await customerFeedbackRepository.Add(feedback, cancellationToken);

        return RedirectToAction(nameof(Index));
    }
}

