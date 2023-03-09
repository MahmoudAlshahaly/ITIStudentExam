using BLL.Entities;
using BLL.Interfaces;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmStudentCourses : Form
    {
        private readonly IStudentCourseRepository  studentCourseRepository;
        private readonly ICoursesRepository coursesRepository;
        private readonly IStudentRepository  studentRepository;
        private StudentCourse studentCourse;
        public FrmStudentCourses()
        {
            InitializeComponent();
            studentCourse = new StudentCourse();
            studentCourseRepository = Program.GetService<IStudentCourseRepository>();
            coursesRepository = Program.GetService<ICoursesRepository>();
            studentRepository = Program.GetService<IStudentRepository>();
        }
        private void AutoNumber()
        {     
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnEdit.Enabled = false;
            //Dgv.RowTemplate.Height = 80;
            Dgv.DataSource = studentCourseRepository.GetAll();
            //((DataGridViewImageColumn)Dgv.Columns[Dgv.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        public void FillStudent()
        {
            cbxStudent.DataSource = studentRepository.GetAll();
            cbxStudent.DisplayMember = "stu_name";
            cbxStudent.ValueMember = "stu_id";
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
            FillStudent();
        }
        private StudentCourse entityData()
        {
            studentCourse.course_id = cbxCourse.SelectedValue.ToString();
            studentCourse.stu_id = cbxStudent.SelectedValue.ToString();

           
            return studentCourse;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var state = studentCourseRepository.Insert(entityData());
            if (state >= 1)
            {
                MessageBox.Show("تم الحفظ بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoNumber();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();

        }
        private void Data(StudentCourse entity)
        {
            cbxCourse.Text = entity.course_id.ToString();
            cbxStudent.Text = entity.course_id.ToString();

            Dgv.DataSource = new List<StudentCourse> { entity };
            Show();
        }
    }
}
