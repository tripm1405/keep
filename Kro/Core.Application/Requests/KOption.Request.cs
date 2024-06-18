using Core.Application.DTOs;
using Core.Application.Responses;

namespace Core.Application.Requests;

public abstract class KOptionRequest<TOptionResponse, TOptionDto, TValue, TLabel> : IKOptionRequest<TOptionResponse, TOptionDto, TValue, TLabel>
    where TOptionResponse : IKOptionResponse<TOptionDto, TValue, TLabel>
    where TOptionDto : IKOptionDto<TValue, TLabel>
{
    public Guid Id { get; set; }
}