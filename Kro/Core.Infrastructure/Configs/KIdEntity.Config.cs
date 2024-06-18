using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Infrastructure.Configs;

public abstract class KIdEntityConfig<TEntity> : IEntityTypeConfiguration<TEntity> 
    where TEntity : class, IKIdEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(x => x.Id);
    }
}