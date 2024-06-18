using System.Application.Languages.Language.DTOs;
using System.Application.Languages.LanguageType.DTOs;
using System.Domain.Languages.Entities;
using AutoMapper;

namespace System.Application.Languages.Language;

public class LanguageAutoMapper : Profile
{
    public LanguageAutoMapper()
    {
        CreateMap<LanguageTranslationEntity, LanguageDto>();
        CreateMap<LanguageEntity, LanguageDto>();
        CreateMap<LanguageTypeEntity, LanguageTypeDto>();
    }
}