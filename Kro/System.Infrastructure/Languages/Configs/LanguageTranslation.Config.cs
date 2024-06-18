using System.Domain.Languages.Entities;
using Core.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace System.Infrastructure.Languages.Configs;

public class LanguageTranslationConfig : IEntityTypeConfiguration<LanguageTranslationEntity>
{
    public void Configure(EntityTypeBuilder<LanguageTranslationEntity> builder)
    {
        builder.ToTable(nameof(LanguageTranslationEntity), ConfigConstant.Schema.System);
        
        builder.HasKey(x => new { x.RootId, x.TypeId });

        builder.Property(x => x.Content)
            .IsRequired()
            .HasMaxLength(512);

        builder.HasOne(x => x.Root)
            .WithMany(x => x.Translations)
            .HasForeignKey(x => x.RootId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Type)
            .WithMany(x => x.Languages)
            .HasForeignKey(x => x.TypeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}