using System.Domain.Languages.Entities;
using Core.Infrastructure.Configs;
using Core.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace System.Infrastructure.Languages.Configs;

public class LanguageTypeConfig : KIdCatalogueConfig<LanguageTypeEntity>
{
    public override void Configure(EntityTypeBuilder<LanguageTypeEntity> builder)
    {
        base.Configure(builder);
        
        builder.ToTable(nameof(LanguageTypeEntity), ConfigConstant.Schema.System);
    }
}