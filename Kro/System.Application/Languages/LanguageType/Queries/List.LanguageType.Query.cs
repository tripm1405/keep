using System.Application.Languages.LanguageType.DTOs;
using System.Domain.Languages.Entities;
using AutoMapper;
using Core.Application.Handlers;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Domain.Repositories;

namespace System.Application.Languages.LanguageType.Queries;

public class ListLanguageTypeQuery
{
    public class Response : KListResponse<LanguageTypeDto>
    {
    }
    
    public class Request : KListRequest<Response, LanguageTypeDto>
    {
    }
    
    public class Handler : KListHandler<Request, Response, LanguageTypeDto, LanguageTypeEntity>
    {
        public Handler(IMapper mapper, IKRepository<LanguageTypeEntity> repository) : base(mapper, repository)
        {
        }
    }
}