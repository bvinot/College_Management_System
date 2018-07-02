using College.Management.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entites.DBEntities
{
    public class UserRole
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int RoleId { get; set; }

        public string Role { get; set; }

        public string Previleges { get; set; }
    }
}
