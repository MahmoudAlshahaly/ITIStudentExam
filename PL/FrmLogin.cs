using BLL.Interfaces;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmLogin : Form
    {
        private readonly IInstructorRepository instructorRepository;
        private readonly IStudentRepository studentRepository;
        public FrmLogin()
        {
            InitializeComponent();
            instructorRepository = Program.GetService<IInstructorRepository>();
            studentRepository = Program.GetService<IStudentRepository>();

        }
        private bool validation()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter username ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtUserPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                if (rbtnInstructor.Checked == true)
                {
                    var instru = instructorRepository.GetByNamePassword(txtUserName.Text, txtUserPassword.Text);
                    if (instru != null && instru.instru_name == txtUserName.Text && instru.instru_password == txtUserPassword.Text)
                    {
                        this.Hide();
                        MainForm frm = new MainForm();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rbtnStudent.Checked == true)
                {
                    var stu = studentRepository.GetByNamePassword(txtUserName.Text, txtUserPassword.Text);
                    if (stu.stu_name == txtUserName.Text && stu.stu_password == txtUserPassword.Text)
                    {
                        Properties.Settings.Default.stu_id = stu.stu_id.ToString();
                        Properties.Settings.Default.Save();
                        this.Hide();
                        FrmExam frm = new FrmExam();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
