using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Enrollment
    {
        public enum Grade
        {
            A, B, C, D, F
        }

        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
