using School_Management_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Form1 : Form
    {
        SMSContext mContext;

        public Form1()
        {
            InitializeComponent();

            mContext = new SMSContext();

            //setupDb();
        }

        //public void setupDb()
        //{
        //    try
        //    {
        //        using (var ctx = new SMSContext())
        //        {
        //            var student = ctx.Students.FirstOrDefault();
        //            MessageBox.Show("Done");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void button1_Click(object sender, EventArgs eArgs)
        {
            var q1 = mContext.StudentClasses.Where(e => e.ClassroomId == 1).Select(e=>new { e.StudentId , e.Student.Name, e.Student.Batch});
            dataGridView1.DataSource = q1.ToList();
        }

        private void button3_Click(object sender, EventArgs eArgs)
        {
            var q3 = mContext.Students.Where(e=>e.Batch==2019).Select(e => new { e.Id, e.Name, e.DOB });
            dataGridView1.DataSource = q3.ToList();

        }

        private void button2_Click(object sender, EventArgs eArgs)
        {
            var q2 = mContext.Classrooms.Select(e => new {e.Id, e.Teacher.Subject, e.TeacherId, e.Teacher.Name});
            dataGridView1.DataSource = q2.ToList();
        }
    }
}
