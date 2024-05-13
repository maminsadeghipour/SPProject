using System;
namespace App.Domain.Core.SkillServeAgg.DTOs
{
	public class ShowDetalisSkillServeDto
	{
		public ShowDetalisSkillServeDto()
		{
		}

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfExperts { get; set; }
        public int NumberOfRequests { get; set; }
    }
}

