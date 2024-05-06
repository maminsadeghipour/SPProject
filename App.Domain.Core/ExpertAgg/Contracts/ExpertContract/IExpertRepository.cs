using System;
using App.Domain.Core.ExpertAgg.Entity;

namespace App.Domain.Core.ExpertAgg.Contracts.ExpertContract
{
	public interface IExpertRepository
	{
        Task Add(Expert expert,CancellationToken cancellationToken);
        Task<List<Expert>> GetAll(CancellationToken cancellationToken);
        Task<Expert> GetById(int id, CancellationToken cancellationToken);
        Task Update(Expert expert, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);

        Task<int> Count(CancellationToken cancellationToken);
    }
}

