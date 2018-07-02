using College.Management.Entites;
using College.Management.Entites.DBEntities;
using College.Management.Entites.Models;
using College.Management.Entities;
using College.Management.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.DataProviders
{
    public class CollegeDbContext : DbContext
    {

        //public CollegeDbContext() : base("Data Source=WKWIN5154312;Initial Catalog=CollegeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=False")
        public CollegeDbContext() : base("DB")
        {
            try
            {

                Database.SetInitializer(new DropCreateDatabaseAlways<CollegeDbContext>());
                Database.SetInitializer(new CreateDatabaseIfNotExists<CollegeDbContext>());
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CollegeDbContext>());
                Database.SetInitializer(new CourseInitializer());
                Database.SetInitializer(new UserRolesInitializer());

                Database.Initialize(true);
            }

            catch (Exception ex)
            {
                throw;
            }
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<StudentMarksMapping> StudentSubjectMarksMapping { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<UserRoleMapping> UserRoleMapping { get; set; }
    }
}
