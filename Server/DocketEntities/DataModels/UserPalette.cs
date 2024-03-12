using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DocketCommon.Enums;
using DocketEntities.DataModels.Abstract;

namespace DocketEntities.DataModels
{
    [Table("UserPalettes")]
    public class UserPalette : AuditEntity<int>
    {
        public int UserId { get; set; }

        public int ColorPaletteId { get; set; }

        public DocumentExtensionType ExtensionType { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;

        [ForeignKey(nameof(ColorPaletteId))]
        public virtual ColorPalette ColorPalette { get; set; } = null!;
    }
}