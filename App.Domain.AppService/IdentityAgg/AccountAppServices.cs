using System;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.ExpertAgg.Entity;
using App.Domain.Core.IdentityAgg.Contracts;
using App.Domain.Core.IdentityAgg.Entity;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.AppService.IdentityAgg
{
	public class AccountAppServices : IAccountAppServices
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountAppServices(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;            
        }

        public async Task<bool> Login(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, true, lockoutOnFailure : false);
            return result.Succeeded;
        }

        public async Task<List<IdentityError>> Register(string email, string password, bool isCustomer, bool IsExpert)
        {
            var role = string.Empty;

            var user = CreateUser();

            user.UserName = email;
            user.Email = email;

            if (isCustomer)
            {
                role = "Customer";
                user.Customer = new Customer()
                {
                    CreatedAt = DateTime.Now,
                    RegisteredAt = DateTime.Now
                };
            }

            if (IsExpert)
            {
                role = "Expert";
                user.Expert = new Expert()
                {
                    CreatedAt = DateTime.Now,
                    RegisteredAt = DateTime.Now
                };
            }

            var result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
                await _userManager.AddToRoleAsync(user, role);

            return (List<IdentityError>)result.Errors;
        }
       

        private ApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                                                    $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                                                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }
    }
}

