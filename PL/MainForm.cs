using DAL;
using Microsoft.SqlServer.Management.Smo;
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
        Button currentButton;
        Form ActiveForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnsender)
        {
            DisableButton();
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = Color.Firebrick;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control prevButton in panelMenu.Controls)
            {
                if (prevButton.GetType() == typeof(Button))
                {
                    prevButton.BackColor = Color.Maroon;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActivateButton(btnSender);
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            lbl_title.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
            lbl_title.Text = childForm.Text;
        }

        private void btn_addCrs_Click(object sender, EventArgs e)
        {
            FrmCourse frm = new FrmCourse();
            OpenChildForm(frm, sender);
        }

        private void btn_addStd_Click(object sender, EventArgs e)
        {
            FrmStudents frm = new FrmStudents();
            OpenChildForm(frm, sender);
        }

        private void btn_addExm_Click(object sender, EventArgs e)
        {
            FrmGenerateExam frm = new FrmGenerateExam();
            OpenChildForm(frm, sender);
        }

        private void btn_exmName_Click(object sender, EventArgs e)
        {
            FrmExamName frm = new FrmExamName();
            OpenChildForm(frm, sender);
        }

        private void btn_addQ_Click(object sender, EventArgs e)
        {
            FrmQuestions frm = new FrmQuestions();
            OpenChildForm(frm, sender);
        }

        private void btn_addIns_Click(object sender, EventArgs e)
        {
            FrmInstructor frm = new FrmInstructor();
            OpenChildForm(frm, sender);
        }

        private void btn_dept_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            OpenChildForm(frm, sender);
        }

        private void btn_stdCrs_Click(object sender, EventArgs e)
        {
            FrmStudentCourses frm = new FrmStudentCourses();
            OpenChildForm(frm, sender);
        }

        private void btn_insCrs_Click(object sender, EventArgs e)
        {
            FrmInstructorCourses frm = new FrmInstructorCourses();
            OpenChildForm(frm, sender);
        }

        private void btn_top_Click(object sender, EventArgs e)
        {
            FrmTopics frm = new FrmTopics();
            OpenChildForm(frm, sender);
        }

        private void btn_rep_Click(object sender, EventArgs e)
        {
            FrmReports frm = new FrmReports();
            OpenChildForm(frm, sender);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            FrmLogin frm = new FrmLogin();
            this.Close();
            frm.Show();
        }

        private void btn_Backup_Click(object sender, EventArgs e)
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
                    //    ["@filename"] = $"@{open.FileName}"
                    //};
                    DBHelper db = new DBHelper();
                    db.ExecuteStored("backup database ITIExamSystem To Disk='" + open.FileName + "'", null);

                    MessageBox.Show("تم اخذ نسخه احتياطية بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { };
        }

        private void btn_restore_Click(object sender, EventArgs e)
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
