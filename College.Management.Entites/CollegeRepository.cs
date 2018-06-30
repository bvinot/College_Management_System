using College.Management.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entites
{
    public sealed class CollegeRepository
    {
        readonly CollegeDbContext context = null;

        private static readonly Lazy<CollegeRepository> lazy = new Lazy<CollegeRepository>(() => new CollegeRepository());

        public static CollegeRepository Instance { get { return lazy.Value; } }

        private CollegeRepository()
        {
            context = new CollegeDbContext();
        }
    }
}
