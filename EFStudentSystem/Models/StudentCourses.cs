using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFStudentSystem.Models
{
    [PrimaryKey(nameof(CoursesId),nameof(StudentsId))]
    class StudentCourses
    {
        public int CoursesId { get; set; }
        public Courses Courses { get; set; }
        public int StudentsId { get; set; }
        public Students Students { get; set; }
    }
}
