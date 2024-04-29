using System;
using App.Domain.Core.RequestAgg.Entity;

namespace App.Domain.Core.RequestAgg.Contracts.RequestContracts
{
	public interface IRequestRepository
	{
        void Add(Request request);
        List<Request> GetAll();
        Request GetById(int id);
        void Update(Request request);
        void DeleteById(int id);
    }
}

