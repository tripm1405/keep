using Core.Domain.Entities;

namespace System.Domain.Languages.Entities;

public class LanguageEntity : KIdEntity
{
    Guid Id { get; set; }
    public string Code { get; set; }
}