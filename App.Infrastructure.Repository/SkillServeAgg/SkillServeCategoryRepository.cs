using System;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts;
using App.Domain.Core.SkillServeAgg.DTOs;
using App.Domain.Core.SkillServeAgg.Entity;
using App.Domain.Core.SkillServeAgg.ModelViews;
using App.Infrastructure.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace App.Infrastructure.Repository.SkillServeAgg
{
	public class SkillServeCategoryRepository : ISkillServeCategoryRepository
    {


        #region Fields
        private readonly AppDbContext _context;
        private readonly ILogger<SkillServeCategoryRepository> _logger;
        #endregion

        #region Constructors
        public SkillServeCategoryRepository(AppDbContext context, ILogger<SkillServeCategoryRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        #endregion


        #region Implementations
        public async Task<List<SkillServeCategory>> GetAll(CancellationToken cancellationToken) => await _context.SkillServeCategories.AsNoTracking().ToListAsync(cancellationToken);

        public async Task<UpdateSkillServeCategoryDto> UpdateGetById(int id, CancellationToken cancellationToken)
        {
            var category = await _context.SkillServeCategories.Where(c => c.Id == id && !c.IsDeleted)
                          .Select(c => new UpdateSkillServeCategoryDto() { Id = c.Id, Title = c.Title, Description = c.Description })
                          .FirstOrDefaultAsync(cancellationToken);
            if (category != null)
                return category;

            throw new Exception($"SkilCategory with id {id} did not found");
        }

        public async Task Update(UpdateSkillServeCategoryDto category, CancellationToken cancellationToken)
        {
            //var categoryInDatabase = await _context.SkillServeCategories.FirstOrDefaultAsync(c => c.Id == category.Id);
            var categoryInDatabase = await GetSkillServeCategoryById(category.Id, cancellationToken);

            if (categoryInDatabase != null)
            {
                categoryInDatabase.Title = category.Title;
                categoryInDatabase.Description = category.Description;
                categoryInDatabase.LastUpdatedAt = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                var Title = category.Title;
                _logger.LogInformation($"SkillServeCategory {Title} Updated");
            }
            else
            {
                var ex =  new Exception($"SkilCategory with id {category.Id} did not found");
                _logger.LogError(ex,ex.Message);
                throw ex;
            }
                
            
        }


        public async Task Add(SkillServeCategory category, CancellationToken cancellationToken)
        {
            await _context.SkillServeCategories.AddAsync(category,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            var Title = category.Title;
            _logger.LogInformation($"SkillServeCategory {Title} Added");
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
        {
            var category = await GetSkillServeCategoryById(id, cancellationToken);
            category.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);

            var Title = category.Title;
            _logger.LogInformation($"SkillServeCategory {Title} Deleted");
        }

        public async Task<SkillServeCategory> GetById(int id, CancellationToken cancellationToken)
        {
            var category = await _context.SkillServeCategories.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
            if (category != null)
                return category;
            var ex =  new Exception($"SkilCategory with id {id} did not found");
            _logger.LogError(ex, ex.Message);
            throw ex;
        }


        //public async Task Update(SkillServeCategory category, CancellationToken cancellationToken)
        //{
        //    var categoryInDatabse = await GetSkillServeCategoryById(category.Id, cancellationToken);

        //    if (category.Title != null)
        //        categoryInDatabse.Title = category.Title;

        //    categoryInDatabse.LastUpdatedAt = DateTime.Now;

        //    await _context.SaveChangesAsync(cancellationToken);
        //}


        public async Task<List<ShowDetailsSkillCategoryDto>> GetCategoriesWithDetails(CancellationToken cancellationToken)
         => await _context.SkillServeCategories
                .Where(ct => !ct.IsDeleted)
                .Select(ct =>
                        new ShowDetailsSkillCategoryDto() {
                            Id = ct.Id,
                            Title = ct.Title,
                            Description = ct.Description,
                            NumberOfSkills = ct.SkillServes.Count(),
                            NumberOfRequest = ct.SkillServes.SelectMany(s=>s.Requests).Count()
                        }
                        ).ToListAsync(cancellationToken);

        public async Task<List<TitleSkillServeCategoryModelView>> GetTitles(CancellationToken cancellationToken)
            => await _context.SkillServeCategories
                    .Where(ct => !ct.IsDeleted)
                    .Select(ct =>
                        new TitleSkillServeCategoryModelView()
                        {
                            Id = ct.Id,
                            Title = ct.Title
                        }
                    ).ToListAsync(cancellationToken);
         

        #endregion






        #region Privates
        private async Task<SkillServeCategory> GetSkillServeCategoryById(int id, CancellationToken cancellationToken)
        {
            var category = await _context.SkillServeCategories.FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
            if (category != null)
                return category;
            throw new Exception($"SkillCategory with id {id} did not found");
        }

        






        #endregion
    }
}

