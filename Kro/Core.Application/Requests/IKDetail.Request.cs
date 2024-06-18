using Core.Application.Responses;

namespace Core.Application.Requests;

public interface IKDetailRequest<out TResponse> : IKRequest<TResponse>
    where TResponse : class, IKDetailResponse
{
    public Guid Id { get; set; }
}