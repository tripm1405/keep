namespace Core.Domain.Entities;

public interface IKCatalogueEntity : IKIdEntity
{
    string Code { get; set; }
    string Name { get; set; }
    bool IsDefault { get; set; }
}