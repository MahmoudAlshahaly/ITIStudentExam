
namespace PL
{
    partial class FrmPrint
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
            this.rptExamStudentModel1 = new PL.rptExamStudentModel();
            this.rptStudentGrades1 = new PL.rptStudentGrades();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptInstructorCourseStu1 = new PL.rptInstructorCourseStu();
            this.rptAllStudentDept1 = new PL.rptAllStudentDept();
            this.rptTopicsInCourse1 = new PL.rptTopicsInCourse();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptTopicsInCourse1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(832, 602);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // FrmPrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(832, 602);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FrmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrint";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rptExamStudentModel rptExamStudentModel1;
        private rptStudentGrades rptStudentGrades1;
        private rptAllStudentDept rptAllStudentDept1;
        private rptInstructorCourseStu rptInstructorCourseStu1;
        private rptTopicsInCourse rptTopicsInCourse1;
    }
}