using AutoMapper;
using Core.Application.DTOs;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Domain.Entities;
using Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Application.Handlers;

public abstract class KOptionHandler<TOptionRequest, TOptionResponse, TOptionDto, TValue, TLabel, TEntity> : KHandler<TOptionRequest, TOptionResponse, TEntity>
    where TOptionRequest : class, IKOptionRequest<TOptionResponse, TOptionDto, TValue, TLabel>
    where TOptionResponse : class, IKOptionResponse<TOptionDto, TValue, TLabel>, new()
    where TOptionDto : class, IKOptionDto<TValue, TLabel>
    where TEntity : class, IKEntity
{
    public KOptionHandler(IMapper mapper, IKRepository<TEntity> repository) : base(mapper, repository)
    {
    }

    public override async Task<TOptionResponse> Handle(TOptionRequest request, CancellationToken cancellationToken)
    {
        var queryable = Repository.GetQueryable().AsNoTracking();
        
        var entities = await queryable
            .ToListAsync(cancellationToken: cancellationToken);
        
        return new TOptionResponse
        {
            Options = entities.Select(e => Mapper.Map<TEntity, TOptionDto>(e)).ToList(),
        };
    }
}