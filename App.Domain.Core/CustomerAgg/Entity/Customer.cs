using System;
using System.Diagnostics.CodeAnalysis;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.FeedBackAgg.Entity;
using App.Domain.Core.IdentityAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;

namespace App.Domain.Core.CustomerAgg.Entity
{
	public class Customer
	{
		public Customer()
		{
		}

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime RegisteredAt { get; set; }

		


		// Deleveloping Properties 
        public DateTime CreatedAt { get; set; }
		[AllowNull]
		public DateTime? LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }


		// Many To One 
        public List<Request> Requests { get; set; }
        public List<Address> Addresses { get; set; }
		public List<CostumerFeedback> CostumerFeedbacks { get; set; }

		// One To One
		public ApplicationUser ApplicationUser { get; set; }
		public int ApplicationUserId { get; set; }


	}
}

