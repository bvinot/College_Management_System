using College.Management.Entities.Enumerations;
using College.Management.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entities.Models.Dtos
{
    public abstract class StaffDto : UserDto, IStaff
    {
        public int StaffId { get; set; }

        public DateTime JoiningDate { get; set; }

        public string Department { get; set; }

        public int Salary { get; set; }

        public StaffCategory StaffCategory { get; set; }

        public StaffType StaffType { get; set; }

        public bool IsAdmin { get; set; }
    }
}
