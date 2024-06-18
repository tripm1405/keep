namespace Core.Application.Requests;

public class KDeleteRequest : IKDeleteRequest
{
    public Guid Id { get; set; }
}