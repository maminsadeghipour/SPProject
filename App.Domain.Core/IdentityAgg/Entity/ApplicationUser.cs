using System;
using System.Diagnostics.CodeAnalysis;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.ExpertAgg.Entity;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.Core.IdentityAgg.Entity
{
	public class ApplicationUser : IdentityUser<int>
	{
		[AllowNull]
		public Customer? Customer { get; set; }
        //[AllowNull]
        //public int? CustomerId { get; set; }

        [AllowNull]
        public Expert? Expert { get; set; }
        //[AllowNull]
        //public int? ExpertId { get; set; }
    }
}

