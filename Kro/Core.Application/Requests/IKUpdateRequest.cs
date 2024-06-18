namespace Core.Application.Requests;

public interface IKUpdateRequest : IKRequest
{
    Guid Id { get; set; }
}