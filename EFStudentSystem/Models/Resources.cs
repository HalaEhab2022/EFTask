using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFStudentSystem.Models
{
    public enum ResourceType
    {
        Video=0,
        Presentation=1,
        Document=2,
        Other=3
    }
    class Resources
    {
        public int ResourcesId { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Unicode(true)]
        public string Name { get; set; }
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }
        public Courses Courses { get; set; }
    }
}
