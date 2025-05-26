using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Domain.AppService.IdentityAgg;
using App.Domain.Core.IdentityAgg.Contracts;
using App.Domain.Core.IdentityAgg.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.EndPoint.Mvc.Controllers
{
    
    public class AccountController : Controller
    {

        private readonly IAccountAppServices _accountAppService;


        public AccountController(IAccountAppServices accountAppServices)
        {
            _accountAppService = accountAppServices;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {

            string returnUrl = (string)TempData["returnUrl"];
            returnUrl ??= Url.Content("~/");

            if (!ModelState.IsValid) return View(loginDto);


            var succeededLogin = await _accountAppService.Login(loginDto.Email, loginDto.Password);

            if (succeededLogin)
                return LocalRedirect(returnUrl);

            else
            {
                ModelState.AddModelError(string.Empty, "نام کاربری یا کلمه عبور اشتباه است");
                return View();
            }            
        }

        public IActionResult Register(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            string returnUrl = (string)TempData["returnUrl"];
            returnUrl ??= Url.Content("~/");

            if (registerDto.IsCustomer && registerDto.IsExpert)
            {
                ModelState.AddModelError(string.Empty, "همزمان نمیتوانید هم متخصص باشید هم مشتری");
                return View();
            }

            returnUrl ??= Url.Content("~/");

            var result = await _accountAppService.Register(registerDto.Email, registerDto.Password
                                                    , registerDto.IsCustomer, registerDto.IsExpert);

            if (result.Count == 0)
            {
                return LocalRedirect(returnUrl);
            }

            foreach (var error in result)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View();

        }
    }
}

