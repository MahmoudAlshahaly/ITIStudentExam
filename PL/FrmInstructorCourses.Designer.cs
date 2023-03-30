
namespace PL
{
    partial class FrmInstructorCourses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxInstructor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4});
            this.Dgv.Location = new System.Drawing.Point(13, 248);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RowHeadersWidth = 51;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(810, 250);
            this.Dgv.TabIndex = 57;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "course_id";
            this.Column2.HeaderText = "Course";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "instru_id";
            this.Column4.HeaderText = "Instructor";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.Location = new System.Drawing.Point(420, 166);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(134, 36);
            this.btnNew.TabIndex = 58;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(281, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 36);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxCourse
            // 
            this.cbxCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(541, 78);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(233, 29);
            this.cbxCourse.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(423, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 61;
            this.label4.Text = "Course :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxInstructor
            // 
            this.cbxInstructor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxInstructor.FormattingEnabled = true;
            this.cbxInstructor.Location = new System.Drawing.Point(183, 78);
            this.cbxInstructor.Name = "cbxInstructor";
            this.cbxInstructor.Size = new System.Drawing.Size(232, 29);
            this.cbxInstructor.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(65, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 59;
            this.label3.Text = "Instructor :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInstructorCourses
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 577);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxInstructor);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmInstructorCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructor Courses";
            this.Load += new System.EventHandler(this.FrmCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxInstructor;
        private System.Windows.Forms.Label label3;
    }
}