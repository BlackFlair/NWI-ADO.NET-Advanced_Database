using System;
using System.Data.Entity.ModelConfiguration;


namespace School_Management_System.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int Batch { get; set; }
    }

    //public class StudentConfig : EntityTypeConfiguration<Student>
    //{
    //{
    //    public StudentConfig()
    //    {
    //        HasKey(e => e.StudentId);
    //    }
    //}
}
