using System;
using System.Diagnostics.CodeAnalysis;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.ExpertAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;

namespace App.Domain.Core.FeedBackAgg.Entity
{
	public class CostumerFeedback
	{
		public CostumerFeedback()
		{
		}

        public int Id { get; set; }
		public string Description { get; set; }
		public int Rate { get; set; }

        // Developing Entity 
        public DateTime CreatedAt { get; set; }
        [AllowNull]
        public DateTime? LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }


        // Many To One
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public Expert Expert { get; set; }
        public int ExpertId { get; set; }

        public Request Request { get; set; }
        public int RequestId { get; set; }



    }
}

