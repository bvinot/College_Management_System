using College.Management.Entities;
using College.Management.Entities.Enumerations;
using College.Management.Entities.Interfaces;
using College.Management.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entites.Models
{
    public class Student : User, IStudent
    {
        public List<Subject> Subjects { get; set; }
        public Tuple<Subject, Grade> Marks { get; set; }
        public int Rank { get; set; }
    }
}
