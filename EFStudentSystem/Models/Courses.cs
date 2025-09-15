using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFStudentSystem.Models
{
    class Courses
    {
        public int CoursesId { get; set; }

        [Column(TypeName = "varchar(80)")]
        [Unicode(true)]
        public string Name { get; set; }

        [Unicode(true)]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public List<Students> Students { get; set; }
        public List<Resources> Resources { get; set; }
        public List<HomeWorkSubmissions> HomeWorkSubmissions { get; set; }
    }
}
