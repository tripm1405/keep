using System.Application.Languages.LanguageTranslation.DTOs;
using System.Domain.Languages.Entities;
using AutoMapper;

namespace System.Application.Languages.LanguageTranslation;

public class LanguageTranslationAutoMapper : Profile
{
    public LanguageTranslationAutoMapper()
    {
        CreateMap<LanguageTranslationEntity, LanguageTranslationDto>();
        CreateMap<LanguageTranslationUpsertDto, LanguageTranslationEntity>();
    }
}