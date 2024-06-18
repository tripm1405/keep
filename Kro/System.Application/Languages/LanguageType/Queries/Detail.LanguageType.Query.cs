using System.Application.Languages.LanguageType.DTOs;
using System.Domain.Languages.Entities;
using AutoMapper;
using Core.Application.Handlers;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Domain.Repositories;

namespace System.Application.Languages.LanguageType.Queries;

public class DetailLanguageTypeQuery
{
    public class Response : LanguageTypeDto, IKDetailResponse
    {
        public Guid RootId { get; set; }
        public Guid TypeId { get; set; }
        public string Content { get; set; }
    }

    public class Request : KDetailRequest<Response>
    {
        
    }
    
    public class Handler : KDetailHandler<Request, Response, LanguageTypeEntity>
    {
        public Handler(IMapper mapper, IKRepository<LanguageTypeEntity> repository) : base(mapper, repository)
        {
        }
    }
}