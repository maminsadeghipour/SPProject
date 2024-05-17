using System;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.ExpertAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;
using System.Diagnostics.CodeAnalysis;

namespace App.Domain.Core.FeedBackAgg.DTOs
{
	public class ShowDetailsCustomerFeedbackDto
	{
		public ShowDetailsCustomerFeedbackDto()
		{
		}

        public int Id { get; set; }
        public string Description { get; set; }        
        public int? Rate { get; set; }               
        public string CustomerName { get; set; }        
        public string ExpertName { get; set; }        
        public string SkillServeName { get; set; }
        public bool IsAcceptedByAdmin { get; set; }


    }
}

