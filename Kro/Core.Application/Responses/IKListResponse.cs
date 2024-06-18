namespace Core.Application.Responses;

public interface IKListResponse<TItemDto> : IKResponse
{
    List<TItemDto> Items { get; set; }
    int Size { get; set; }
    int Page { get; set; }
    int Total { get; set; }
}