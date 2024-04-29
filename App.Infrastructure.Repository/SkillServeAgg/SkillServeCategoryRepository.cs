using System;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts;
using App.Domain.Core.SkillServeAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.SkillServeAgg
{
	public class SkillServeCategoryRepository : ISkillServeCategoryRepository
    {

        private readonly AppDbContext _context;

        public SkillServeCategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        

        public void Add(SkillServeCategory category)
        {
            _context.SkillServeCategories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var category = _context.SkillServeCategories.Find(id);
            category.IsDeleted = true;
            _context.SaveChanges();
        }

        public List<SkillServeCategory> GetAll() => _context.SkillServeCategories.AsNoTracking().ToList();

        public SkillServeCategory GetById(int id) => _context.SkillServeCategories.AsNoTracking().FirstOrDefault(c => c.Id == id);

        public void Update(SkillServeCategory category)
        {
            var categoryInDatabse = _context.SkillServeCategories.FirstOrDefault(c => c.Id == category.Id);

            if (category.Title != null)
                categoryInDatabse.Title = category.Title;

            categoryInDatabse.LastUpdatedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}

