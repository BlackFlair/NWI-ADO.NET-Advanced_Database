using School_Management_System.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Data.Entity
{
    public class StudentClass
    {
        public StudentClass()
        {
            Students = new HashSet<Student>();
        }

        public int ClassroomId { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }

    public class StudentClassConfig : EntityTypeConfiguration<StudentClass>
    {
        public StudentClassConfig()
        {
            HasKey(e => e.ClassroomId);
        }
    }
}
