
using System.Windows.Forms;

namespace PL
{
    partial class MainForm
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

        ////#region Windows Form Designer generated code

        ///// <summary>
        ///// Required method for Designer support - do not modify
        ///// the contents of this method with the code editor.
        ///// </summary>
        ////private void InitializeComponent()
        ////{
        ////    this.panel2 = new System.Windows.Forms.Panel();
        ////    this.panel1 = new System.Windows.Forms.Panel();
        ////    this.label7 = new System.Windows.Forms.Label();
        ////    this.btnAdd = new System.Windows.Forms.Button();
        ////    this.button1 = new System.Windows.Forms.Button();
        ////    this.button2 = new System.Windows.Forms.Button();
        ////    this.button3 = new System.Windows.Forms.Button();
        ////    this.button4 = new System.Windows.Forms.Button();
        ////    this.button5 = new System.Windows.Forms.Button();
        ////    this.button6 = new System.Windows.Forms.Button();
        ////    this.button7 = new System.Windows.Forms.Button();
        ////    this.button8 = new System.Windows.Forms.Button();
        ////    this.button9 = new System.Windows.Forms.Button();
        ////    this.button10 = new System.Windows.Forms.Button();
        ////    this.panel1.SuspendLayout();
        ////    this.SuspendLayout();

        ////    panel2


        ////    this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
        ////    this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
        ////    this.panel2.Location = new System.Drawing.Point(0, 728);
        ////    this.panel2.Name = "panel2";
        ////    this.panel2.Size = new System.Drawing.Size(1181, 62);
        ////    this.panel2.TabIndex = 52;

        ////    panel1


        ////    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
        ////    this.panel1.Controls.Add(this.label7);
        ////    this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        ////    this.panel1.Location = new System.Drawing.Point(0, 0);
        ////    this.panel1.Name = "panel1";
        ////    this.panel1.Size = new System.Drawing.Size(1181, 62);
        ////    this.panel1.TabIndex = 51;

        ////    label7


        ////    this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
        ////    this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        ////    this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        ////    this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        ////    this.label7.Location = new System.Drawing.Point(480, 21);
        ////    this.label7.Name = "label7";
        ////    this.label7.Size = new System.Drawing.Size(208, 28);
        ////    this.label7.TabIndex = 34;
        ////    this.label7.Text = "Main Panel";
        ////    this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        ////    btnAdd


        ////    this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
        ////    this.btnAdd.BackColor = System.Drawing.Color.SeaShell;
        ////    this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        ////    this.btnAdd.Location = new System.Drawing.Point(63, 242);
        ////    this.btnAdd.Name = "btnAdd";
        ////    this.btnAdd.Size = new System.Drawing.Size(203, 49);
        ////    this.btnAdd.TabIndex = 53;
        ////    this.btnAdd.Text = "Add Course";
        ////    this.btnAdd.UseVisualStyleBackColor = false;
        ////    this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

        ////    button1


        ////    this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
        ////    this.button1.BackColor = System.Drawing.Color.SeaShell;
        ////    this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        ////    this.button1.Location = new System.Drawing.Point(63, 336);
        ////    this.button1.Name = "button1";
        ////    this.button1.Size = new System.Drawing.Size(203, 49);
        ////    this.button1.TabIndex = 54;
        ////    this.button1.Text = "Add Student";
        ////    this.button1.UseVisualStyleBackColor = false;
        ////    this.button1.Click += new System.EventHandler(this.button1_Click);

        ////    button2


        ////    this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
        ////    this.button2.BackColor = System.Drawing.Color.SeaShell;
        ////    this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        ////    this.button2.Location = new System.Drawing.Point(919, 242);
        ////    this.button2.Name = "button2";
        ////    this.button2.Size = new System.Drawing.Size(203, 49);
        ////    this.button2.TabIndex = 55;
        ////    this.button2.Text = "Add Instructor";
        ////    this.button2.UseVisualStyleBackColor = false;
        ////    this.button2.Click += new System.EventHandler(this.button2_Click);

        ////    button3


        ////    this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
        ////    this.button3.BackColor = System.Drawing.Color.SeaShell;
        ////    this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        ////    this.button3.Location = new System.Drawing.Point(919, 336);
        ////    this.button3.Name = "button3";
        ////    this.button3.Size = new System.Drawing.Size(203, 49);
        ////    this.button3.TabIndex = 56;
        ////    this.button3.Text = "Departments";
        ////    this.button3.UseVisualStyleBackColor = false;
        ////    this.button3.Click += new System.EventHandler(this.button3_Click);

        ////    button4


