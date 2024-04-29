using System;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;
using App.Domain.Core.AddressAgg.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DataAccess.Configuration.AddressAgg
{
	public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
		public AddressConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");

            builder.HasKey(a => a.Id);
            
            builder.Property(a => a.Street).IsRequired();
            builder.Property(a => a.Title).IsRequired();
            builder.Property(a => a.CreatedAt).IsRequired();
            builder.Property(a => a.LastUpdatedAt).IsRequired(false);
            builder.Property(a => a.IsDeleted).IsRequired().HasDefaultValue(false);


            builder.HasOne(a => a.City)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CityId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Customer)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);



        }
    }
}

