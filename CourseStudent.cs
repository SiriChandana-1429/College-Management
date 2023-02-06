using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CourseStudent
    {
        
            public string StudentId { get; set; } //foreign key property
            public Student Student { get; set; } //Reference navigation property

            public string CourseId { get; set; } //foreign key property
            public Course Course { get; set; } //Reference navigation property
        
    }
}
