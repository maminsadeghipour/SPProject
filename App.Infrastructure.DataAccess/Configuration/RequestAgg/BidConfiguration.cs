using System;
using App.Domain.Core.FeedBackAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DataAccess.Configuration.RequestAgg
{
	public class BidConfiguration : IEntityTypeConfiguration<Bid>
    {
		public BidConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Bid> builder)
        {
            builder.ToTable("Bids");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Price).IsRequired();
            builder.Property(b => b.Description).IsRequired(false);
            builder.Property(b => b.FulfillmentDate).IsRequired();

            builder.Property(b => b.IsDeleted).IsRequired().HasDefaultValue(false);
            builder.Property(b => b.CreatedAt).IsRequired();
            builder.Property(b => b.LastUpdatedAt).IsRequired(false);

            builder.HasOne(b => b.Request)
                .WithMany(r => r.Bids)
                .HasForeignKey(b => b.RequestId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(b => b.Expert)
                .WithMany(e => e.Bids)
                .HasForeignKey(b => b.ExpertId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}

