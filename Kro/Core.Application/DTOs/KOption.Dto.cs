namespace Core.Application.DTOs;

public abstract class KOptionDto<TValue, TLabel> : IKOptionDto<TValue, TLabel>
{
    public TValue Value { get; set; }
    public TLabel Label { get; set; }
}