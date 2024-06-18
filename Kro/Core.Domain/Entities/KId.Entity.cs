namespace Core.Domain.Entities;

public abstract class KIdEntity : IKIdEntity
{
    public Guid Id { get; set; }
}