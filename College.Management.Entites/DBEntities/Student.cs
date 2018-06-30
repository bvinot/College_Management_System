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

namespace College.Management.Entites.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int StudentId { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public Grade Grade { get; set; }

        public int Rank { get; set; }
    }
}
