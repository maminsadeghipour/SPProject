using System;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;
using App.Domain.Core.RequestAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.RequestAgg
{
	public class RequestRepository : IRequestRepository
    {

        #region Fields
        private readonly AppDbContext _context;

        #endregion

        #region Constructors
        public RequestRepository(AppDbContext context)
        {
            _context = context;
        }

        #endregion

        #region Implementations
        public async Task<List<Request>> GetAll(CancellationToken cancellationToken) => await _context.Requests.AsNoTracking().ToListAsync(cancellationToken);

        public async Task Add(Request request, CancellationToken cancellationToken)
        {
            await _context.Requests.AddAsync(request,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
        {
            var request = await GetRequestById(id, cancellationToken);
            request.IsDeleted=true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<Request> GetById(int id, CancellationToken cancellationToken)
        {
            var request = await _context.Requests.AsNoTracking().FirstOrDefaultAsync(r => r.Id == id && !r.IsDeleted , cancellationToken);
            if (request != null)
                return request;
            throw new Exception($"Request with id {id} did not found");
        }

        public async Task Update(Request request, CancellationToken cancellationToken)
        {
            var requestInDatabase = await GetRequestById(request.Id, cancellationToken);

            requestInDatabase.RequestState = request.RequestState;

            requestInDatabase.LastUpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);
        }
        #endregion





        #region Privates
        private async Task<Request> GetRequestById(int id, CancellationToken cancellationToken)
        {
            var request = await _context.Requests.AsNoTracking().FirstOrDefaultAsync(r => r.Id == id, cancellationToken);
            if (request != null)
                return request;
            throw new Exception($"Request with id {id} did not found");
        }
      
        #endregion
    }
}

