using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Domain.Core.EnumAgg.Contracts;
using App.Domain.Core.ExpertAgg.Contracts.ExpertContract;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;
using App.Domain.Core.RequestAgg.DTOs;
using App.Domain.Core.RequestAgg.Enum;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts;
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
        private readonly ISkillServeAppService _skillServeAppService;
        private readonly IRequestAppService _requestAppService;
        

        public AdminController(IExpertAppService expertAppService, ISkillServeCategoryAppService skillServeCategoryAppService,
            ISkillServeAppService skillServeAppService, IRequestAppService requestAppService)
        {
            _expertAppService = expertAppService;
            _skillServeCategoryAppService = skillServeCategoryAppService;
            _skillServeAppService = skillServeAppService;
            _requestAppService = requestAppService;            
        }

        // GET: /<controller>/
        public  IActionResult Index(CancellationToken cancellationToken)
        {
            return View();
        }

        // Dashboards

        public async Task<IActionResult>SkillServesDashboard(CancellationToken cancellationToken)
        {
            var skillServesWithDetail = await _skillServeAppService.GetSkillServesWithDetails(cancellationToken);
            return View(skillServesWithDetail);
        }

        public async Task<IActionResult> SkillServesCategoryDashboard(CancellationToken cancellationToken)
        {
            var categories = await _skillServeCategoryAppService.GetCategoriesWithDetails(cancellationToken);
            return View(categories);
        }

        public async Task<IActionResult> RequestDashboard(CancellationToken cancellationToken)
        {            
            var requests = await _requestAppService.GetAllRequestsWithDetails(cancellationToken);
            return View(requests);
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

        // Add SkillServe
        public async Task<IActionResult> AddSkillServe(CancellationToken cancellationToken)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSkillServe(AddSkillServeModelView skillServe ,CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _skillServeAppService.Add(skillServe, cancellationToken);
                return RedirectToAction(nameof(SkillServesDashboard));

            }
            return View(skillServe);
        }

        // Update Skill
        public async Task<IActionResult> UpdateSkillServe(int id, CancellationToken cancellationToken)
        {
            var skill = await _skillServeAppService.UpdateDtoGetById(id, cancellationToken);
            return View(skill);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSkillServe(UpdateSkillServeDto skill, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _skillServeAppService.Update(skill, cancellationToken);
                return RedirectToAction(nameof(SkillServesDashboard));

            }
            return View(skill);
        }

        // Delete Skill
        public async Task<IActionResult> DeleteSkillServe(int id, CancellationToken cancellationToken)
        {
            await _skillServeAppService.DeleteById(id, cancellationToken);
            return RedirectToAction(nameof(SkillServesDashboard));
        }


        // Request Detail
        public async Task<IActionResult> UpdateRequest(int id,CancellationToken cancellationToken)
        {            
            var request = await _requestAppService.GetUpdateDtoById(id, cancellationToken);
            return View(request);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRequest(UpdateRequestDto request, CancellationToken cancellationToken)
        {
            await _requestAppService.Update(request, cancellationToken);
            return RedirectToAction(nameof(RequestDashboard));
        }


    }
}

