using College.Management.Entities;
using College.Management.Entities.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entites.DBEntities
{
    public class Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int AuditId { get; set; }

        public DateTime AuditTime { get; set; }

        public string Action  { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
