using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Domain.Core.ExpertAgg.Contracts.ExpertContract;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts;
using App.Domain.Core.SkillServeAgg.DTOs;
using App.Domain.Core.SkillServeAgg.ModelViews;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.EndPoint.Mvc.Controllers
{
    public class AdminController : Controller
    {

        private readonly IExpertAppService _expertAppService;
        private readonly ISkillServeCategoryAppService _skillServeCategoryAppService;

        public AdminController(IExpertAppService expertAppService, ISkillServeCategoryAppService skillServeCategoryAppService)
        {
            _expertAppService = expertAppService;
            _skillServeCategoryAppService = skillServeCategoryAppService;
        }

        // GET: /<controller>/
        public  IActionResult Index(CancellationToken cancellationToken)
        {
            return View();
        }

        // Dashboards

        public IActionResult SkillServesDashboard(CancellationToken cancellationToken)
        {
            return View();
        }

        public async Task<IActionResult> SkillServesCategoryDashboard(CancellationToken cancellationToken)
        {
            var categoryWithDetails = await _skillServeCategoryAppService.GetCategoriesWithDetails(cancellationToken);
            return View(categoryWithDetails);
        }


        // Add Category
        public async Task<IActionResult> AddSkillServeCategory(CancellationToken cancellationToken)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSkillServeCategory(AddSkillServeCategoryModelView category,CancellationToken cancellationToken)
        {           
            await _skillServeCategoryAppService.Add(category, cancellationToken);
            return RedirectToAction(nameof(SkillServesCategoryDashboard));
        }


        // Update Category 
        public async Task<IActionResult> UpdateSkillServeCategory(int id, CancellationToken cancellationToken)
        {
            var category = await _skillServeCategoryAppService.UpdateGetById(id, cancellationToken);
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSkillServeCategory(UpdateSkillServeCategoryDto category, CancellationToken cancellationToken)
        {
            await _skillServeCategoryAppService.Update(category, cancellationToken);
            return RedirectToAction(nameof(SkillServesCategoryDashboard));
        }

        // Delete Category
        public async Task<IActionResult> DeleteSkillServeCategory(int id, CancellationToken cancellationToken)
        {
            await _skillServeCategoryAppService.DeleteById(id,cancellationToken);
            return RedirectToAction(nameof(SkillServesCategoryDashboard));
        }
    }
}

