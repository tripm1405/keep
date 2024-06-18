using System.Domain.Languages.Entities;
using Core.Infrastructure.Configs;
using Core.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace System.Infrastructure.Languages.Configs;

public class LanguageConfig : KIdEntityConfig<LanguageEntity>
{
    public override void Configure(EntityTypeBuilder<LanguageEntity> builder)
    {
        base.Configure(builder);
        
        builder.ToTable(nameof(LanguageEntity), ConfigConstant.Schema.System);
        
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Code)
            .IsRequired()
            .HasMaxLength(ConfigConstant.Code.MaxLength);
    }
}