using BLL.Entities;
using BLL.Interfaces;
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
    public partial class FrmGenerateExam : Form
    {
        private readonly IExamRepository examRepository;
        private readonly ICoursesRepository coursesRepository;

        private GenerateExam generateExam;
        public FrmGenerateExam()
        {
            InitializeComponent();
            examRepository = Program.GetService<IExamRepository>();
            coursesRepository = Program.GetService<ICoursesRepository>();

            generateExam = new GenerateExam();
        }
        public void FillExam()
        {
            cbxExamName.DataSource = examRepository.GetAll();
            cbxExamName.DisplayMember = "exam_name";
            cbxExamName.ValueMember = "exam_id";
        }
        public void FillCourse()
        {

            cbxCourseName.DataSource = coursesRepository.GetAll();
            cbxCourseName.DisplayMember = "course_name";
            cbxCourseName.ValueMember = "course_id";
        }
        private bool validation()
        {
            if (txtNumMCQ.Text == "")
            {
                MessageBox.Show("من فضلك ادخل عدد الاسئة الاختر", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNumTF.Text == "")
            {
                MessageBox.Show("من فضلك ادخل عدد الاسئلة الصح والخطاء", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private GenerateExam EXAM()
        {
            generateExam.course_id = Convert.ToInt32(cbxCourseName.SelectedValue);
            generateExam.exam_id =Convert.ToInt32(cbxExamName.SelectedValue);
            generateExam.num_question_tf = Convert.ToInt32(txtNumTF.Text);
            generateExam.num_question_mcq = Convert.ToInt32(txtNumMCQ.Text);
            return generateExam;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            

            if (validation() == true)
            {
                var data=   examRepository.GenerateExam(EXAM());
                if (data >= 1)
                {
                    MessageBox.Show("تم انشاء الامتحان بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void FrmGenerateExam_Load(object sender, EventArgs e)
        {
            FillCourse();
            FillExam();
        }
    }
}
