
using System;
using App.Domain.Core.CustomerAgg.Entity;
using App.Domain.Core.IdentityAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DataAccess.Configuration.CustomerAgg
{
	public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
		public CustomerConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.FirstName).IsRequired();
            builder.Property(c => c.LastName).IsRequired();
            builder.Property(c => c.RegisteredAt).IsRequired();

            //builder.Property(c => c.PhoneNumber).IsRequired();            
            //builder.Property(e => e.Username).IsRequired();
            //builder.Property(e => e.Password).IsRequired();

            builder.Property(c => c.LastUpdatedAt).IsRequired(false);
            builder.Property(c => c.CreatedAt).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);

            builder.HasMany(c => c.Addresses)
                .WithOne(a => a.Customer)
                .HasForeignKey(a => a.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(c => c.Requests)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(c => c.CostumerFeedbacks)
                .WithOne(cf => cf.Customer)
                .HasForeignKey(cf => cf.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.ApplicationUser)
                .WithOne(a => a.Customer)
                .OnDelete(DeleteBehavior.NoAction);

            #region SeedData

            builder.HasData(
                new Customer()
                {
                    Id = 4,
                    FirstName = "Maryam",
                    LastName = "Maryam",                    
                    RegisteredAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                    ApplicationUserId = 4
                }
                );            
            #endregion

        }
    }
}

