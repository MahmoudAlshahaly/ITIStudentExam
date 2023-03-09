using BLL.Entities;
using BLL.Interfaces;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmInstructorCourses : Form
    {
        private readonly IInstructorCourseRepository  instructorCourseRepository;
        private readonly ICoursesRepository coursesRepository;
        private readonly IInstructorRepository  instructorRepository;
        private InstructorCourse instructorCourse;
        public FrmInstructorCourses()
        {
            InitializeComponent();
            instructorCourse = new InstructorCourse();
            instructorCourseRepository = Program.GetService<IInstructorCourseRepository>();
            coursesRepository = Program.GetService<ICoursesRepository>();
            instructorRepository = Program.GetService<IInstructorRepository>();
        }
        private void AutoNumber()
        {     
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnEdit.Enabled = false;
            //Dgv.RowTemplate.Height = 80;
            Dgv.DataSource = instructorCourseRepository.GetAll();
            //((DataGridViewImageColumn)Dgv.Columns[Dgv.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        public void FillInstructor()
        {
            cbxInstructor.DataSource = instructorRepository.GetAll();
            cbxInstructor.DisplayMember = "instru_name";
            cbxInstructor.ValueMember = "instru_id";
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
            FillInstructor();
        }
        private InstructorCourse entityData()
        {
            instructorCourse.instru_id = cbxInstructor.SelectedValue.ToString();
            instructorCourse.course_id = cbxCourse.SelectedValue.ToString();

           
            return instructorCourse;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var state = instructorCourseRepository.Insert(entityData());
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
        private void Data(InstructorCourse entity)
        {
            cbxCourse.Text = entity.course_id.ToString();
            cbxInstructor.Text = entity.instru_id.ToString();

            Dgv.DataSource = new List<InstructorCourse> { entity };
            Show();
        }
    }
}
