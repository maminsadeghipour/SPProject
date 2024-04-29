using System;
using App.Domain.Core.ExpertAgg.Entity;
using App.Domain.Core.FeedBackAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DataAccess.Configuration.FeebackAgg
{
	public class CustomerFeedbackConfiguration : IEntityTypeConfiguration<CostumerFeedback>
    {
		public CustomerFeedbackConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<CostumerFeedback> builder)
        {
            builder.ToTable("CustomerFeedbacks");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Description).IsRequired();
            builder.Property(c => c.Rate).IsRequired();

            builder.Property(c => c.LastUpdatedAt).IsRequired(false);
            builder.Property(c => c.CreatedAt).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);

            builder.HasOne(c => c.Expert)
                .WithMany(e => e.CostumerFeedbacks)
                .HasForeignKey(c => c.ExpertId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.Customer)
                .WithMany(cu => cu.CostumerFeedbacks)
                .HasForeignKey(c => c.ExpertId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.Request);
              
                
        }
    }
}

