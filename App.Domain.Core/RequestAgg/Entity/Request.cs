using System;
using System.Diagnostics.CodeAnalysis;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.RequestAgg.Enum;
using App.Domain.Core.SkillServeAgg.Entity;

namespace App.Domain.Core.RequestAgg.Entity
{
	public class Request
	{
		public Request()
		{
		}

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public RequestSate RequestState { get; set; }
        

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        //[AllowNull]
        //public Bid? AcceptedBid { get; set; }
        [AllowNull]
        public int? AcceptedBidId { get; set; }


        // One To Many
        public List<RequestPicture> Pictures { get; set; }
        public List<Bid> Bids { get; set; }

        // Many To One
        public SkillServe SkillServe { get; set; }
        public int SkillServeId { get; set; }


        // Developing Properties
        public DateTime CreatedAt { get; set; }
        [AllowNull]
        public DateTime? LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

    }
}

