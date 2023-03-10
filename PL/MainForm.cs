using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCourse frm = new FrmCourse();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudents frm = new FrmStudents();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmInstructor frm = new FrmInstructor();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmStudentCourses frm = new FrmStudentCourses();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmInstructorCourses frm = new FrmInstructorCourses();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmGenerateExam frm = new FrmGenerateExam();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmReports frm = new FrmReports();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmTopics frm = new FrmTopics();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmExamName frm = new FrmExamName();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmQuestions frm = new FrmQuestions();
            frm.ShowDialog();
        }
    }
}
