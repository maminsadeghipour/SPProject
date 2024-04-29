using System;
using System.Diagnostics.CodeAnalysis;
using App.Domain.Core.ExpertAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;

namespace App.Domain.Core.SkillServeAgg.Entity
{
	public class SkillServe
	{
		public SkillServe()
		{
		}

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MinWage { get; set; }


        // Developing Properties
        public DateTime CreatedAt { get; set; }
        [AllowNull]
        public DateTime? LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }


        // Many To One
        public SkillServeCategory Category { get; set; }
        public int CategoryId { get; set; }

        // Many To Many 
        public List<Expert> Experts { get; set; }

        // One To Many
        public List<Request> Requests { get; set; }
    }
}

