using System.Data.Entity.ModelConfiguration;

namespace School_Management_System.Data.Entity
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
    }

    //public class TeacherConfig : EntityTypeConfiguration<Teacher>
    //{
    //    public TeacherConfig()
    //    {
    //        HasKey(e => e.TeacherId);
    //    }
    //}
}
