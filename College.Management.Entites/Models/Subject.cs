using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entities.Models
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int SubjectId { get; set; }

        string Name { get; set; }

        int RelatedCourseId { get; set; }

        int CreditPoints { get; set; }

        public Subject()
        {

        }

        public Subject(string name, int crseId, int credits)
        {
            Name = name;

            RelatedCourseId = crseId;

            CreditPoints = credits;
        }
    }
}
