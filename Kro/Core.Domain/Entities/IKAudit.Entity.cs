namespace Core.Domain.Entities;

public interface IKAuditEntity : IKIdEntity
{
    DateTime? CreatedAt { get; set; }
    Guid? CreatedBy { get; set; }
    DateTime? LastUpdatedAt { get; set; }
    Guid? LastUpdatedBy { get; set; }
    DateTime? DeletedAt { get; set; }
    Guid? DeletedBy { get; set; }
}