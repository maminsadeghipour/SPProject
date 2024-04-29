using System;
using App.Domain.Core.RequestAgg.Entity;
using App.Domain.Core.SkillServeAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DataAccess.Configuration.SkillServeAgg
{
	public class SkillServeConfiguration : IEntityTypeConfiguration<SkillServe>
    {
		public SkillServeConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<SkillServe> builder)
        {
            builder.ToTable("SkillServes");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Title).IsRequired();
            builder.Property(s => s.MinWage).IsRequired();
            builder.Property(s => s.Description).IsRequired();


            builder.Property(s => s.CreatedAt).IsRequired();
            builder.Property(s => s.LastUpdatedAt).IsRequired(false);
            builder.Property(s => s.IsDeleted).IsRequired().HasDefaultValue(false);

            // Relations

            builder.HasOne(s => s.Category)
                .WithMany(c => c.SkillServes)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.Experts)
                .WithMany(e => e.SkillServes);

            builder.HasMany(s => s.Requests)
                .WithOne(r => r.SkillServe)
                .HasForeignKey(r => r.SkillServeId)
                .OnDelete(DeleteBehavior.NoAction);
                
        }
    }
}

