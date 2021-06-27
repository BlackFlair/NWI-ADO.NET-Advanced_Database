using School_Management_System.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace School_Management_System.Data.Entity
{
    public class Classroom
    {
        //public Classroom()
        //{
        //    Students = new HashSet<Student>(); 
        //}

        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        //public virtual ICollection<Student> Students { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Subject Subject { get; set; }
    }

    public class ClassroomConfig : EntityTypeConfiguration<Classroom>
    {
        public ClassroomConfig()
        {
            HasKey(e => new { e.TeacherId, e.SubjectId });
        }
    }
}
