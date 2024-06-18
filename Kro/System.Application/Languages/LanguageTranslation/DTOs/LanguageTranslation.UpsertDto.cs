namespace System.Application.Languages.LanguageTranslation.DTOs;

public class LanguageTranslationUpsertDto
{
    public Guid? RootId { get; set; }
    public Guid TypeId { get; set; }
    public string Content { get; set; }
}