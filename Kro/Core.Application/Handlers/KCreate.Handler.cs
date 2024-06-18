using AutoMapper;
using Core.Application.Requests;
using Core.Domain.Entities;
using Core.Domain.Repositories;
using MediatR;

namespace Core.Application.Handlers;

public abstract class KCreateHandler<TCreateRequest, TEntity> : KHandler<TCreateRequest, TEntity>
    where TCreateRequest : class, IKCreateRequest
    where TEntity : class, IKEntity
{
    public KCreateHandler(IMapper mapper, IKRepository<TEntity> repository) : base(mapper, repository)
    {
    }

    public override async Task<Unit> Handle(TCreateRequest request, CancellationToken cancellationToken)
    {
        await Repository.CreateAsync(Mapper.Map<TCreateRequest, TEntity>(request));

        return Unit.Value;
    }
}