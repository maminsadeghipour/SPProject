using System;
namespace App.Domain.Core.SkillServeAgg.DTOs
{
	public class UpdateSkillServeCategoryDto
	{
		public UpdateSkillServeCategoryDto()
		{
		}

		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}

