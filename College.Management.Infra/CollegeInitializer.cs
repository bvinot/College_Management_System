using College.Management.DataProviders;
using College.Management.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Infra
{
    public class CollegeInitializer : DropCreateDatabaseIfModelChanges<CollegeDbContext>
    {
        protected override void Seed(CollegeDbContext context)
        {

            var subjects = new List<Subject>
            {
                new Subject("Maths",1,4)
            };

            context.Subjects.AddRange(subjects);

            base.Seed(context);
        }
    }
}
