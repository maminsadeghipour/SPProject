using System;
using App.Domain.Core.ExpertAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;

namespace App.Domain.Core.RequestAgg.Contracts.BidContracts
{
	public interface IBidRepository
	{
        Task Add(Bid bid, CancellationToken cancellationToken);
        Task<List<Bid>> GetAll(CancellationToken cancellationToken);
        Task<Bid> GetById(int id, CancellationToken cancellationToken);
        Task Update(Bid bid, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);
    }
}

