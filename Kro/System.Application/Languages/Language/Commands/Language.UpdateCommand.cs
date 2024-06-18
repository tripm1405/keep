using System.Application.Languages.LanguageTranslation.DTOs;
using System.Domain.Languages.Entities;
using AutoMapper;
using Core.Application.AutoMappers;
using Core.Application.Handlers;
using Core.Application.Requests;
using Core.Domain.Repositories;

namespace System.Application.Languages.Language.Commands;

public class UpdateLanguageCommand
{
    public class Request : KUpdateRequest
    {
        public List<LanguageTranslationUpsertDto> Translations { get; set; }
    }
    
    public class Handler : KUpdateHandler<Request, LanguageEntity>
    {
        public Handler(IMapper mapper, IKRepository<LanguageEntity> repository) : base(mapper, repository)
        {
        }
    }

    public class AutoMapper : KAutoMapper
    {
        public AutoMapper()
        {
            CreateMap<Request, LanguageEntity>();
        }
    }
}