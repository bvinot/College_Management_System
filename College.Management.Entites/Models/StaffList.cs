using College.Management.Entities.Enumerations;
using College.Management.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entities.Models
{
    public class Admin : Staff
    {
        public Admin()
        {
            StaffType = StaffType.Administration;
        }

        public bool IsAdmin { get { return true; } }
    }

    public class Lecturer : Staff
    {
        public Lecturer()
        {
            StaffType = StaffType.Teaching;
        }
    }

    public class Supervisor : Staff
    {
        public Supervisor()
        {
            StaffType = StaffType.Supervisor;
        }
    }

    public class HelpDeskStaff : Staff
    {
        public HelpDeskStaff()
        {
            StaffType = StaffType.Helpdesk;
        }
    }
}
