using BLL.Entities;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmStudents : Form
    {
        private readonly IStudentRepository  studentRepository;
        private readonly IDepartmentRepository  departmentRepository;

        private Student student;
        private int id;
        public FrmStudents()
        {
            InitializeComponent();
            student = new Student();
            studentRepository = Program.GetService<IStudentRepository>();
            departmentRepository = Program.GetService<IDepartmentRepository>();
        }
        private void AutoNumber()
        {
            id = studentRepository.GetIDLast();
            if (id == 0)
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (id + 1).ToString();
            }

            txtName.Clear();
     
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnEdit.Enabled = false;
            //Dgv.RowTemplate.Height = 80;
            Dgv.DataSource = studentRepository.GetAll();
            //((DataGridViewImageColumn)Dgv.Columns[Dgv.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
        public void FillDepartment()
        {
            cbxDepartment.DataSource = departmentRepository.GetAll();
            cbxDepartment.DisplayMember = "dept_name";
            cbxDepartment.ValueMember = "dept_id";
        }
        private void FrmCity_Load(object sender, EventArgs e)
        {
            AutoNumber();
            FillDepartment();
        }
        private Student entityData()
        {
            student.stu_id  = Convert.ToInt32(txtID.Text);
            student.stu_name = txtName.Text;
            student.stu_dept_id = cbxDepartment.SelectedValue.ToString();
            student.stu_password = txtPassword.Text;

            return student;
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
                var state = studentRepository.Insert(entityData());
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
                var state = studentRepository.Edit(entityData());
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
                var state = studentRepository.RemoveOne(Convert.ToInt32(txtID.Text));
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
                var state = studentRepository.RemoveAll();
                if (state >= 1)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AutoNumber();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            student = studentRepository.GetByName(txtSearch.Text);
            Data(student);
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
        private void Data(Student entity)
        {
            txtID.Text = entity.stu_id.ToString();
            txtName.Text = entity.stu_name;
            cbxDepartment.Text = entity?.stu_dept_id.ToString();
            txtPassword.Text = entity?.stu_password;
            Dgv.DataSource = new List<Student> { entity };
            Show();
        }

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var d = studentRepository.GetById(Convert.ToInt32(Dgv.CurrentRow.Cells[0].Value));
            Data(d);
            Show();
        }
    }
}
