using System;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.ExpertAgg.Contracts.ExpertContract;
using App.Domain.Core.ExpertAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.ExpertAgg
{
	public class ExpertRepository : IExpertRepository
	{
        #region Fields
        private readonly AppDbContext _context;

        #endregion

        #region Constructors
        public ExpertRepository(AppDbContext context)
        {
            _context = context;
        }

        #endregion

        #region Implementations
        public async Task<List<Expert>> GetAll(CancellationToken cancellationToken) => await _context.Experts.AsNoTracking().ToListAsync(cancellationToken);

        public async Task<int> Count(CancellationToken cancellationToken) => await _context.Experts.Where(e => !e.IsDeleted).CountAsync(cancellationToken);
        

        public async Task Add(Expert expert, CancellationToken cancellationToken)
        {
            await _context.Experts.AddAsync(expert,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
        {
            var expert = await GetExpertById(id, cancellationToken);
            expert.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<Expert> GetById(int id, CancellationToken cancellationToken)
        {
            var expert = await _context.Experts.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id && !e.IsDeleted, cancellationToken);
            if (expert != null)
                return expert;
            throw new Exception($"Expert with id {id} did not found");
        }

        public async Task Update(Expert expert, CancellationToken cancellationToken)
        {
            var expertInDatabase = await GetExpertById(expert.Id, cancellationToken);
            if (expert.FirstName != null)
                expertInDatabase.FirstName = expert.FirstName;
            if (expert.LastName != null)
                expertInDatabase.LastName = expert.LastName;

            await _context.SaveChangesAsync();
        }



        #endregion






        #region Privates
        private async Task<Expert> GetExpertById(int id, CancellationToken cancellationToken)
        {
            var expert = await _context.Experts.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
            if (expert != null)
                return expert;
            throw new Exception($"Expert with id {id} did not found");
        }

        

        #endregion
    }
}

