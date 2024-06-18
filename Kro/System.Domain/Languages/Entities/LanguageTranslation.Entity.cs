using Core.Domain.Entities;

namespace System.Domain.Languages.Entities;

public class LanguageTranslationEntity : IKEntity
{
    public Guid RootId { get; set; }
    public Guid TypeId { get; set; }
    public string Content { get; set; }
    
    public LanguageEntity Root { get; set; }
    public LanguageTypeEntity Type { get; set; }
}