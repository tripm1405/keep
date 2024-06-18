using Core.Application.DTOs;

namespace Core.Application.Responses;

public abstract class KOptionResponse<TOptionDto, TValue, TLabel> : List<TOptionDto>, IKOptionResponse<TOptionDto, TValue, TLabel>
    where TOptionDto: IKOptionDto<TValue, TLabel>
{
    public List<TOptionDto> Options { get; set; }
}