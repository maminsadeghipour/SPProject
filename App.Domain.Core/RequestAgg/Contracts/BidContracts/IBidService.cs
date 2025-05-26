using System;
namespace App.Domain.Core.RequestAgg.Contracts.BidContracts
{
	public interface IBidService
	{
        Task<int> GetExpertIdById(int id, CancellationToken cancellationToken);
    }
}

