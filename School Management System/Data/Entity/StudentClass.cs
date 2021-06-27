using School_Management_System.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace School_Management_System.Data.Entity
{
    public class StudentClass
    {
        //public StudentClass()
        //{
        //    Students = new HashSet<Student>();
        //}

        public int ClassroomId { get; set; }
        public int StudentId { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Student Student { get; set; }
        //public virtual Classroom Classroom { get; set; }
        //public virtual ICollection<Student> Students { get; set; }
    }

    public class StudentClassConfig : EntityTypeConfiguration<StudentClass>
    {
        public StudentClassConfig()
        {
            HasKey(e => new { e.ClassroomId, e.StudentId});
        }
    }
}
