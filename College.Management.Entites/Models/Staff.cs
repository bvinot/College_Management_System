using College.Management.Entities.Enumerations;
using College.Management.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entities.Models
{
    public abstract class Staff : User, IStaff
    {
        public DateTime JoiningDate { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public StaffCategory StaffCategory { get; set; }
        public StaffType StaffType { get; set; }
    }
}
