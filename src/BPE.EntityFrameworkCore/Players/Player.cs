using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace BPE.Players
{
    [Table("Players")]
    public class Player : AuditableEntity
    {
        public string LastName { set; get; }
        public string FirstName { set; get; }
        public int LoginCount { set; get; }
        public DateTime? BirthdayDate { set; get; }
    }
}
