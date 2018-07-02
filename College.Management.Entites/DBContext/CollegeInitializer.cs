using College.Management.DataProviders;
using College.Management.Entites.DBEntities;
using College.Management.Entities.Enumerations;
using College.Management.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.DataProviders
{
    public class CourseInitializer : DropCreateDatabaseIfModelChanges<CollegeDbContext>
    {
        protected override void Seed(CollegeDbContext context)
        {
            var courses = new List<Course>
            {
                new Course{CourseId = 1,Name="Aerospace Engineering"},
                new Course{CourseId = 2,Name="Computer Science Engineering"},
                new Course{CourseId = 3,Name="Electrical Engineering"},
                new Course{CourseId = 4,Name="Civil Engineering"},
                new Course{CourseId = 5,Name="Electronics and Communication Engineering"},
            };

            var subjects = new List<Subject>
            {
                new Subject{Name="Aerodynamics", RelatedCourseId=1, CreditPoints=4},
                new Subject{Name="Aerospace Propulsion", RelatedCourseId=1, CreditPoints=3},
                new Subject{Name="Data Structures", RelatedCourseId=2, CreditPoints=4},
                new Subject{Name="Distributed Systems", RelatedCourseId=2, CreditPoints=4},
                new Subject{Name="Power Control", RelatedCourseId=3, CreditPoints=4},
                new Subject{Name="Digital Signal Processing", RelatedCourseId=3, CreditPoints=3},
                new Subject{Name="Fluid Mechanics", RelatedCourseId=4, CreditPoints=4},
                new Subject{Name="Reinforced Concrete Structures", RelatedCourseId=4, CreditPoints=4},
                new Subject{Name="Digital Communication", RelatedCourseId=5, CreditPoints=4},
                new Subject{Name="Mixed Mode VSLI Design", RelatedCourseId=5, CreditPoints=3}
            };

            context.Courses.AddRange(courses);

            context.Subjects.AddRange(subjects);

            base.Seed(context);
        }
    }

    public class UserRolesInitializer : DropCreateDatabaseIfModelChanges<CollegeDbContext>
    {
        protected override void Seed(CollegeDbContext context)
        {
            var roles = new List<UserRole>
            {
              new UserRole{Role = "Admin", Previleges=$"{Operations.Admin},{Operations.Courses},{Operations.Staffs},{Operations.Students}"},
              new UserRole{Role = "IT", Previleges=$"{Operations.Admin},{Operations.Staffs},{Operations.Students}"},
              new UserRole{Role = "Helpdesk", Previleges=$"{Operations.Staffs}"},
              new UserRole{Role = "Student", Previleges=$"{Operations.Students}"}
            };

            context.UserRoles.AddRange(roles);

            base.Seed(context);
        }
    }
}
