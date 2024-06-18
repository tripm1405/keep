using System.Application.Languages.LanguageType.Commands;
using System.Application.Languages.LanguageType.DTOs;
using System.Application.Languages.LanguageType.Queries;
using System.Domain.Languages.Entities;
using AutoMapper;

namespace System.Application.Languages.LanguageType;

public class LanguageTypeAutoMapper : Profile
{
    public LanguageTypeAutoMapper()
    {
        CreateMap<LanguageTypeEntity, LanguageTypeDto>();
        CreateMap<LanguageTypeEntity, DetailLanguageTypeQuery.Response>();

        CreateMap<CreateLanguageTypeCommand.Request, LanguageTypeEntity>();
        CreateMap<UpdateLanguageTypeCommand.Request, LanguageTypeEntity>();
    }
}