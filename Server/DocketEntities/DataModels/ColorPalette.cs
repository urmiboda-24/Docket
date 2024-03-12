using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using DocketEntities.DataModels.Abstract;

namespace DocketEntities.DataModels
{
    [Table("ColorPalettes")]
    public class ColorPalette : AuditEntity<int>
    {
        public string Name { get; set; } = null!;
    }
}