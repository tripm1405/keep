using Core.Application.Responses;
using MediatR;

namespace Core.Application.Requests;

public abstract class KDetailRequest<TResponse> : IKDetailRequest<TResponse>
    where TResponse : class, IKDetailResponse
{
    public Guid Id { get; set; }
}