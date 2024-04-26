using System;
namespace App.Domain.Core.SkillServeAgg.Entity
{
	public class SkillServeCategory
	{
		public SkillServeCategory()
		{
		}

		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }


        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }

}

