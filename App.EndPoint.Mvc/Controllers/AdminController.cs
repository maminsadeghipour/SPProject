using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Domain.Core.ExpertAgg.Contracts.ExpertContract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.EndPoint.Mvc.Controllers
{
    public class AdminController : Controller
    {

        private readonly IExpertAppService _expertAppService;

        public AdminController(IExpertAppService expertAppService)
        {
            _expertAppService = expertAppService;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {

            var countEx = await _expertAppService.Count(cancellationToken);

            return View();
        }
    }
}

