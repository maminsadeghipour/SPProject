using System;
using App.Domain.Core.RequestAgg.Contracts.BidContracts;
using App.Domain.Core.RequestAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.RequestAgg
{
	public class BidRepository : IBidRepository
    {

        private readonly AppDbContext _context;

        public BidRepository(AppDbContext context)
        {
            _context = context;
        }

        

        public void Add(Bid bid)
        {
            _context.Bids.Add(bid);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var bid = _context.Bids.Find(id);
            bid.IsDeleted = true;
            _context.SaveChanges();
        }

        public List<Bid> GetAll() => _context.Bids.AsNoTracking().ToList();

        public Bid GetById(int id) => _context.Bids.AsNoTracking().FirstOrDefault(b=>b.Id == id);

        public void Update(Bid bid)
        {
            var bidInDatabase = _context.Bids.FirstOrDefault(b => b.Id == bid.Id);

            if (bid.Price != null)
                bidInDatabase.Price = bid.Price;

            if (bid.Description != null)
                bidInDatabase.Description = bid.Description;

            bidInDatabase.LastUpdatedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}

