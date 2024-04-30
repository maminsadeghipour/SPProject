
using System;
using App.Domain.Core.CustomerAgg.Entity;
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
            builder.Property(c => c.PhoneNumber).IsRequired();
            builder.Property(c => c.Username).IsRequired();
            builder.Property(c => c.Password).IsRequired();
            builder.Property(c => c.RegisteredAt).IsRequired();

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

            #region SeedData

            builder.HasData(
                new Customer() { Id = 1, FirstName = "Ali", LastName = "Alizadeh", Username = "Ali.Alizadeh",
                Password = "1234", RegisteredAt = DateTime.Now, CreatedAt = DateTime.Now, PhoneNumber = "09121234567"}
                );

            #endregion

        }
    }
}

