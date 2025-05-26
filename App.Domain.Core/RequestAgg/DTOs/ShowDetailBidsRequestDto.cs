using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.RequestAgg.Enum;
using App.Domain.Core.SkillServeAgg.Entity;
using System.Diagnostics.CodeAnalysis;

namespace App.Domain.Core.RequestAgg.DTOs
{
	public class ShowDetailBidsRequestDto
	{
        public int Id { get; set; }
        public string Title { get; set; }        
        public RequestSate RequestState { get; set; }
        public DateTime DeadLine { get; set; }                    
        [AllowNull]
        public int? AcceptedBidId { get; set; }      
        public List<Bid> Bids { get; set; }        
        public string SkillServeName { get; set; }                
        public DateTime CreatedAt { get; set; }        
    }
}

