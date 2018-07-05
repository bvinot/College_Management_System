using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Management.Entities.DataTransferObjects
{
    public class CourseDto
    {
        public int CourseId { get; set; }

        public string Name { get; set; }

        public List<string> Subjects { get; set; }
    }
}
