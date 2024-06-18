using Core.Application.Responses;
using MediatR;

namespace Core.Application.Requests;

public interface IKRequest<out TResponse> : IRequest<TResponse>
    where TResponse : IKResponse
{
    
}

public interface IKRequest : IRequest<Unit>
{
    
}