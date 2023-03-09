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
    public partial class FrmExam : Form
    {
        private readonly IExamGetRepository examGetRepository;
        private readonly IStudentAnswerRepository studentAnswerRepository;
        private readonly IStudentGradeRepository studentGradeRepository;
        private  StudentGrades studentGrades;
        private  StudentAnswer studentAnswer;
        private List<ExamGet> examGets;
        private  ExamGet exam;
        private int count=0;
        private int score = 0;
        private int numberOfQuestion = 0;
        private string selectedAnswer;
        public FrmExam()
        {
            InitializeComponent();
            examGetRepository = Program.GetService<IExamGetRepository>();
            studentAnswerRepository = Program.GetService<IStudentAnswerRepository>();
            studentGradeRepository = Program.GetService<IStudentGradeRepository>();
            studentGrades = new StudentGrades();
            studentAnswer = new StudentAnswer();
            examGets = new List<ExamGet>();
            exam = new ExamGet();
        }

        private void FrmExam_Load(object sender, EventArgs e)
        {
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            lblQuestionTitle.Visible = false;
        }
        private void DisplayQuestion()
        {

            exam = examGetRepository.GetByID(Convert.ToInt32(txtExamID.Text)).ToList().Skip(count).Take(1).FirstOrDefault();
            if(exam.question_type=="tf")
            {
                btn1.Text = "true";
                btn2.Text = "false";
                btn3.Visible = false;
                btn4.Visible = false;
            }
            else
            {
                btn3.Visible = true;
                btn4.Visible = true;
                btn1.Text = exam.choise_answer_first;
                btn2.Text = exam.choise_answer_second;
                btn3.Text = exam.choise_answer_third;
                btn4.Text = exam.choise_answer_fourth;
            }
            lblQuestionTitle.Text = exam.question_title;
            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            lblQuestionTitle.Visible = true;

            btnStart.Visible = false;
            lblEnter.Visible = false;
            txtExamID.Visible = false;
            numberOfQuestion = examGetRepository.GetByID(Convert.ToInt32(txtExamID.Text)).ToList().Count();

            DisplayQuestion();

        }
        private StudentAnswer AddAnswer()
        {
            studentAnswer.answer_exam_id = exam.exam_id.ToString();
            studentAnswer.answer_stu_id = PL.Properties.Settings.Default.stu_id;
            studentAnswer.answer_question_id = exam.question_id.ToString();
            studentAnswer.answer_selected = selectedAnswer;
            return studentAnswer;
        }
        private StudentGrades AddGrades()
        {
            studentGrades.grade_stu_id = PL.Properties.Settings.Default.stu_id;
            studentGrades.grade_exam_id =exam.exam_id.ToString();
            studentGrades.grade_percent = score;
            return studentGrades;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if(btn1.Text==exam.question_right_answer)
            {
                score+=10;
            }
            selectedAnswer = btn1.Text;
            studentAnswerRepository.Insert(AddAnswer());
            if(++count>=numberOfQuestion)
            {
                MessageBox.Show($"Exam Finished With Score : {score} % ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                studentGradeRepository.Insert(AddGrades());
                this.Close();
                return;
            }
            DisplayQuestion();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == exam.question_right_answer)
            {
                score += 10;
            }
            selectedAnswer = btn2.Text;
            studentAnswerRepository.Insert(AddAnswer());

            if (++count >= numberOfQuestion)
            {
                MessageBox.Show($"Exam Finished With Score : {score} % ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                studentGradeRepository.Insert(AddGrades());

                this.Close();
                return;
            }
            DisplayQuestion();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == exam.question_right_answer)
            {
                score += 10;
            }
            selectedAnswer = btn3.Text;
            studentAnswerRepository.Insert(AddAnswer());

            if (++count >= numberOfQuestion)
            {
                MessageBox.Show($"Exam Finished With Score : {score} % ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                studentGradeRepository.Insert(AddGrades());

                this.Close();
                return;
            }
            DisplayQuestion();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == exam.question_right_answer)
            {
                score += 10;
            }
            selectedAnswer = btn4.Text;
            studentAnswerRepository.Insert(AddAnswer());

            if (++count >= numberOfQuestion)
            {
                MessageBox.Show($"Exam Finished With Score : {score} % ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                studentGradeRepository.Insert(AddGrades());

                this.Close();
                return;
            }
            DisplayQuestion();

        }
    }
}
