using Core.Domain.Entities;
using Core.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Infrastructure.Configs;

public class KIdCatalogueConfig<TEntity> : KIdEntityConfig<TEntity> 
    where TEntity : class, IKCatalogueEntity
{
    public override void Configure(EntityTypeBuilder<TEntity> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Code)
            .IsRequired()
            .HasMaxLength(ConfigConstant.Code.MaxLength);
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(256);
        
        builder.Property(x => x.IsDefault)
            .IsRequired()
            .HasDefaultValue(false);
    }
}