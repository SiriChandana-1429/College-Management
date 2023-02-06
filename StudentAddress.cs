using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StudentAddress
    {
        public string StudentAddressId { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string PinCode { get; set; }

        [ForeignKey("Student")]
        public string StudentId { get; set; }

        
        

    }
}
