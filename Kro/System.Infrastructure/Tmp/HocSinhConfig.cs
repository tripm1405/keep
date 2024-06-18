using System.Domain.Tmp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace System.Infrastructure.Tmp;

public class HocSinhConfig : IEntityTypeConfiguration<HocSinh> 
{
    public void Configure(EntityTypeBuilder<HocSinh> builder)
    {
        builder.ToTable("HocSinh");
        
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(256);

        builder.HasOne(x => x.Lop)
            .WithMany(x => x.HocSinhs)
            .HasForeignKey(x => x.LopId);
    }
}