using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocketEntities.DataModels.Abstract
{
    public abstract class IdentityEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}