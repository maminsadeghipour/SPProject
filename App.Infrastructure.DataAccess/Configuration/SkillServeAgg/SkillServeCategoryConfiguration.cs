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


            // Seed data

            #region SeedData
            builder.HasData(
                new SkillServeCategory() { Id = 1, Title = "نظافت", Description = "ارئه خدمات مربوط به نظافت منزل و ...", CreatedAt = DateTime.Now },

                new SkillServeCategory() { Id = 2, Title = "ساختمان", Description = "خدمات مربوط به ساختمان و..", CreatedAt = DateTime.Now },

                new SkillServeCategory() { Id = 3, Title = "تعمیرات اشیا", Description = "تعمیرات یخچال و ...", CreatedAt = DateTime.Now },

                new SkillServeCategory() { Id = 4, Title = "خودرو", Description = "خدمات مربوط به خودرو تعمیرات و ...", CreatedAt = DateTime.Now },

                new SkillServeCategory() { Id = 5, Title = "الکترونیک", Description = "تعمیرات موبایل و تجهیزات الکترونیک", CreatedAt = DateTime.Now },

                new SkillServeCategory() { Id = 6, Title = "حمل و نقل", Description = "خدمات مربوط به اسباب کشی ", CreatedAt = DateTime.Now }
                );

            #endregion

        }
    }
}

