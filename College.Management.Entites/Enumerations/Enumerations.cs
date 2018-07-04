using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entities.Enumerations
{
    public enum StaffCategory
    {
        Permanent,
        Contract
    }

    public enum StaffType
    {
        Teaching,
        Administration,
        Helpdesk,
        SanitoryWork,
        Supervisor
    }

    public enum Grade
    {
        S = 10, A = 9, B = 8, C = 7, D = 6, E = 5, F = 0
    }

    public enum Operations
    {
        Admin,
        Courses,
        Students,
        Staffs
    }

    public enum AuditAction
    {
        Login,
        Logout,
        AddedUser,
        CheckedResult,
        Other
    }
}
