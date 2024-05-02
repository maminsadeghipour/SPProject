using System;
using App.Domain.Core.RequestAgg.Entity;

namespace App.Domain.Core.RequestAgg.Contracts.RequestContracts
{
	public interface IRequestRepository
	{
        Task Add(Request request, CancellationToken cancellationToken);
        Task<List<Request>> GetAll(CancellationToken cancellationToken);
        Task<Request> GetById(int id, CancellationToken cancellationToken);
        Task Update(Request request, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);
    }
}

