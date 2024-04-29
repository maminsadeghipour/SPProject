using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.ExpertAgg.Entity;
using App.Domain.Core.FeedBackAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.SkillServeAgg.Entity;
using App.Infrastructure.DataAccess.Configuration.AddressAgg;
using App.Infrastructure.DataAccess.Configuration.CustomerAgg;
using App.Infrastructure.DataAccess.Configuration.ExpertAgg;
using App.Infrastructure.DataAccess.Configuration.FeebackAgg;
using App.Infrastructure.DataAccess.Configuration.RequestAgg;
using App.Infrastructure.DataAccess.Configuration.SkillServeAgg;
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

            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ExpertConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerFeedbackConfiguration());
            modelBuilder.ApplyConfiguration(new RequestConfiguration());
            modelBuilder.ApplyConfiguration(new BidConfiguration());
            modelBuilder.ApplyConfiguration(new RequestPictureConfiguration());
            modelBuilder.ApplyConfiguration(new SkillServeConfiguration());
            modelBuilder.ApplyConfiguration(new SkillServeCategoryConfiguration());

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

