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
    public class UserRoleMapping
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int MappingId { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public UserRole UserRole { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