        ////    this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
        ////    this.button4.BackColor = System.Drawing.Color.SeaShell;
        ////    this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        ////    this.button4.Location = new System.Drawing.Point(919, 426);
        ////    this.button4.Name = "button4";
        ////    this.button4.Size = new System.Drawing.Size(203, 49);
        ////    this.button4.TabIndex = 57;
        ////    this.button4.Text = "Student Courses";
        ////    this.button4.UseVisualStyleBackColor = false;
        ////    this.button4.Click += new System.EventHandler(this.button4_Click);

        ////    button5


        ////    this.button5.Anchor = System.Windows.Forms.AnchorStyles.Right;
        ////    this.button5.BackColor = System.Drawing.Color.SeaShell;
        ////    this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        ////    this.button5.Location = new System.Drawing.Point(919, 517);
        ////    this.button5.Name = "button5";
        ////    this.button5.Size = new System.Drawing.Size(203, 49);
        ////    this.button5.TabIndex = 58;
        ////    this.button5.Text = "Instructor courses";
        ////    this.button5.UseVisualStyleBackColor = false;
        ////    this.button5.Click += new System.EventHandler(this.button5_Click);

        ////    button6


        ////    this.button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
        ////    this.button6.BackColor = System.Drawing.Color.SeaShell;
        ////    this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        ////    this.button6.Location = new System.Drawing.Point(63, 426);
        ////    this.button6.Name = "button6";
        ////    this.button6.Size = new System.Drawing.Size(203, 49);
        ////    this.button6.TabIndex = 59;
        ////    this.button6.Text = "Add Exam";
        ////    this.button6.UseVisualStyleBackColor = false;
        ////    this.button6.Click += new System.EventHandler(this.button6_Click);

        ////    button7


        ////    this.button7.Anchor = System.Windows.Forms.AnchorStyles.Left;
        ////    this.button7.BackColor = System.Drawing.Color.SeaShell;
        ////    this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        ////    this.button7.Location = new System.Drawing.Point(63, 517);
        ////    this.button7.Name = "button7";
        ////    this.button7.Size = new System.Drawing.Size(203, 49);
        ////    this.button7.TabIndex = 60;
        ////    this.button7.Text = "Reports";
        ////    this.button7.UseVisualStyleBackColor = false;
        ////    this.button7.Click += new System.EventHandler(this.button7_Click);

        ////    button8


        ////    this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
        ////    this.button8.BackColor = System.Drawing.Color.SeaShell;
        ////    this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        ////    this.button8.Location = new System.Drawing.Point(489, 397);
        ////    this.button8.Name = "button8";
        ////    this.button8.Size = new System.Drawing.Size(203, 49);
        ////    this.button8.TabIndex = 61;
        ////    this.button8.Text = "Topics";
        ////    this.button8.UseVisualStyleBackColor = false;
        ////    this.button8.Click += new System.EventHandler(this.button8_Click);

        ////    button9


        ////    this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
        ////    this.button9.BackColor = System.Drawing.Color.SeaShell;
        ////    this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        ////    this.button9.Location = new System.Drawing.Point(489, 326);
        ////    this.button9.Name = "button9";
        ////    this.button9.Size = new System.Drawing.Size(203, 49);
        ////    this.button9.TabIndex = 62;
        ////    this.button9.Text = "Exams";
        ////    this.button9.UseVisualStyleBackColor = false;
        ////    this.button9.Click += new System.EventHandler(this.button9_Click);

        ////    button10


        ////    this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
        ////    this.button10.BackColor = System.Drawing.Color.SeaShell;
        ////    this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        ////    this.button10.Location = new System.Drawing.Point(489, 251);
        ////    this.button10.Name = "button10";
        ////    this.button10.Size = new System.Drawing.Size(203, 49);
        ////    this.button10.TabIndex = 63;
        ////    this.button10.Text = "Add Questions";
        ////    this.button10.UseVisualStyleBackColor = false;
        ////    this.button10.Click += new System.EventHandler(this.button10_Click);

        ////    MainForm


        ////    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        ////    this.BackColor = System.Drawing.Color.Snow;
        ////    this.ClientSize = new System.Drawing.Size(1181, 790);
        ////    this.Controls.Add(this.button10);
        ////    this.Controls.Add(this.button9);
        ////    this.Controls.Add(this.button8);
        ////    this.Controls.Add(this.button7);
        ////    this.Controls.Add(this.button6);
        ////    this.Controls.Add(this.button5);
        ////    this.Controls.Add(this.button4);
        ////    this.Controls.Add(this.button3);
        ////    this.Controls.Add(this.button2);
        ////    this.Controls.Add(this.button1);
        ////    this.Controls.Add(this.btnAdd);
        ////    this.Controls.Add(this.panel2);
        ////    this.Controls.Add(this.panel1);
        ////    this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        ////    this.Name = "MainForm";
        ////    this.RightToLeft = System.Windows.Forms.RightToLeft.No;
        ////    this.RightToLeftLayout = true;
        ////    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        ////    this.Text = "Main Form";
        ////    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        ////    this.panel1.ResumeLayout(false);
        ////    this.ResumeLayout(false);

