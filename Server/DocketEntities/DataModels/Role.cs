using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DocketEntities.DataModels.Abstract;

namespace DocketEntities.DataModels
{
    [Table("Roles")]
    public class Role : AuditEntity<int>
    {
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public bool IsSystemAdmin { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}