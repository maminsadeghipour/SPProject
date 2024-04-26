using System;
using System.Diagnostics.CodeAnalysis;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.RequestAgg.Enum;

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

        [AllowNull]
        public Bid? AcceptedBid { get; set; }
        [AllowNull]
        public int? AcceptedBidId { get; set; }

        public List<RequestPicture> Pictures { get; set; }
        public List<Bid> Bids { get; set; }


        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

    }
}

