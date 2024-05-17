using System;
using App.Domain.Core.FeedBackAgg.Contracts;
using App.Domain.Core.FeedBackAgg.DTOs;
using App.Domain.Core.FeedBackAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace App.Infrastructure.Repository.FeebackAgg
{
	public class CustomerFeedbackRepository : ICustomerFeedbackRepository
    {

        #region Fields
        private readonly AppDbContext _context;
        private readonly ILogger<CustomerFeedbackRepository> _logger;
        #endregion

        #region Constructors
        public CustomerFeedbackRepository(AppDbContext context, ILogger<CustomerFeedbackRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        #endregion

        #region Implementations
        public async Task<List<CostumerFeedback>> GetAll(CancellationToken cancellationToken) => await _context.CostumerFeedbacks.AsNoTracking().ToListAsync(cancellationToken);

        public async Task<List<ShowDetailsCustomerFeedbackDto>> GetAllFeedbackWithDetails(CancellationToken cancellationToken)
            => await _context.CostumerFeedbacks.Where(f => !f.IsDeleted).Select(
                f => new ShowDetailsCustomerFeedbackDto()
                {
                    Id = f.Id,
                    Description = f.Description,
                    CustomerName = f.Customer.Username,
                    ExpertName = f.Expert.Username,
                    Rate = f.Rate,
                    SkillServeName = f.Request.SkillServe.Title,
                    IsAcceptedByAdmin = f.IsAcceptedByAdmin
                }
                ).ToListAsync(cancellationToken);


        public async Task Add(CostumerFeedback feeback, CancellationToken cancellationToken)
        {
            await _context.CostumerFeedbacks.AddAsync(feeback,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
        {
            var feedback = await GetCostumerFeedbackById(id, cancellationToken);
            feedback.IsDeleted = true;
            feedback.LastUpdatedAt = DateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<CostumerFeedback> GetById(int id, CancellationToken cancellationToken)
        {
            var feedback = await _context.CostumerFeedbacks.AsNoTracking().FirstOrDefaultAsync(cf => cf.Id == id, cancellationToken);
            if (feedback != null)
                return feedback;
            throw new Exception($"CustomerFeedback with id {id} did not found");
        }


        public async Task Update(CostumerFeedback feedback, CancellationToken cancellationToken)
        {
            var feedbakInDatabase = await GetCostumerFeedbackById(feedback.Id, cancellationToken);

            if (feedback.Description != null)
                feedbakInDatabase.Description = feedback.Description;
            if (feedback.Rate != null)
                feedbakInDatabase.Rate = feedback.Rate;

            feedbakInDatabase.LastUpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);

        }

        public async Task UpdateIsAcceptedByAdmin(int id ,bool isAccepted, CancellationToken cancellationToken)
        {
            var feedBack = await GetCostumerFeedbackById(id, cancellationToken);
            feedBack.IsAcceptedByAdmin = isAccepted;
            await _context.SaveChangesAsync(cancellationToken);
            _logger.LogInformation($"FeedBack With id {id} IsAccepted = {isAccepted}");
        }

        #endregion





        


        #region Privates
        private async Task<CostumerFeedback> GetCostumerFeedbackById(int id, CancellationToken cancellationToken)
        {
            var feedback = await _context.CostumerFeedbacks.FirstOrDefaultAsync(cf => cf.Id == id, cancellationToken);
            if (feedback != null)
                return feedback;
            throw new Exception($"CustomerFeedback with id {id} did not found");
        }

        
        

        #endregion
    }
}

