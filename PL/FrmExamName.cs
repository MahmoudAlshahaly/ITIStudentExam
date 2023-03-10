using BLL.Entities;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmExamName : Form
    {
        private readonly IExamRepository  examRepository;
        private Exam exam;
        private int id;
        public FrmExamName()
        {
            InitializeComponent();
            exam = new Exam();
            examRepository = Program.GetService<IExamRepository>();
        }
        private void AutoNumber()
        {
            id = examRepository.GetIDLast();
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
            Dgv.DataSource = examRepository.GetAll();
            //((DataGridViewImageColumn)Dgv.Columns[Dgv.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
        private void FrmCity_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }
        private Exam entityData()
        {
            exam.exam_id = Convert.ToInt32(txtID.Text);
            exam.exam_name = txtName.Text;
        
           
            return exam;
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
                var state = examRepository.Insert(entityData());
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
                var state = examRepository.Edit(entityData());
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
                var state = examRepository.RemoveOne(Convert.ToInt32(txtID.Text));
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
                var state = examRepository.RemoveAll();
                if (state >= 1)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AutoNumber();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            exam = examRepository.GetByName(txtSearch.Text);
            Data(exam);
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
        private void Data(Exam entity)
        {
            txtID.Text = entity.exam_id.ToString();
            txtName.Text = entity.exam_name;

            Dgv.DataSource = new List<Exam> { entity };
            Show();
        }

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var d = examRepository.GetById(Convert.ToInt32(Dgv.CurrentRow.Cells[0].Value));
            Data(d);
            Show();
        }
    }
}
