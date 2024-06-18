using Core.Application.DTOs;
using Core.Application.Responses;

namespace Core.Application.Requests;

public interface IKListRequest<out TListResponse, TDto> : IKRequest<TListResponse>, IKListQuery
    where TListResponse : IKListResponse<TDto>
    where TDto : IKDto
{
    
}