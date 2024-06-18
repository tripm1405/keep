using System.Application.Languages.LanguageType.DTOs;
using System.Domain.Languages.Entities;
using AutoMapper;
using Core.Application.DTOs;
using Core.Application.Handlers;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace System.Application.Languages.LanguageType.Queries;

public class OptionLanguageTypeQuery
{
    public class Response : KOptionResponse<LanguageTypeOptionDto, Guid, string>
    {
        
    }

    public class Request : IKOptionRequest<Response, LanguageTypeOptionDto, Guid, string>
    {
        
    }
    
    public class Handler : KOptionHandler<Request, Response, LanguageTypeOptionDto, Guid, string, LanguageTypeEntity>
    {
        public Handler(IMapper mapper, IKRepository<LanguageTypeEntity> repository) : base(mapper, repository)
        {
        }

        public override async Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            var queryable = Repository.GetQueryable().AsNoTracking();
        
            var entities = await queryable
                .ToListAsync(cancellationToken: cancellationToken);
        
            return new Response
            {
                Options = entities.Select(e => new LanguageTypeOptionDto
                {
                    Value = e.Id,
                    Label = e.Name,
                }).ToList(),
            };
            
        }
    }
}