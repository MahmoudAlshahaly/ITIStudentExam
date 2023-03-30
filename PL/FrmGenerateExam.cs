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
        private Exam exam;
        private GenerateExam generateExam;
        public FrmGenerateExam()
        {
            InitializeComponent();
            examRepository = Program.GetService<IExamRepository>();
            coursesRepository = Program.GetService<ICoursesRepository>();
            exam = new Exam();
            generateExam = new GenerateExam();
        }
        private Exam entityData()
        {
            exam.exam_id = examRepository.GetIDLast() + 1;
            generateExam.exam_id = exam.exam_id;
            exam.exam_name = txtName.Text;

            return exam;
        }
        public void FillCourse()
        {

            cbxCourseName.DataSource = coursesRepository?.GetAll();
            cbxCourseName.DisplayMember = "course_name";
            cbxCourseName.ValueMember = "course_id";
        }
        private bool validation()
        {
            if (nudNumMCQ.Value == 0)
            {
                MessageBox.Show("please enter number of mcq question", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nudNumTF.Value == 0)
            {
                MessageBox.Show("please enter number of T/F question", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("please enter Exam name", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private GenerateExam EXAM()
        {
            generateExam.course_id = Convert.ToInt32(cbxCourseName.SelectedValue);
            generateExam.num_question_tf = Convert.ToInt32(nudNumTF.Value);
            generateExam.num_question_mcq = Convert.ToInt32(nudNumMCQ.Value);
            return generateExam;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {


            if (validation() == true)
            {
                var state = examRepository.Insert(entityData());
                if (state >= 1)
                {
                    var data = examRepository.GenerateExam(EXAM());
                    if (data >= 1)
                    {
                        MessageBox.Show("Exam has been generated Successfully", "confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }


        }

        private void FrmGenerateExam_Load(object sender, EventArgs e)
        {
            FillCourse();
        }
    }
}
