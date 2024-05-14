using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.EndPoint.Mvc.Models;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;

namespace App.EndPoint.Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly IRequestRepository _requestRepository;

    public HomeController(ILogger<HomeController> logger, IRequestRepository requestRepository)
    {
        _logger = logger;
        _requestRepository = requestRepository;
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
}

