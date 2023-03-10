using BLL.Entities;
using BLL.Interfaces;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmCourse : Form
    {
        private readonly ICoursesRepository  coursesRepository;
        private readonly CoursesRepository courRepository;
        private Course course;
        private int id;
        public FrmCourse()
        {
            InitializeComponent();
            course = new Course();
            coursesRepository = Program.GetService<ICoursesRepository>();


        }
        private void AutoNumber()
        {
            id = coursesRepository.GetIDLast();
            txtID.Text = (id + 1).ToString();
            
            txtName.Clear();
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnEdit.Enabled = false;
            //Dgv.RowTemplate.Height = 80;
            Dgv.DataSource = coursesRepository.GetAll();
            //((DataGridViewImageColumn)Dgv.Columns[Dgv.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void FrmCity_Load(object sender, EventArgs e)
        {
            AutoNumber();
         
        }
        private Course entityData()
        {
            course.course_id = Convert.ToInt32(txtID.Text);
            course.course_name = txtName.Text;
            return course;
        }
        private bool validation()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الاسم", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                var state = coursesRepository.Insert(entityData());
                if (state >= 1)
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
                var state = coursesRepository.Edit(entityData());
                if (state >= 1)
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
                var state = coursesRepository.RemoveOne(Convert.ToInt32(txtID.Text));
                if (state >= 1)
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
                var state = coursesRepository.RemoveAll();
                if (state >= 1)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AutoNumber();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            course = coursesRepository.GetByName(txtSearch.Text);
            Data(course);
            Show();
        }
        private void Show()
        {
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnEdit.Enabled = true;
        }
        private void Data(Course entity)
        {
            txtID.Text = entity.course_id.ToString();
            txtName.Text = entity.course_name;

            Dgv.DataSource = new List<Course> { entity };
            Show();
        }

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var d = coursesRepository.GetById(Convert.ToInt32(Dgv.CurrentRow.Cells[0].Value));
            Data(d);
            Show();
        }
    }
}
