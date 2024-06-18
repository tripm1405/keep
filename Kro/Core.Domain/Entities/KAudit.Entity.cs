namespace Core.Domain.Entities;

public abstract class KAuditEntity : KIdEntity, IKAuditEntity
{
    public DateTime? CreatedAt { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime? LastUpdatedAt { get; set; }
    public Guid? LastUpdatedBy { get; set; }
    public DateTime? DeletedAt { get; set; }
    public Guid? DeletedBy { get; set; }
}