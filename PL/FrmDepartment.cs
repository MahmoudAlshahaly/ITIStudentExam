using BLL.Entities;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmDepartment : Form
    {
        private readonly IDepartmentRepository  departmentRepository;
        private Department department;
        private int id;
        public FrmDepartment()
        {
            InitializeComponent();
            department = new Department();
            departmentRepository = Program.GetService<IDepartmentRepository>();
        }
        private void AutoNumber()
        {
            id = departmentRepository.GetIDLast();
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
            Dgv.DataSource = departmentRepository.GetAll();
            //((DataGridViewImageColumn)Dgv.Columns[Dgv.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
        private void FrmCity_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }
        private Department entityData()
        {
            department.dept_id = Convert.ToInt32(txtID.Text);
            department.dept_name = txtName.Text;
        
           
            return department;
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
                var state = departmentRepository.Insert(entityData());
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
                var state = departmentRepository.Edit(entityData());
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
                var state = departmentRepository.RemoveOne(Convert.ToInt32(txtID.Text));
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
                var state = departmentRepository.RemoveAll();
                if (state >= 1)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AutoNumber();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            department = departmentRepository.GetByName(txtSearch.Text);
            Data(department);
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
        private void Data(Department entity)
        {
            txtID.Text = entity.dept_id.ToString();
            txtName.Text = entity.dept_name;

            Dgv.DataSource = new List<Department> { entity };
            Show();
        }

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var d = departmentRepository.GetById(Convert.ToInt32(Dgv.CurrentRow.Cells[0].Value));
            Data(d);
            Show();
        }
    }
}
