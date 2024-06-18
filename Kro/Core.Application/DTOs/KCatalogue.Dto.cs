namespace Core.Application.DTOs;

public abstract class KCatalogueDto: KIdDto, IKCatalogueDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public bool Default { get; set; }
}