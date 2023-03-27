using DAL;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string d = DateTime.Now.Date.ToString("dd-MM-yyyy");
                SaveFileDialog open = new SaveFileDialog();
                open.Filter = "BackUp Files (*.Back) | *.back";
                open.FileName = "ExamSystem_BackUp_" + d + "";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    //Dictionary<string, object> param = new Dictionary<string, object>()
                    //{
                    //    ["@filename"] = open.FileName
                    //};
                    DBHelper db = new DBHelper();
                    db.ExecuteStored("backup database ITIExamSystem To Disk='" + open.FileName + "'", null);
                    
                    MessageBox.Show("تم اخذ نسخه احتياطية بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
            catch (Exception) { };
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Server server = new Server(@".\SQLEXPRESS");
            server.KillAllProcesses("ITIExamSystem");
            Restore restore = new Restore();

            restore.Database = "ITIExamSystem";
            restore.Action = RestoreActionType.Database;

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "BackUp Files (*.Back) | *.back";
            if (open.ShowDialog() == DialogResult.OK)
            {
                restore.Devices.AddDevice(open.FileName, DeviceType.File);
                restore.ReplaceDatabase = true;
                restore.NoRecovery = false;
                restore.SqlRestore(server);
                MessageBox.Show("تم استرجاع النسخة الاحتياطية بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
