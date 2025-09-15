using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudentSystem.Models
{
    class Students
    {
        public int StudentsId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; } 
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; } 
        public List<Courses> Courses { get; set; }
        public List<HomeWorkSubmissions> HomeWorkSubmissions { get; set; }

    }
}


