using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFStudentSystem.Models
{
    enum ContentType
    {
        Application=0,
        Pdf=1,
        Zip=2
    }
    class HomeWorkSubmissions
    {
        public int HomeWorkSubmissionsId { get; set; }
        [Unicode(false)]
        public string Content { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public Courses Courses { get; set; }
        public Students Students { get; set; }

    }
}
