using System;
namespace App.Domain.Core.IdentityAgg.DTOs
{
	public class RegisterDto
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public bool IsExpert { get; set; }
		public bool IsCustomer { get; set; }

	}
}

