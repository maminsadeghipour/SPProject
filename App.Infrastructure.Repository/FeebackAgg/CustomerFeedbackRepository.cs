using System;
using App.Domain.Core.FeedBackAgg.Contracts;
using App.Domain.Core.FeedBackAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.FeebackAgg
{
	public class CustomerFeedbackRepository : ICustomerFeedbackRepository
    {
        private readonly AppDbContext _context;

        public CustomerFeedbackRepository(AppDbContext context)
        {
            _context = context;
        }


        public void Add(CostumerFeedback feeback)
        {
            _context.CostumerFeedbacks.Add(feeback);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var feedback = _context.CostumerFeedbacks.FirstOrDefault(cf => cf.Id == id);
            feedback.IsDeleted = true;
            feedback.LastUpdatedAt = DateTime.Now;
            _context.SaveChanges();
        }

        public List<CostumerFeedback> GetAll() => _context.CostumerFeedbacks.AsNoTracking().ToList();

        public CostumerFeedback GetById(int id) => _context.CostumerFeedbacks.AsNoTracking().FirstOrDefault(cf=>cf.Id == id);
        

        public void Update(CostumerFeedback feedback)
        {
            var feedbakInDatabase = _context.CostumerFeedbacks.FirstOrDefault(cf => cf.Id == feedback.Id);

            if (feedback.Description != null)
                feedbakInDatabase.Description = feedback.Description;
            if (feedback.Rate != null)
                feedbakInDatabase.Rate = feedback.Rate;

            feedbakInDatabase.LastUpdatedAt = DateTime.Now;

            _context.SaveChanges();

        }
    }
}

