using System;
using App.Domain.Core.RequestAgg.Contracts.BidContracts;

namespace App.Domain.Service.RequestAgg
{
	public class BidService : IBidService
    {
		private readonly IBidRepository _repo;

        public BidService(IBidRepository repo)
        {
            _repo = repo;
        }

        public async Task<int> GetExpertIdById(int id, CancellationToken cancellationToken)
            => await _repo.GetExpertIdById(id, cancellationToken);
    }
}

