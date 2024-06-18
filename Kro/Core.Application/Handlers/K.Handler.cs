using AutoMapper;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Domain.Entities;
using Core.Domain.Repositories;
using MediatR;

namespace Core.Application.Handlers;

public abstract class KHandler<TRequest, TResponse, TEntity> : IRequestHandler<TRequest, TResponse>
    where TRequest : class, IRequest<TResponse>
    where TResponse : class, IKResponse, new()
    where TEntity : class, IKEntity
{
    protected readonly IMapper Mapper;
    protected readonly IKRepository<TEntity> Repository;

    protected KHandler(IMapper mapper, IKRepository<TEntity> repository)
    {
        Mapper = mapper;
        Repository = repository;
    }

    public virtual Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new TResponse());
    }

    public virtual IQueryable<TEntity> SetIncludes(IQueryable<TEntity> queryable)
    {
        return queryable;
    }
}

public abstract class KHandler<TRequest, TEntity> : IRequestHandler<TRequest, Unit>
    where TRequest : class, IKRequest
    where TEntity : class, IKEntity
{
    protected readonly IMapper Mapper;
    protected readonly IKRepository<TEntity> Repository;

    protected KHandler(IMapper mapper, IKRepository<TEntity> repository)
    {
        Mapper = mapper;
        Repository = repository;
    }

    public virtual Task<Unit> Handle(TRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(Unit.Value);
    }
}