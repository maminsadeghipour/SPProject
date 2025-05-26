using System;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.Core.IdentityAgg.Contracts
{
	public interface IAccountAppServices
	{
        Task<List<IdentityError>> Register(string email, string password, bool isCustomer, bool IsExpert);
        Task<bool> Login(string email, string password);
    }
}

