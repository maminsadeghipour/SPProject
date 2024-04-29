using System;
using App.Domain.Core.AddressAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DataAccess.Configuration.AddressAgg
{
	public class CityConfiguration : IEntityTypeConfiguration<City>
    {
		public CityConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title).IsRequired();

            builder.HasMany(c => c.Addresses)
                .WithOne(a => a.City)
                .HasForeignKey(a => a.CityId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

