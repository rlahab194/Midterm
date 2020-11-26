using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public int CourseId { get; set; }
        public DateTime CourseEnrolledDate { get; set; }
        public int CourseStatus { get; set; }
        public string Grade { get; set; }


    }
}
