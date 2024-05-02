using System;
using App.Domain.Core.RequestAgg.Contracts.BidContracts;
using App.Domain.Core.RequestAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.RequestAgg
{
	public class BidRepository : IBidRepository
    {

        #region Fields
        private readonly AppDbContext _context;

        #endregion

        #region Consttructors
        public BidRepository(AppDbContext context)
        {
            _context = context;
        }

        #endregion

        #region Impletantions
        public async Task<List<Bid>> GetAll(CancellationToken cancellationToken) => await _context.Bids.AsNoTracking().ToListAsync(cancellationToken);

        public async Task Add(Bid bid, CancellationToken cancellationToken)
        {
            await _context.Bids.AddAsync(bid,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
        {
            var bid = await GetBidById(id, cancellationToken);
            bid.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<Bid> GetById(int id, CancellationToken cancellationToken)
        {
            var bid = await _context.Bids.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id, cancellationToken);
            if (bid != null)
                return bid;
            throw new Exception($"Bid with id {id} did not found");
        }

        public async Task Update(Bid bid, CancellationToken cancellationToken)
        {
            var bidInDatabase = await GetBidById(bid.Id, cancellationToken);

            if (bid.Price != null)
                bidInDatabase.Price = bid.Price;

            if (bid.Description != null)
                bidInDatabase.Description = bid.Description;

            bidInDatabase.LastUpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);
        }

        #endregion

        






        #region Privates

        private async Task<Bid> GetBidById(int id, CancellationToken cancellationToken)
        {
            var bid = await _context.Bids.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id, cancellationToken);
            if (bid != null)
                return bid;
            throw new Exception($"Bid with id {id} did not found");
        }

        #endregion
    }
}

