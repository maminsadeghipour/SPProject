using System;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;
using App.Domain.Core.RequestAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.RequestAgg
{
	public class RequestRepository : IRequestRepository
    {

        private readonly AppDbContext _context;

        public RequestRepository(AppDbContext context)
        {
            _context = context;
        }

        

        public void Add(Request request)
        {
            _context.Requests.Add(request);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var request = _context.Requests.Find(id);
            request.IsDeleted=true;
            _context.SaveChanges();
        }

        public List<Request> GetAll() => _context.Requests.AsNoTracking().ToList();


        public Request GetById(int id) => _context.Requests.AsNoTracking().FirstOrDefault(r => r.Id == id);

        public void Update(Request request)
        {
            var requestInDatabase = _context.Requests.FirstOrDefault(r => r.Id == request.Id);

            requestInDatabase.RequestState = request.RequestState;

            requestInDatabase.LastUpdatedAt = DateTime.Now;

            _context.SaveChanges();

        }
    }
}

