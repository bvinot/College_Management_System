using College.Management.Entites.Models;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int SubjectId { get; set; }

        public string Name { get; set; }

        public int RelatedCourseId { get; set; }

        [ForeignKey("RelatedCourseId")]
        public Course RelatedCourse { get; set; }

        public int CreditPoints { get; set; }

    }
}
