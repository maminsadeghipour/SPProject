using System;
namespace App.Domain.Core.IdentityAgg.DTOs
{
	public class LoginDto
	{
		public LoginDto()
		{
		}

		public string Email { get; set; }
		public string Password { get; set; }
	}
}

