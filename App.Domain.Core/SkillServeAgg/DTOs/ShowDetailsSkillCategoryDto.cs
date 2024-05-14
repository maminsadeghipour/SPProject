using System;
namespace App.Domain.Core.SkillServeAgg.DTOs
{
	public class ShowDetailsSkillCategoryDto
	{
		public ShowDetailsSkillCategoryDto()
		{
		}


		public int Id { get; set; }
		public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfSkills { get; set; }
		public int NumberOfRequest { get; set; }
	}
}

