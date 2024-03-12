using System.ComponentModel.DataAnnotations.Schema;

namespace DocketEntities.DataModels.Abstract
{
    public class AuditEntity<T> : IdentityEntity<T>
    {
        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; }

        public int CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        [ForeignKey(nameof(CreatedBy))]
        public virtual User CreatedByUser { get; set; } = null!;

        [ForeignKey(nameof(UpdatedBy))]
        public virtual User? UpdatedByUser { get; set; } = null!;

        public virtual DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.UtcNow;

        public virtual DateTimeOffset? UpdatedOn { get; set; }

        public virtual DateTimeOffset? DeletedOn { get; set; }
    }
}