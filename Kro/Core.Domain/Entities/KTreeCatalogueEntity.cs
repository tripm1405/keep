namespace Core.Domain.Entities;

public abstract class KTreeCatalogueEntity: KCatalogueEntity, IKTreeCatalogueEntity
{
    public Guid? SuperId { get; set; }
    public IKTreeCatalogueEntity Super { get; set; }
    public IEnumerable<IKTreeCatalogueEntity> Subs { get; set; }
}