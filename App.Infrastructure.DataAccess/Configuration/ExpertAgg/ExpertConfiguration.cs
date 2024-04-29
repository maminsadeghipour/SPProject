using System;
using App.Domain.Core.ExpertAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DataAccess.Configuration.ExpertAgg
{
	public class ExpertConfiguration : IEntityTypeConfiguration<Expert>
    {
		public ExpertConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Expert> builder)
        {
            builder.ToTable("Experts");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName).IsRequired();
            builder.Property(e => e.LastName).IsRequired();
            builder.Property(e => e.PhoneNumber).IsRequired();
            builder.Property(e => e.Username).IsRequired();
            builder.Property(e => e.Password).IsRequired();
            builder.Property(e => e.BankAccount).IsRequired();
            builder.Property(e => e.RegisteredAt).IsRequired();

            builder.Property(e => e.LastUpdatedAt).IsRequired(false);
            builder.Property(e => e.CreatedAt).IsRequired();
            builder.Property(e => e.IsDeleted).IsRequired().HasDefaultValue(false);


            // Relations 
            builder.HasMany(e => e.SkillServes)
                .WithMany(s => s.Experts);
                
            builder.HasMany(e => e.Bids)
                .WithOne(b => b.Expert)
                .HasForeignKey(b=>b.ExpertId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(e => e.CostumerFeedbacks)
                .WithOne(c=>c.Expert)
                .HasForeignKey(c=> c.ExpertId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

