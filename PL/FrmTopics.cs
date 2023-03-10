using BLL.Entities;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmTopics : Form
    {
        private readonly ICoursesRepository  coursesRepository;
        private readonly ITopicRepository  topicRepository;

        private Topic topic;
        private int id;
        public FrmTopics()
        {
            InitializeComponent();
            topic = new Topic();
            coursesRepository = Program.GetService<ICoursesRepository>();
            topicRepository = Program.GetService<ITopicRepository>();
        }
        private void AutoNumber()
        {
            id = topicRepository.GetIDLast();
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
            Dgv.DataSource = topicRepository.GetAll();
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
        private Topic entityData()
        {
            topic.topic_id  = Convert.ToInt32(txtID.Text);
            topic.topic_name = txtName.Text;
            topic.topic_course_id = cbxCourse.SelectedValue.ToString();

            return topic;
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
                var state = topicRepository.Insert(entityData());
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
                var state = topicRepository.Edit(entityData());
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
                var state = topicRepository.RemoveOne(Convert.ToInt32(txtID.Text));
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
                var state = topicRepository.RemoveAll();
                if (state >= 1)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AutoNumber();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            topic = topicRepository.GetByName(txtSearch.Text);
            Data(topic);
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
        private void Data(Topic entity)
        {
            txtID.Text = entity.topic_id.ToString();
            txtName.Text = entity.topic_name;
            cbxCourse.Text = entity?.topic_course_id.ToString();
            Dgv.DataSource = new List<Topic> { entity };
            Show();
        }

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var d = topicRepository.GetById(Convert.ToInt32(Dgv.CurrentRow.Cells[0].Value));
            Data(d);
            Show();
        }
    }
}
