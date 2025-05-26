using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.EndPoint.Mvc.Models;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;
using App.Domain.Core.FeedBackAgg.Contracts;
using App.Domain.Core.FeedBackAgg.Entity;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts;

namespace App.EndPoint.Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly IRequestRepository _requestRepository;
    private readonly ICustomerFeedbackRepository customerFeedbackRepository;
    private readonly ISkillServeCategoryAppService _skillServeCategoryAppService;
    private readonly ISkillServeAppService _skillServeAppService;

    public HomeController(ILogger<HomeController> logger, IRequestRepository requestRepository,
        ICustomerFeedbackRepository customerFeedbackRepository, ISkillServeCategoryAppService skillServeCategoryAppService, ISkillServeAppService skillServeAppService)
    {
        _logger = logger;
        _requestRepository = requestRepository;
        this.customerFeedbackRepository = customerFeedbackRepository;


        _skillServeCategoryAppService = skillServeCategoryAppService;
        _skillServeAppService = skillServeAppService;
    }

    public async Task<IActionResult> Index(CancellationToken cancellationToken)
    {
        var categories = await _skillServeCategoryAppService.GetTitles(cancellationToken);
        return View(categories);
    }

    public async Task<IActionResult> SkillServesByCategory(int categoryId, CancellationToken cancellationToken)
    {

        var skillServes = await _skillServeAppService.GetSkillServesByCategoryId(categoryId, cancellationToken);
        return View(skillServes);
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

    //public async Task<IActionResult> SeedFeedbackData(CancellationToken cancellationToken)
    //{
    //    //CostumerFeedback feedback = new CostumerFeedback()
    //    //{            
    //    //    Description = "test",
    //    //    Rate = 10,
    //    //    CustomerId = 1,
    //    //    RequestId = 1,
    //    //    ExpertId = 1,
    //    //    CreatedAt = DateTime.Now
    //    //};

    //    //await customerFeedbackRepository.Add(feedback, cancellationToken);

    //    //return RedirectToAction(nameof(Index));
    //}
}

