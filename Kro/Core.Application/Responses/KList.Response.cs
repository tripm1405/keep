using Core.Application.DTOs;

namespace Core.Application.Responses;

public abstract class KListResponse<TDto> : KResponse, IKListResponse<TDto>
    where TDto: class, IKDto
{
    public List<TDto> Items { get; set; } = new();
    public int Size { get; set; } = 10;
    public int Page { get; set; } = 1;
    public int Total { get; set; } = 0;
}