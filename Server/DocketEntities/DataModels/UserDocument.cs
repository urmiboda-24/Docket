using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DocketCommon.Enums;
using DocketEntities.DataModels.Abstract;

namespace DocketEntities.DataModels
{
    [Table("UserDocument")]
    public class UserDocument : AuditEntity<int>
    {
        public int UserPaletteId { get; set; }
        public string Path { get; set; } = null!;

        [StringLength(256)]
        public string? Note { get; set; }

        public DocumentExtensionType ExtensionType { get; set; }

        [ForeignKey(nameof(UserPaletteId))]
        public virtual UserPalette UserPalette { get; set; } = null!;
    }
}