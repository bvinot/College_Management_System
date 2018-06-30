using College.Management.Entities;
using College.Management.Entities.Enumerations;
using College.Management.Entities.Interfaces;
using College.Management.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entites.Dtos
{
    public class StudentDto : UserDto
    {
        public int StudentId { get; set; }

        public int Rank { get; set; }
    }
}
