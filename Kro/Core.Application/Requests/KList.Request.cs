using Core.Application.DTOs;
using Core.Application.Responses;

namespace Core.Application.Requests;

public abstract class KListRequest<TListResponse, TDto> : IKListRequest<TListResponse, TDto>
    where TListResponse : class, IKListResponse<TDto>
    where TDto: class, IKDto
{
    public int Size { get; set; } = 10;
    public int Page { get; set; } = 1;
}