using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Student
    {
        
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string DepartmentId { get; set; }
        public ICollection<Course> Courses { get; set; }
        
        public StudentAddress StudentAddress { get; set; }






    }
}