using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApp.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set;}
        public string StudentCity { get; set;}

        [ForeignKey("CourseId")]
        public int? CourseId { get; set; }

        public virtual Course? Course { get; set; }
    }

}

