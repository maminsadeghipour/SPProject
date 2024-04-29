using System;
using App.Domain.Core.SkillServeAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DataAccess.Configuration.SkillServeAgg
{
	public class SkillServeCategoryConfiguration : IEntityTypeConfiguration<SkillServeCategory>
    {
		public SkillServeCategoryConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<SkillServeCategory> builder)
        {
            builder.ToTable("SkillServeCategories");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title).IsRequired();
            builder.Property(c => c.Description).IsRequired();

            builder.Property(c => c.CreatedAt).IsRequired();
            builder.Property(c => c.LastUpdatedAt).IsRequired(false);
            builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);


            // Relation

            builder.HasMany(c => c.SkillServes)
                .WithOne(s => s.Category)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
                
        }
    }
}

