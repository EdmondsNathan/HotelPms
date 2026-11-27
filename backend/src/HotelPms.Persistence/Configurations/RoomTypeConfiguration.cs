using HotelPms.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelPms.Persistence.Configurations;

public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
{
    public void Configure(EntityTypeBuilder<RoomType> builder)
    {
        builder.ToTable("RoomTypes");

        builder.HasKey(rt => rt.Id);

        builder.Property(rt => rt.Id).ValueGeneratedNever();

        builder.Property(rt => rt.Name).IsRequired().HasMaxLength(100);

        builder.Property(rt => rt.Description).IsRequired().HasMaxLength(500);

        builder.Property(rt => rt.MaxOccupancy).IsRequired();
    }
}
