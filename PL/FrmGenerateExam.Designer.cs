
namespace PL
{
    partial class FrmGenerateExam
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
            this.nudNumTF = new System.Windows.Forms.NumericUpDown();
            this.nudNumMCQ = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxCourseName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumTF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumMCQ)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumTF
            // 
            this.nudNumTF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudNumTF.Location = new System.Drawing.Point(412, 172);
            this.nudNumTF.Name = "nudNumTF";
            this.nudNumTF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudNumTF.Size = new System.Drawing.Size(239, 28);
            this.nudNumTF.TabIndex = 78;
            this.nudNumTF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudNumMCQ
            // 
            this.nudNumMCQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudNumMCQ.Location = new System.Drawing.Point(412, 96);
            this.nudNumMCQ.Name = "nudNumMCQ";
            this.nudNumMCQ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudNumMCQ.Size = new System.Drawing.Size(239, 28);
            this.nudNumMCQ.TabIndex = 77;
            this.nudNumMCQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(412, 317);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(239, 31);
            this.txtName.TabIndex = 76;
            // 
            // cbxCourseName
            // 
            this.cbxCourseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCourseName.FormattingEnabled = true;
            this.cbxCourseName.Location = new System.Drawing.Point(412, 249);
            this.cbxCourseName.Name = "cbxCourseName";
            this.cbxCourseName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxCourseName.Size = new System.Drawing.Size(239, 29);
            this.cbxCourseName.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(185, 323);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(221, 31);
            this.label3.TabIndex = 74;
            this.label3.Text = "Exam Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(185, 248);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(221, 31);
            this.label2.TabIndex = 73;
            this.label2.Text = "Course Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(331, 405);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(151, 51);
            this.btnCreate.TabIndex = 72;
            this.btnCreate.Text = "Generate";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(185, 167);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 71;
            this.label1.Text = "Num Question T,F :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnter
            // 
            this.lblEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEnter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.Color.Maroon;
            this.lblEnter.Location = new System.Drawing.Point(185, 91);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnter.Size = new System.Drawing.Size(221, 31);
            this.lblEnter.TabIndex = 70;
            this.lblEnter.Text = "Num Question MCQ :";
            this.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmGenerateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 549);
            this.Controls.Add(this.nudNumTF);
            this.Controls.Add(this.nudNumMCQ);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbxCourseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnter);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGenerateExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmGenerateExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumTF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumMCQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumTF;
        private System.Windows.Forms.NumericUpDown nudNumMCQ;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxCourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnter;
    }
}