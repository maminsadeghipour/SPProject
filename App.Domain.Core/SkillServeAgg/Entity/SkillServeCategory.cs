using System;
using System.Diagnostics.CodeAnalysis;

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


		public List<SkillServe> SkillServes { get; set; }

        public DateTime CreatedAt { get; set; }
        [AllowNull]
        public DateTime? LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }

}

