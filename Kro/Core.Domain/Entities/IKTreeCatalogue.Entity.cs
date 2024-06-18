namespace Core.Domain.Entities;

public interface IKTreeCatalogueEntity : IKCatalogueEntity
{
    Guid? SuperId { get; set; }
    
    IKTreeCatalogueEntity Super { get; set; }
    IEnumerable<IKTreeCatalogueEntity> Subs { get; set; }
}