using AutoMapper;
using College.Management.DataProviders;
using College.Management.Entites.DBEntities;
using College.Management.Entities;
using College.Management.Entities.DataTransferObjects;
using College.Management.Entities.Enumerations;
using College.Management.Entities.Models;
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
            Mapper.Initialize(x => {
                x.CreateMap<User, UserDto>();
                x.CreateMap<Course, CourseDto>();
            });


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
            var lUser = context.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);

            if (lUser == null)
                return null;

            var dtoUser = Mapper.Map<User, UserDto>(lUser);

            var userRoles = from roles in context.UserRoles
                            join urMapping in context.UserRoleMapping on roles.RoleId equals urMapping.RoleId
                            select roles;


            dtoUser.UserRoles = userRoles?.ToList();

            var prev = string.Join(",", dtoUser?.UserRoles?.Select(x => x.Previleges))?.Split(',')?.Distinct()?.ToList();

            dtoUser.Previleges = prev;

            SaveAudit(dtoUser.UserId, $"by {dtoUser.Email}", AuditAction.Login);

            return dtoUser;
        }

        public int RegisterUser(UserDto user, int requestedBy)
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

            var result = SaveAudit(requestedBy, u.FirstName + " " + u.LastName, AuditAction.AddedUser);

            return result;
        }

        public int SaveAudit(int userId, string desc, AuditAction action)
        {
            context.Audit.Add(new Audit { AuditTime = DateTime.Now, Action = $"{action.ToString()} : {desc}", UserId = userId });

            return context.SaveChanges();
        }

        public List<Audit> GetAuditDetails(int userId)
        {
            return context.Audit.Where(x => x.UserId == userId).OrderByDescending(x => x.AuditId).ToList();

        }

        public List<CourseDto> GetAllCourses()
        {
            var cs = context.Courses.ToList();

            var courses = cs.Select(x => Mapper.Map<CourseDto>(x)).ToList();

            var subjects = context.Subjects;

            if (courses.Any())
            {
                courses.ToList().ForEach(c =>
                {

                    var subjectList = subjects.Where(s => s.RelatedCourseId == c.CourseId).Select(x => x.Name).ToList();

                    c.Subjects = subjectList;
                });

            }

            return courses;
        }
    }
}
