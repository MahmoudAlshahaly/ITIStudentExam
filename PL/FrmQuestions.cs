using BLL.Entities;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmQuestions : Form
    {
        private readonly IQuestionRepository  questionRepository;
        private readonly IChoiceRepository choiceRepository;
        private readonly ICoursesRepository coursesRepository;
        private Question question;
        private Choice choice;
        private int id;
        public FrmQuestions()
        {
            InitializeComponent();
            question = new Question();
            choice = new Choice();
            questionRepository = Program.GetService<IQuestionRepository>();
            choiceRepository = Program.GetService<IChoiceRepository>();
            coursesRepository = Program.GetService<ICoursesRepository>();
        }
        private void AutoNumber()
        {
            id = questionRepository.GetIDLast();
            if (id == 0)
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (id + 1).ToString();
            }

            txtRightAnswer.Clear();
            txtChoiceFirst.Clear();
            txtChoiceSecond.Clear();
            txtChoiceThird.Clear();
            txtChoiceFourth.Clear();
            txtTitleQuestion.Clear();
            
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnEdit.Enabled = false;
            //Dgv.RowTemplate.Height = 80;
            DgvQuestion.DataSource = questionRepository.GetAll();
            dgvChoices.DataSource = choiceRepository.GetAll();
            //((DataGridViewImageColumn)Dgv.Columns[Dgv.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
        public void FillCourse()
        {
            cbxCourse.DataSource = coursesRepository.GetAll();
            cbxCourse.DisplayMember = "course_name";
            cbxCourse.ValueMember = "course_id";
        }
        private void FrmCity_Load(object sender, EventArgs e)
        {
            AutoNumber();
            FillCourse();
        }
        private Question entityQuestion()
        {
            question.question_id = Convert.ToInt32(txtID.Text);
            question.question_type = txtRightAnswer.Text;
            question.question_title = txtRightAnswer.Text;
            question.question_right_answer = txtRightAnswer.Text;
            question.question_body_answer_id = txtRightAnswer.Text;
            question.questions_course_id = txtRightAnswer.Text;
        
           
            return question;
        }
        private Choice entityChoice()
        {
            choice.choise_id = Convert.ToInt32(txtID.Text);
            choice.choise_answer_first = txtRightAnswer.Text;
            choice.choise_answer_second = txtRightAnswer.Text;
            choice.choise_answer_third = txtRightAnswer.Text;
            choice.choise_answer_fourth  = txtRightAnswer.Text;

            return choice;
        }
        private bool validation()
        {
            if (txtRightAnswer.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الاجابة الصحيحة", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTitleQuestion.Text == "")
            {
                MessageBox.Show("من فضلك ادخل السؤال", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (CbxType.Text == "")
            {
                MessageBox.Show("من فضلك ادخل نوع السؤال", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtChoiceFirst.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الاجابة الاولة", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtChoiceSecond.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الاجابة الثانية", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtChoiceThird.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الاجابة الثالثة", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtChoiceFourth.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الاجابة الرابعة", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                var state = questionRepository.Insert(entityQuestion());
                var state2 = choiceRepository.Insert(entityChoice());
                if (state >= 1 && state2 >= 1)
                {
                    MessageBox.Show("تم الحفظ بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoNumber();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                var state = questionRepository.Edit(entityQuestion());
                var state2 = choiceRepository.Edit(entityChoice());

                if (state >= 1 && state2 >= 1)
                {
                    MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoNumber();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var state = questionRepository.RemoveOne(Convert.ToInt32(txtID.Text));
                var state2 = choiceRepository.RemoveOne(Convert.ToInt32(txtID.Text));

                if (state >= 1 && state2 >= 1)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var state = questionRepository.RemoveAll();
                var state2 = choiceRepository.RemoveAll();

                if (state >= 1 && state2 >= 1)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AutoNumber();
            }
        }
        private void Show()
        {
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnEdit.Enabled = true;
        }
        private void DataQuestion(Question entity)
        {
            txtID.Text = entity.question_id.ToString();
            txtRightAnswer.Text = entity.question_right_answer;
            txtTitleQuestion.Text = entity.question_title;
            cbxCourse.Text = entity.questions_course_id;
            CbxType.Text = entity.question_type;

            DgvQuestion.DataSource = new List<Question> { entity };
            Show();
        }
        private void DataChoice(Choice entity)
        {
            txtID.Text = entity.choise_id.ToString();
            txtChoiceFirst.Text = entity.choise_answer_first;
            txtChoiceSecond.Text = entity.choise_answer_second;
            txtChoiceThird.Text = entity.choise_answer_third;
            txtChoiceFourth.Text = entity.choise_answer_fourth;

            dgvChoices.DataSource = new List<Choice> { entity };
            Show();
        }

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var d = questionRepository.GetById(Convert.ToInt32(DgvQuestion.CurrentRow.Cells[0].Value));
            DataQuestion(d);

            var d2 = choiceRepository.GetById(Convert.ToInt32(txtID.Text));
            DataChoice(d2);
            Show();
        }
    }
}
