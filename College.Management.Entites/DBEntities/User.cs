using College.Management.Entites.DBEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public long PhoneNumber { get; set; }

        public bool IsActive { get; set; }
    }
}
