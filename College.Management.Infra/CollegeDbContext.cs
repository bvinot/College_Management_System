using College.Management.Entities;
using College.Management.Entities.Models;
using College.Management.Infra;
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
        public CollegeDbContext() : base("Data Source=WKWIN5154312;Initial Catalog=CollegeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=False")
        {
            try
            {
                var abc = this.Database.Connection.ConnectionString;

                Database.SetInitializer(new CreateDatabaseIfNotExists<CollegeDbContext>());
                var init = new CollegeInitializer();
                Database.SetInitializer(init);

                Database.Initialize(true);
            }

            catch(Exception ex)
            {
                var abc = ex;
            }
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Course> Courses { get; set; }

    }
}
