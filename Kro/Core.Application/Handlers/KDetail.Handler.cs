using AutoMapper;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Domain.Entities;
using Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Application.Handlers;

public abstract class KDetailHandler<TDetailRequest, TDetailResponse, TEntity> : KHandler<TDetailRequest, TDetailResponse, TEntity>
    where TDetailRequest : class, IKDetailRequest<TDetailResponse>
    where TDetailResponse : class, IKDetailResponse, new()
    where TEntity : class, IKIdEntity
{
    protected KDetailHandler(IMapper mapper, IKRepository<TEntity> repository) : base(mapper, repository)
    {
    }

    public override async Task<TDetailResponse> Handle(TDetailRequest request, CancellationToken cancellationToken)
    {
        var queryable = Repository.GetQueryable().AsNoTracking();
        
        var entity = await queryable
            .FirstOrDefaultAsync(e => e.Id.Equals(request.Id), cancellationToken: cancellationToken);

        if (entity == null) throw new Exception($"{request.Id}");
        
        return Mapper.Map<TEntity, TDetailResponse>(entity);
    }
}