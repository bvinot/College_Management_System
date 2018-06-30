using College.Management.Entities.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entities.Interfaces
{
    public interface IStaff
    {
        DateTime JoiningDate { get; set; }

        int Salary { get; set; }

        StaffCategory StaffCategory { get; set; }

        StaffType StaffType { get; set; }

        bool IsAdmin { get; set; }
    }
}
