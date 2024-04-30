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


            // Seed Data
            #region SeedData
            builder.HasData(
                new SkillServe() { Id = 1, Title = "نظافت منزل", Description = "نظافت منزل با بهترین امکانات", CreatedAt = DateTime.Now, CategoryId = 1 , MinWage = 400000 },
                new SkillServe() { Id = 2, Title = "قالی شویی", Description = "قالی های خود را به ما بسپارید", CreatedAt = DateTime.Now, CategoryId = 1 , MinWage = 300000},

                new SkillServe() { Id = 3, Title = "سرمایش و گرمایش", Description = "سردته؟ با یه درخواست سیستم گرمایشتو درست کن", CreatedAt = DateTime.Now, CategoryId = 2 , MinWage = 500000 },
                new SkillServe() { Id = 4, Title = "تعمیرات ساختمان", Description = "خسته شدی از اینکه ساختمانت درست نیست راه حلش پیش ماست", CreatedAt = DateTime.Now, CategoryId = 2 , MinWage = 300000 },

                new SkillServe() { Id = 5, Title = "تعمیرات یخچال", Description = "دیگه نگران خراب شدن یخچالت نباش", CreatedAt = DateTime.Now, CategoryId = 3 , MinWage =400000 },
                new SkillServe() { Id = 6, Title = "تعمیرات ماشین لباس شویی", Description = "ماشین لباسشوییت لباساتو خوب تمیز نمیکنه ؟ درخواست بده", CreatedAt = DateTime.Now, CategoryId = 3 , MinWage = 300000},

                new SkillServe() { Id = 7, Title = "تعمیرات خودرو", Description = "تعمیر کارا ماشینتو جواب کردن ؟ اینجا درستش کن ", CreatedAt = DateTime.Now, CategoryId = 4  , MinWage = 600000 },
                new SkillServe() { Id = 8, Title = "کارواش", Description = "با همسرت سره کثیفی ماشین دعواتون شده ؟ اشکال نداره ما براتون مشکلتونو حل میکنیم", CreatedAt = DateTime.Now, CategoryId = 4 , MinWage = 150000},

                new SkillServe() { Id = 9, Title = "تعمیرات موبایل", Description = "دیگه اگه موبایلت درست کار نکنه چه جوری می خوای زندگی کنی", CreatedAt = DateTime.Now, CategoryId = 5 , MinWage =600000 },
                new SkillServe() { Id = 10, Title = "تعیرات لپ تاپ", Description = "حوصله نداری تا مغازه بری ما میاییم پیشت", CreatedAt = DateTime.Now, CategoryId = 5 , MinWage = 500000},

                new SkillServe() { Id = 11, Title = "سرویس بسته بندی", Description = "می خوای نقل مکان کنی ؟ ما برات  بسته  بندی  و انجام میدیم", CreatedAt = DateTime.Now, CategoryId = 6 , MinWage = 200000 },
                new SkillServe() { Id = 12, Title = "اسباب کشی", Description = "می خوای نقل مکان کنی ؟ ما برات انجام میدیم", CreatedAt = DateTime.Now, CategoryId = 6 , MinWage = 700000 }
                );



            #endregion

        }
    }
}

