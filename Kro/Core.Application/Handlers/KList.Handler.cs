using AutoMapper;
using Core.Application.DTOs;
using Core.Application.Extensions;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Domain.Entities;
using Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Application.Handlers;

public abstract class KListHandler<TListRequest, TListResponse, TItemDto, TEntity> : KHandler<TListRequest, TListResponse, TEntity>
    where TListRequest : class, IKListRequest<TListResponse, TItemDto> 
    where TListResponse : class, IKListResponse<TItemDto>, new()
    where TItemDto : class, IKDto
    where TEntity : class, IKEntity
{
    public KListHandler(IMapper mapper, IKRepository<TEntity> repository) : base(mapper, repository)
    {
    }

    public override async Task<TListResponse> Handle(TListRequest request, CancellationToken cancellationToken)
    {
        var queryable = Repository.GetQueryable().AsNoTracking();

        var total = await queryable.CountAsync(cancellationToken: cancellationToken);

        queryable = SetIncludes(queryable);
        
        var entities = await queryable
            .Skip(request.GetSkip())
            .Take(request.Size)
            .ToListAsync(cancellationToken: cancellationToken);

        var dTOs = Mapper.Map<List<TEntity>, List<TItemDto>>(entities);
            
        return new TListResponse
        {
            Items = dTOs,
            Size = request.Size,
            Page = request.Page,
            Total = total,
        };
    }
}