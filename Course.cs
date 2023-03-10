using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class Course
    {

        public string CourseId { get; set; }
        public string Name { get; set; }
        public string DepartmentId { get; set; }
        [ForeignKey("Students")]
        public string StudentId { get; set; }


        public ICollection<Student> Students { get; set; }
        public Department Department { get; set; }
        public ICollection<CourseStudent> CourseStudent { get; set; }


    }
}