        ////}

        ////#endregion

        ////private System.Windows.Forms.Panel panel2;
        ////private System.Windows.Forms.Panel panel1;
        ////private System.Windows.Forms.Label label7;
        ////private System.Windows.Forms.Button btnAdd;
        ////private System.Windows.Forms.Button button1;
        ////private System.Windows.Forms.Button button2;
        ////private System.Windows.Forms.Button button3;
        ////private System.Windows.Forms.Button button4;
        ////private System.Windows.Forms.Button button5;
        ////private System.Windows.Forms.Button button6;
        ////private System.Windows.Forms.Button button7;
        ////private System.Windows.Forms.Button button8;
        ////private System.Windows.Forms.Button button9;
        ////private System.Windows.Forms.Button button10;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_rep = new System.Windows.Forms.Button();
            this.btn_top = new System.Windows.Forms.Button();
            this.btn_insCrs = new System.Windows.Forms.Button();
            this.btn_stdCrs = new System.Windows.Forms.Button();
            this.btn_dept = new System.Windows.Forms.Button();
            this.btn_addIns = new System.Windows.Forms.Button();
            this.btn_addQ = new System.Windows.Forms.Button();
            this.btn_exmName = new System.Windows.Forms.Button();
            this.btn_addExm = new System.Windows.Forms.Button();
            this.btn_addStd = new System.Windows.Forms.Button();
            this.btn_addCrs = new System.Windows.Forms.Button();
            this.logopanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.logopanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Maroon;
            this.panelMenu.Controls.Add(this.btn_restore);
            this.panelMenu.Controls.Add(this.btn_Backup);
            this.panelMenu.Controls.Add(this.btn_logout);
            this.panelMenu.Controls.Add(this.btn_rep);
            this.panelMenu.Controls.Add(this.btn_top);
            this.panelMenu.Controls.Add(this.btn_insCrs);
            this.panelMenu.Controls.Add(this.btn_stdCrs);
            this.panelMenu.Controls.Add(this.btn_dept);
            this.panelMenu.Controls.Add(this.btn_addIns);
            this.panelMenu.Controls.Add(this.btn_addQ);
            this.panelMenu.Controls.Add(this.btn_exmName);
            this.panelMenu.Controls.Add(this.btn_addExm);
            this.panelMenu.Controls.Add(this.btn_addStd);
            this.panelMenu.Controls.Add(this.btn_addCrs);
            this.panelMenu.Controls.Add(this.logopanel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 612);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_restore
            // 
            this.btn_restore.BackColor = System.Drawing.Color.Maroon;
            this.btn_restore.FlatAppearance.BorderSize = 0;
            this.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_restore.ForeColor = System.Drawing.Color.White;
            this.btn_restore.Location = new System.Drawing.Point(3, 449);
            this.btn_restore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_restore.Size = new System.Drawing.Size(165, 32);
            this.btn_restore.TabIndex = 14;
            this.btn_restore.Text = "Restore BackUP";
            this.btn_restore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_Backup
            // 
            this.btn_Backup.BackColor = System.Drawing.Color.Maroon;
            this.btn_Backup.FlatAppearance.BorderSize = 0;
            this.btn_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Backup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Backup.ForeColor = System.Drawing.Color.White;
            this.btn_Backup.Location = new System.Drawing.Point(3, 413);
            this.btn_Backup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_Backup.Size = new System.Drawing.Size(165, 32);
            this.btn_Backup.TabIndex = 13;
            this.btn_Backup.Text = "Back UP";
            this.btn_Backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Backup.UseVisualStyleBackColor = false;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Maroon;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(3, 485);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(165, 32);
            this.btn_logout.TabIndex = 12;
            this.btn_logout.Text = "Log out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_rep
            // 
            this.btn_rep.BackColor = System.Drawing.Color.Maroon;
            this.btn_rep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rep.FlatAppearance.BorderSize = 0;
            this.btn_rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rep.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_rep.ForeColor = System.Drawing.Color.White;
            this.btn_rep.Location = new System.Drawing.Point(0, 377);
            this.btn_rep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rep.Name = "btn_rep";
            this.btn_rep.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_rep.Size = new System.Drawing.Size(165, 32);
            this.btn_rep.TabIndex = 11;
            this.btn_rep.Text = "Reports";
            this.btn_rep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rep.UseVisualStyleBackColor = false;
            this.btn_rep.Click += new System.EventHandler(this.btn_rep_Click);
            // 
            // btn_top
            // 
            this.btn_top.BackColor = System.Drawing.Color.Maroon;
            this.btn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_top.FlatAppearance.BorderSize = 0;
            this.btn_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_top.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_top.ForeColor = System.Drawing.Color.White;
            this.btn_top.Location = new System.Drawing.Point(0, 345);
            this.btn_top.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_top.Name = "btn_top";
            this.btn_top.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_top.Size = new System.Drawing.Size(165, 32);
            this.btn_top.TabIndex = 10;
            this.btn_top.Text = "Topics";
            this.btn_top.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_top.UseVisualStyleBackColor = false;
            this.btn_top.Click += new System.EventHandler(this.btn_top_Click);
            // 
            // btn_insCrs
            // 
            this.btn_insCrs.BackColor = System.Drawing.Color.Maroon;
            this.btn_insCrs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_insCrs.FlatAppearance.BorderSize = 0;
            this.btn_insCrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insCrs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_insCrs.ForeColor = System.Drawing.Color.White;
            this.btn_insCrs.Location = new System.Drawing.Point(0, 313);
            this.btn_insCrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_insCrs.Name = "btn_insCrs";
            this.btn_insCrs.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_insCrs.Size = new System.Drawing.Size(165, 32);
            this.btn_insCrs.TabIndex = 9;
            this.btn_insCrs.Text = "Instructor Courses";
            this.btn_insCrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insCrs.UseVisualStyleBackColor = false;
            this.btn_insCrs.Click += new System.EventHandler(this.btn_insCrs_Click);
            // 
            // btn_stdCrs
            // 
            this.btn_stdCrs.BackColor = System.Drawing.Color.Maroon;
            this.btn_stdCrs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stdCrs.FlatAppearance.BorderSize = 0;
            this.btn_stdCrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stdCrs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_stdCrs.ForeColor = System.Drawing.Color.White;
            this.btn_stdCrs.Location = new System.Drawing.Point(0, 281);
            this.btn_stdCrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_stdCrs.Name = "btn_stdCrs";
            this.btn_stdCrs.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_stdCrs.Size = new System.Drawing.Size(165, 32);
            this.btn_stdCrs.TabIndex = 8;
            this.btn_stdCrs.Text = "Student Courses";
            this.btn_stdCrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stdCrs.UseVisualStyleBackColor = false;
            this.btn_stdCrs.Click += new System.EventHandler(this.btn_stdCrs_Click);
            // 
            // btn_dept
            // 
            this.btn_dept.BackColor = System.Drawing.Color.Maroon;
            this.btn_dept.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dept.FlatAppearance.BorderSize = 0;
            this.btn_dept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_dept.ForeColor = System.Drawing.Color.White;
            this.btn_dept.Location = new System.Drawing.Point(0, 249);
            this.btn_dept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dept.Name = "btn_dept";
            this.btn_dept.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_dept.Size = new System.Drawing.Size(165, 32);
            this.btn_dept.TabIndex = 7;
            this.btn_dept.Text = "Departments";
            this.btn_dept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dept.UseVisualStyleBackColor = false;
            this.btn_dept.Click += new System.EventHandler(this.btn_dept_Click);
            // 
            // btn_addIns
            // 
            this.btn_addIns.BackColor = System.Drawing.Color.Maroon;
            this.btn_addIns.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addIns.FlatAppearance.BorderSize = 0;
            this.btn_addIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addIns.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_addIns.ForeColor = System.Drawing.Color.White;
            this.btn_addIns.Location = new System.Drawing.Point(0, 217);
            this.btn_addIns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addIns.Name = "btn_addIns";
            this.btn_addIns.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_addIns.Size = new System.Drawing.Size(165, 32);
            this.btn_addIns.TabIndex = 6;
            this.btn_addIns.Text = "Add Instructor";
            this.btn_addIns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addIns.UseVisualStyleBackColor = false;
            this.btn_addIns.Click += new System.EventHandler(this.btn_addIns_Click);
            // 
            // btn_addQ
            // 
            this.btn_addQ.BackColor = System.Drawing.Color.Maroon;
            this.btn_addQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addQ.FlatAppearance.BorderSize = 0;
            this.btn_addQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addQ.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_addQ.ForeColor = System.Drawing.Color.White;
            this.btn_addQ.Location = new System.Drawing.Point(0, 185);
            this.btn_addQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addQ.Name = "btn_addQ";
            this.btn_addQ.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_addQ.Size = new System.Drawing.Size(165, 32);
            this.btn_addQ.TabIndex = 5;
            this.btn_addQ.Text = "Add Questions";
            this.btn_addQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addQ.UseVisualStyleBackColor = false;
            this.btn_addQ.Click += new System.EventHandler(this.btn_addQ_Click);
            // 
            // btn_exmName
            // 
            this.btn_exmName.BackColor = System.Drawing.Color.Maroon;
            this.btn_exmName.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_exmName.FlatAppearance.BorderSize = 0;
            this.btn_exmName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exmName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_exmName.ForeColor = System.Drawing.Color.White;
            this.btn_exmName.Location = new System.Drawing.Point(0, 153);
            this.btn_exmName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exmName.Name = "btn_exmName";
            this.btn_exmName.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_exmName.Size = new System.Drawing.Size(165, 32);
            this.btn_exmName.TabIndex = 4;
            this.btn_exmName.Text = "Exams";
            this.btn_exmName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exmName.UseVisualStyleBackColor = false;
            this.btn_exmName.Click += new System.EventHandler(this.btn_exmName_Click);
            // 
            // btn_addExm
            // 
            this.btn_addExm.BackColor = System.Drawing.Color.Maroon;
            this.btn_addExm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addExm.FlatAppearance.BorderSize = 0;
            this.btn_addExm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addExm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_addExm.ForeColor = System.Drawing.Color.White;
            this.btn_addExm.Location = new System.Drawing.Point(0, 121);
            this.btn_addExm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addExm.Name = "btn_addExm";
            this.btn_addExm.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_addExm.Size = new System.Drawing.Size(165, 32);
            this.btn_addExm.TabIndex = 3;
            this.btn_addExm.Text = "Generate Exam";
            this.btn_addExm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addExm.UseVisualStyleBackColor = false;
            this.btn_addExm.Click += new System.EventHandler(this.btn_addExm_Click);
            // 
            // btn_addStd
            // 
            this.btn_addStd.BackColor = System.Drawing.Color.Maroon;
            this.btn_addStd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addStd.FlatAppearance.BorderSize = 0;
            this.btn_addStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addStd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_addStd.ForeColor = System.Drawing.Color.White;
            this.btn_addStd.Location = new System.Drawing.Point(0, 89);
            this.btn_addStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addStd.Name = "btn_addStd";
            this.btn_addStd.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_addStd.Size = new System.Drawing.Size(165, 32);
            this.btn_addStd.TabIndex = 2;
            this.btn_addStd.Text = "Add Student";
            this.btn_addStd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addStd.UseVisualStyleBackColor = false;
            this.btn_addStd.Click += new System.EventHandler(this.btn_addStd_Click);
            // 
            // btn_addCrs
            // 
            this.btn_addCrs.BackColor = System.Drawing.Color.Maroon;
            this.btn_addCrs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addCrs.FlatAppearance.BorderSize = 0;
            this.btn_addCrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCrs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_addCrs.ForeColor = System.Drawing.Color.White;
            this.btn_addCrs.Location = new System.Drawing.Point(0, 57);
            this.btn_addCrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addCrs.Name = "btn_addCrs";
            this.btn_addCrs.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btn_addCrs.Size = new System.Drawing.Size(165, 32);
            this.btn_addCrs.TabIndex = 1;
            this.btn_addCrs.Text = "Add Course";
            this.btn_addCrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addCrs.UseVisualStyleBackColor = false;
            this.btn_addCrs.Click += new System.EventHandler(this.btn_addCrs_Click);
            // 
            // logopanel
            // 
            this.logopanel.Controls.Add(this.pictureBox1);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(165, 57);
            this.logopanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(165, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 57);
            this.panel1.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(419, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(95, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Home";
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(165, 57);
            this.DesktopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(981, 555);
            this.DesktopPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 612);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btn_rep;
        private Button btn_top;
        private Button btn_insCrs;
        private Button btn_stdCrs;
        private Button btn_dept;
        private Button btn_addIns;
        private Button btn_addQ;
        private Button btn_exmName;
        private Button btn_addExm;
        private Button btn_addStd;
        private Button btn_addCrs;
        private Panel logopanel;
        private Panel panel1;
        private Label lbl_title;
        private Panel DesktopPanel;
        private Button btn_logout;
        private Button btn_restore;
        private Button btn_Backup;
        private PictureBox pictureBox1;
    }
}

