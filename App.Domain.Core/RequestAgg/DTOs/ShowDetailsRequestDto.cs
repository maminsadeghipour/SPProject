using System;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.RequestAgg.Enum;
using App.Domain.Core.SkillServeAgg.Entity;
using System.Diagnostics.CodeAnalysis;

namespace App.Domain.Core.RequestAgg.DTOs
{
	public class ShowDetailsRequestDto
	{
		public ShowDetailsRequestDto()
		{
		}

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public RequestSate RequestState { get; set; }
        public string CustomerName { get; set; }                              
        public int NumberOfBids { get; set; }        
        public string SkillServeTitle { get; set; }

        
    }
}

