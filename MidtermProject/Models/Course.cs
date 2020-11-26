using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermProject.Models
{
    public class Course
    {
        public int CourseId { get; set; }

         public string CourseName { get; set; }
        public string CourseDescription { get; set; }
            public string TutorName { get; set; }
        public int CourseRating { get; set; }
    }
}
