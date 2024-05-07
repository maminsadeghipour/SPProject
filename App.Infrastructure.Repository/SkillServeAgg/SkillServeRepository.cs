using System;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts;
using App.Domain.Core.SkillServeAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.SkillServeAgg
{
	public class SkillServeRepository : ISkillServeRepository
    {
        
        #region Fields
        private readonly AppDbContext _context;

        #endregion

        #region Constructors
        public SkillServeRepository(AppDbContext context)
        {
            _context = context;
        }

        #endregion


        #region Implementations
        public async Task<List<SkillServe>> GetAll(CancellationToken cancellationToken) => await _context.SkillServes.AsNoTracking().ToListAsync(cancellationToken);

        public async Task<int> Count(CancellationToken cancellationToken)
            => await _context.SkillServes.Where(s => !s.IsDeleted).CountAsync(cancellationToken);


        public async Task Add(SkillServe skill, CancellationToken cancellationToken)
        {
            await _context.SkillServes.AddAsync(skill, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
        {
            var skill = await GetSkillServeById(id, cancellationToken);
            skill.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<SkillServe> GetById(int id, CancellationToken cancellationToken)
        {
            var skill = await _context.SkillServes.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
            if (skill != null)
                return skill;
            throw new Exception($"Skilskill with id {id} did not found");
        }


        public async Task Update(SkillServe skill, CancellationToken cancellationToken)
        {
            var skillInDatabse = await GetSkillServeById(skill.Id, cancellationToken);

            if (skill.Title != null)
                skillInDatabse.Title = skill.Title;

            skillInDatabse.LastUpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);
        }
        #endregion




        #region Privates
        private async Task<SkillServe> GetSkillServeById(int id, CancellationToken cancellationToken)
        {
            var skill = await _context.SkillServes.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
            if (skill != null)
                return skill;
            throw new Exception($"SkillServe with id {id} did not found");
        }

       

        #endregion
    }
}

