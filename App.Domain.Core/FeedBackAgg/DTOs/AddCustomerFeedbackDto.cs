using System;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.ExpertAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;
using System.Diagnostics.CodeAnalysis;

namespace App.Domain.Core.FeedBackAgg.DTOs
{
	public class AddCustomerFeedbackDto
	{        
        public string Description { get; set; }        
        public int? Rate { get; set; }

        public bool IsAcceptedByAdmin { get; set; }
         
        public DateTime CreatedAt { get; set; }
            
        public int CustomerId { get; set; }
        
        public int ExpertId { get; set; }
        
        public int RequestId { get; set; }
    }
}

