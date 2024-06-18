using AutoMapper;
using Core.Application.Requests;
using Core.Domain.Entities;
using Core.Domain.Repositories;
using MediatR;

namespace Core.Application.Handlers;

public class KDeleteHandler<TRequest, TEntity> : KHandler<TRequest, TEntity>
    where TRequest : class, IKDeleteRequest
    where TEntity : class, IKEntity
{
    public KDeleteHandler(IMapper mapper, IKRepository<TEntity> repository) : base(mapper, repository)
    {
    }

    public override async Task<Unit> Handle(TRequest request, CancellationToken cancellationToken)
    {
        await Repository.DeleteAsync(Mapper.Map<TRequest, TEntity>(request));
        
        return Unit.Value;
    }
}