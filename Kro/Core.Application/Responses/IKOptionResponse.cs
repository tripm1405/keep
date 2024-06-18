using Core.Application.DTOs;

namespace Core.Application.Responses;

public interface IKOptionResponse<TOptionDto, TValue, TLabel> : IList<TOptionDto>, IKResponse
    where TOptionDto : IKOptionDto<TValue, TLabel>
{
    List<TOptionDto> Options { get; set; }
}