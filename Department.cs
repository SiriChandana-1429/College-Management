using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class Department
    {
        public string DepartmentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }



    }
}
