namespace Core.Application.DTOs;

public interface IKOptionDto<TValue, TLabel>
{
    public TValue Value { get; set; }
    public TLabel Label { get; set; }
}