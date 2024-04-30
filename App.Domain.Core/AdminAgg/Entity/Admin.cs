using System;
using System.Diagnostics.CodeAnalysis;

namespace App.Domain.Core.AdminAgg.Entity
{
	public class Admin
	{
		public Admin()
		{
		}

		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }

		public DateTime CreatedAt { get; set; }
		[AllowNull]
		public DateTime? LastUpdatedAt { get; set; }
		public bool IsDeleted { get; set; }
	}
}

