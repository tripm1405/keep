using Core.Application.Responses;
using MediatR;

namespace Core.Application.Requests;

public abstract class KRequest<TResponse> : IRequest<TResponse>
    where TResponse : class, IKResponse
{
    
}

public abstract class KRequest : IKRequest
{
    
}