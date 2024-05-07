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
        public  IActionResult Index(CancellationToken cancellationToken)
        {
            return View();
        }


        public IActionResult SkillServesDashboard(CancellationToken cancellationToken)
        {
            return View();
        }

        public IActionResult SkillServesCategoryDashboard(CancellationToken cancellationToken)
        {
            return View();
        }
    }
}

