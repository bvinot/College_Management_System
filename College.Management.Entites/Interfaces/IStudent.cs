using College.Management.Entities.Enumerations;
using College.Management.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entities.Interfaces
{
    interface IStudent
    {
        List<Subject> Subjects { get; set; }

        Tuple<Subject, Grade> Marks { get; set; }

        int Rank { get; set; }
    }
}
