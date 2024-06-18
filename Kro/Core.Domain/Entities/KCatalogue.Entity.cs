namespace Core.Domain.Entities;

public abstract class KCatalogueEntity : KIdEntity, IKCatalogueEntity
{
    public string Code { get; set; }
    public string Name { get; set; }
    public bool IsDefault { get; set; }
}