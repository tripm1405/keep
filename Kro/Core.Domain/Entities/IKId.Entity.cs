namespace Core.Domain.Entities;

public interface IKIdEntity : IKEntity
{
    Guid Id { get; set; }
}