using System;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.SkillServeAgg.Entity;

namespace App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts
{
	public interface ISkillServeCategoryRepository
	{
        void Add(SkillServeCategory category);
        List<SkillServeCategory> GetAll();
        SkillServeCategory GetById(int id);
        void Update(SkillServeCategory category);
        void DeleteById(int id);
    }
}

