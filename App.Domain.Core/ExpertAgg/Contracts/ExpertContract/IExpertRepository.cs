using System;
using App.Domain.Core.ExpertAgg.Entity;

namespace App.Domain.Core.ExpertAgg.Contracts.ExpertContract
{
	public interface IExpertRepository
	{
        void Add(Expert expert);
        List<Expert> GetAll();
        Expert GetById(int id);
        void Update(Expert expert);
        void DeleteById(int id);
    }
}

