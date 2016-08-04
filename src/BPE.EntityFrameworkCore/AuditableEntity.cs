using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace BPE
{
    public class AuditableEntity : Entity, IHasCreationTime, IHasModificationTime
    {
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public AuditableEntity()
        {
            CreationTime = Clock.Now;
        }
    }
}
