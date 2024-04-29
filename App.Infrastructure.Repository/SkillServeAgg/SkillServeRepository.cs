using System;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts;
using App.Domain.Core.SkillServeAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.SkillServeAgg
{
	public class SkillServeRepository : ISkillServeRepository
    {
        private readonly AppDbContext _context;

        public SkillServeRepository(AppDbContext context)
        {
            _context = context;
        }


        public void Add(SkillServe skillServe)
        {
            _context.SkillServes.Add(skillServe);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var skillServe = _context.SkillServes.Find(id);
            skillServe.IsDeleted = true;
            _context.SaveChanges();
        }

        public List<SkillServe> GetAll() => _context.SkillServes.AsNoTracking().ToList();

        public SkillServe GetById(int id) => _context.SkillServes.AsNoTracking().FirstOrDefault(c => c.Id == id);

        public void Update(SkillServe skillServe)
        {
            var skillServeInDatabse = _context.SkillServes.FirstOrDefault(c => c.Id == skillServe.Id);

            if (skillServe.Title != null)
                skillServeInDatabse.Title = skillServe.Title;

            skillServeInDatabse.LastUpdatedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}

