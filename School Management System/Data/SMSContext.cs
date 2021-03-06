using School_Management_System.Data.Entities;
using School_Management_System.Data.Entity;
using System;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace School_Management_System.Data
{
    public class SMSContext: DbContext
    {
        public SMSContext() : base("SMSDB")
        {
            
        }


        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new StudentClassConfig());
            builder.Configurations.Add(new ClassroomConfig());
        }


        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<StudentClass> StudentClasses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }    

    }

}
