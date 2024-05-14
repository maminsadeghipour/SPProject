using System;
using App.Domain.Core.RequestAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DataAccess.Configuration.RequestAgg
{
	public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
		public RequestConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.ToTable("Requests");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Title).IsRequired();
            builder.Property(r => r.Description).IsRequired();
            builder.Property(r => r.RequestState).IsRequired();
            builder.Property(r => r.CreatedAt).IsRequired();
            builder.Property(r => r.LastUpdatedAt).IsRequired(false);
            builder.Property(r => r.IsDeleted).IsRequired().HasDefaultValue(false);
            builder.Property(r => r.AcceptedBidId).IsRequired(false);





            // Relations

            

            builder.HasOne(r => r.Customer)
                .WithMany(c => c.Requests)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(r => r.Bids)
                .WithOne(b => b.Request)
                .HasForeignKey(b => b.RequestId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(r => r.Pictures)
                .WithOne(p => p.Request)
                .HasForeignKey(p => p.RequestId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(r => r.SkillServe)
                .WithMany(s => s.Requests)
                .HasForeignKey(r => r.SkillServeId)
                .OnDelete(DeleteBehavior.NoAction);

            


        }
    }
}

