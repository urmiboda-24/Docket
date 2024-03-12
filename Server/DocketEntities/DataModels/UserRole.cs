using System.ComponentModel.DataAnnotations.Schema;
using DocketEntities.DataModels.Abstract;

namespace DocketEntities.DataModels
{
    [Table("UserRoles")]
    public class UserRole : AuditEntity<int>
    {
        public int RoleId { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public virtual Role Role { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;

    }
}