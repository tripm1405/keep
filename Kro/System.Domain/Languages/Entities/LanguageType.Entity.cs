using Core.Domain.Entities;

namespace System.Domain.Languages.Entities;

public class LanguageTypeEntity : KCatalogueEntity
{
    public IEnumerable<LanguageTranslationEntity> Languages { get; set; } = new List<LanguageTranslationEntity>();
}