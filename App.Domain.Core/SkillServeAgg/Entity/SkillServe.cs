using System;
using App.Domain.Core.ExpertAgg.Entity;

namespace App.Domain.Core.SkillServeAgg.Entity
{
	public class SkillServe
	{
		public SkillServe()
		{
		}

        public int Id { get; set; }
        public string Title { get; set; }
        public int MinWage { get; set; }
       
       
        public SkillServeCategory Category { get; set; }
        public int CategoryId { get; set; }

        public List<Expert> Experts { get; set; }

        public DateTime RegisteredAt { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}

