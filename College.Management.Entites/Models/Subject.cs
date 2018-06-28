using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entities.Models
{
    public class Subject
    {
        int SubjectId { get; set; }

        string Name { get; set; }

        Course RelatedCourse { get; set; }

        int CreditPoints { get; set; }
    }
}
