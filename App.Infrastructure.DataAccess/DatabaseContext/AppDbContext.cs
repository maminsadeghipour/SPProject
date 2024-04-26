using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.ExpertAgg.Entity;
using App.Domain.Core.FeedBackAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.SkillServeAgg.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.DataAccess.DatabaseContext
{
	public class AppDbContext : DbContext
	{
		public AppDbContext()
		{
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=127.0.0.1,1433;Initial Catalog=SPProject;User ID=sa;Password=user@2023;TrustServerCertificate=True;Encrypt=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<CostumerFeedback> CostumerFeedbacks { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestPicture> RequestPictures { get; set; }
        public DbSet<SkillServe> SkillServes { get; set; }
        public DbSet<SkillServeCategory> SkillServeCategories { get; set; }
    }
}

