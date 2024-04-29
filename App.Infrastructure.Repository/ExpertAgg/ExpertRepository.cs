using System;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.ExpertAgg.Contracts.ExpertContract;
using App.Domain.Core.ExpertAgg.Entity;
using App.Infrastructure.DataAccess.DatabaseContext;

namespace App.Infrastructure.Repository.ExpertAgg
{
	public class ExpertRepository : IExpertRepository
	{
        private readonly AppDbContext _context;

        public ExpertRepository(AppDbContext context)
        {
            _context = context;
        }
        

        public void Add(Expert expert)
        {
            _context.Experts.Add(expert);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var expert = _context.Experts.FirstOrDefault(e => e.Id== id);
            expert.IsDeleted = true;
            _context.SaveChanges();
        }

        public List<Expert> GetAll() => _context.Experts.ToList();

        public Expert GetById(int id) => _context.Experts.FirstOrDefault(e => e.Id == id);


        public void Update(Expert expert)
        {
            var expertInDatabase = _context.Customers.FirstOrDefault(c => c.Id == expert.Id);
            if (expert.FirstName != null)
                expertInDatabase.FirstName = expert.FirstName;
            if (expert.LastName != null)
                expertInDatabase.LastName = expert.LastName;

            _context.SaveChanges();
        }
    }
}

