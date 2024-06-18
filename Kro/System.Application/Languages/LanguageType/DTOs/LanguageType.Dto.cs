using System.Application.Languages.Language.DTOs;
using Core.Application.DTOs;

namespace System.Application.Languages.LanguageType.DTOs;

public class LanguageTypeDto : KCatalogueDto
{
    public IEnumerable<LanguageDto> Languages { get; set; } = new List<LanguageDto>();
}