using System.Application.Languages.LanguageTranslation.DTOs;
using System.Domain.Languages.Entities;
using AutoMapper;
using Core.Application.AutoMappers;
using Core.Application.DTOs;
using Core.Application.Extensions;
using Core.Application.Handlers;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace System.Application.Languages.Language.Queries;

public class LanguageListQuery
{
    public class ListDto : KDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public LanguageTranslationDto Default { get; set; }
    }
    
    public class Response : KListResponse<ListDto>
    {
        
    }
    
    public class Request : KListRequest<Response, ListDto>
    {
        
    }
    
    public class Handler : KListHandler<Request, Response, ListDto, LanguageEntity>
    {
        public Handler(IMapper mapper, IKRepository<LanguageEntity> repository) : base(mapper, repository)
        {
        }

        public override IQueryable<LanguageEntity> SetIncludes(IQueryable<LanguageEntity> queryable)
        {
            queryable
                .Include(x => x.Translations);
            
            return queryable;
        }
    }
    
    public class AutoMapper : KAutoMapper
    {
        public AutoMapper()
        {
            CreateMap<LanguageEntity, ListDto>()
                .ForMember(x => x.Default, opt => opt.MapFrom(dest => dest.Translations.FirstOrDefault(x => x.Type.IsDefault)));
        }
    }
}