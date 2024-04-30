using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.AdminAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DataAccess.Configuration.AdminAgg
{
	public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
		public AdminConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admins");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Username).IsRequired();
            builder.Property(a => a.Password).IsRequired();

            builder.Property(a => a.CreatedAt).IsRequired();
            builder.Property(a => a.LastUpdatedAt).IsRequired(false);
            builder.Property(a => a.IsDeleted).IsRequired().HasDefaultValue(false);

            #region SeedData

            builder.HasData(
                new Admin() { Id = 1, Username = "admin", Password = "admin", CreatedAt = DateTime.Now}
                );

            #endregion
        }
    }
}

