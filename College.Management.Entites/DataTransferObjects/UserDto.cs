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
    public class UserDto
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "First Name Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [Compare("Password", ErrorMessage = "Password does not Match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Phone Number Required")]
        public long PhoneNumber { get; set; }

        public List<UserRole> UserRoles { get; set; }

        public bool IsActive { get; set; }
    }
}
