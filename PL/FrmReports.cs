using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private void btnExamPrint_Click(object sender, EventArgs e)
        {
            if (txtExamID.Text != "")
            {
                rptExam r = new rptExam();
                r.SetParameterValue("@exam_id", txtExamID.Text);
                FrmPrint frm1 = new FrmPrint();
                frm1.crystalReportViewer1.ReportSource = r;
                frm1.ShowDialog();
            }
        }

        private void btnPrintModel_Click(object sender, EventArgs e)
        {
            if (txtExamID.Text != "" && txtStudentID.Text!="")
            {
                rptExamStudentModel r = new rptExamStudentModel();
                r.SetParameterValue("@exam_id", txtExamID.Text);
                r.SetParameterValue("@stu_id", txtStudentID.Text);
                FrmPrint frm1 = new FrmPrint();
                frm1.crystalReportViewer1.ReportSource = r;
                frm1.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "")
            {
                rptStudentGrades r = new rptStudentGrades();
                r.SetParameterValue("@stu_id", txtStudentID.Text);
                FrmPrint frm1 = new FrmPrint();
                frm1.crystalReportViewer1.ReportSource = r;
                frm1.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDeptID.Text != "")
            {
                rptAllStudentDept r = new rptAllStudentDept();
                r.SetParameterValue("@dept_id", txtDeptID.Text);
                FrmPrint frm1 = new FrmPrint();
                frm1.crystalReportViewer1.ReportSource = r;
                frm1.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtInstruID.Text != "")
            {
                rptInstructorCourseStu r = new rptInstructorCourseStu();
                r.SetParameterValue("@instru_id", txtInstruID.Text);
                FrmPrint frm1 = new FrmPrint();
                frm1.crystalReportViewer1.ReportSource = r;
                frm1.ShowDialog();
            }
        }
    }
}
