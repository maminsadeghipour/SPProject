using System;
using System.Diagnostics.CodeAnalysis;
using App.Domain.Core.ExpertAgg.Entity;

namespace App.Domain.Core.RequestAgg.Entity
{
	public class Bid
	{
		public Bid()
		{
		}

		public int Id { get; set; }
		public int Price { get; set; }
		public string Description { get; set; }
		public DateOnly FulfillmentDate { get; set; }


		// Developing Properties
		public DateTime CreatedAt { get; set; }
        [AllowNull]
        public DateTime? LastUpdatedAt { get; set; }
		public bool IsDeleted { get; set; }


		// Many To One
		public Expert Expert { get; set; }
		public int ExpertId { get; set; }

		public Request Request { get; set; }
		public int RequestId { get; set; }

	}
}

