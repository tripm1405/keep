namespace Core.Application.Requests;

public abstract class KUpdateRequest : IKUpdateRequest
{
    public Guid Id { get; set; }
}