using AutoMapper;
using Core.Application.Requests;
using Core.Domain.Entities;
using Core.Domain.Repositories;
using MediatR;

namespace Core.Application.Handlers;

public class KUpdateHandler<TUpdateRequest, TEntity> : KHandler<TUpdateRequest, TEntity>
    where TUpdateRequest : class, IKUpdateRequest
    where TEntity : class, IKEntity
{
    public KUpdateHandler(IMapper mapper, IKRepository<TEntity> repository) : base(mapper, repository)
    {
    }

    public override async Task<Unit> Handle(TUpdateRequest request, CancellationToken cancellationToken)
    {
        await Repository.UpdateAsync(Mapper.Map<TUpdateRequest, TEntity>(request));
        
        return Unit.Value;
    }
}