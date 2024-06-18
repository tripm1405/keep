namespace Core.Application.DTOs;

public interface IKCatalogueDto : IKIdDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public bool Default { get; set; }
}