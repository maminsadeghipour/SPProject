using System;
using System.Diagnostics.CodeAnalysis;
using App.Domain.Core.FeedBackAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.SkillServeAgg.Entity;

namespace App.Domain.Core.ExpertAgg.Entity
{
	public class Expert
	{
		public Expert()
		{
		}

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string BankAccount { get; set; }


        public DateTime RegisteredAt { get; set; }


        // Deleveloping Properties
        public DateTime CreatedAt { get; set; }
        [AllowNull]
        public DateTime? LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }



        // Many To Many
        public List<SkillServe> SkillServes { get; set; }

        // One To Many
        public List<Bid> Bids { get; set; }

        // One To Many 
        public List<CostumerFeedback> CostumerFeedbacks { get; set; }
    }
}

