using System;
using App.Domain.Core.ExpertAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;

namespace App.Domain.Core.RequestAgg.Contracts.BidContracts
{
	public interface IBidRepository
	{
        void Add(Bid bid);
        List<Bid> GetAll();
        Bid GetById(int id);
        void Update(Bid bid);
        void DeleteById(int id);
    }
}

