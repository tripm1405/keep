using Core.Application.DTOs;
using Core.Application.Responses;

namespace Core.Application.Requests;

public interface IKOptionRequest<out TOptionResponse, TOptionDto, TValue, TLabel> : IKRequest<TOptionResponse>
    where TOptionResponse : IKOptionResponse<TOptionDto, TValue, TLabel>
    where TOptionDto : IKOptionDto<TValue, TLabel>
{
    
}