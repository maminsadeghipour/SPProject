using System;
using App.Domain.Core.SkillServeAgg.Entity;

namespace App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts
{
	public interface ISkillServeRepository
	{
        void Add(SkillServe skillServe);
        List<SkillServe> GetAll();
        SkillServe GetById(int id);
        void Update(SkillServe skillServe);
        void DeleteById(int id);
    }
}

