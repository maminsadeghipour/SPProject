using System;
using App.Domain.Core.RequestAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.DataAccess.Configuration.RequestAgg
{
	public class RequestPictureConfiguration : IEntityTypeConfiguration<RequestPicture>
    {
		public RequestPictureConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<RequestPicture> builder)
        {
            builder.ToTable("RequestPictures");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title).IsRequired(false);
            builder.Property(p => p.PicturePath).IsRequired();
            builder.Property(p => p.IsDeleted).IsRequired().HasDefaultValue(false);

            // Relations

            builder.HasOne(p => p.Request)
                .WithMany(r => r.Pictures)
                .HasForeignKey(p => p.RequestId)
                .OnDelete(DeleteBehavior.NoAction);



        }
    }
}

