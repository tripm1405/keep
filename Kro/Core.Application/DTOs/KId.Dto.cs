namespace Core.Application.DTOs;

public abstract class KIdDto : KDto, IKIdDto
{
    public Guid Id { get; set; }
}