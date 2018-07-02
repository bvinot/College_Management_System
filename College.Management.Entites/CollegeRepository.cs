using College.Management.DataProviders;
using College.Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entites
{
    public sealed class CollegeRepository
    {
        readonly CollegeDbContext context;

        private static readonly Lazy<CollegeRepository> lazy = new Lazy<CollegeRepository>(() => new CollegeRepository());

        public static CollegeRepository Instance { get { return lazy.Value; } }

        private CollegeRepository()
        {
            context = new CollegeDbContext();
        }

        public void Initialize()
        {

        }

        public List<string> GetUserRoles()
        {
            return context.UserRoles.Select(x => x.Role).ToList();
        }

        public UserDto Login(UserDto user)
        {
           var lUser =  context.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);

            return null;
        }

        public int RegisterUser(UserDto user)
        {
            var u = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber,
                IsActive = true
            };
            context.Users.Add(u);

            var result  = context.SaveChanges();

            return result;
        }
    }
}
