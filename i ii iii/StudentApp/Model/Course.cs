using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentApp.Model
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? LecturerName { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    }
}
