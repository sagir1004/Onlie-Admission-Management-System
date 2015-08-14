namespace CoachingManagementSystem
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyExamAndAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertExamMarksAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absentStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentSectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.individualPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPaymentOfAMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDueAmountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.dailyExamAndAttendanceToolStripMenuItem,
            this.paymentSectionToolStripMenuItem,
            this.paymentSectionToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.deleteStudToolStripMenuItem,
            this.viewStudentInformationToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(131, 25);
            this.studentToolStripMenuItem.Text = "Student Section";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // deleteStudToolStripMenuItem
            // 
            this.deleteStudToolStripMenuItem.Name = "deleteStudToolStripMenuItem";
            this.deleteStudToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            this.deleteStudToolStripMenuItem.Text = "Add Undergraduate Information Of A Student";
            this.deleteStudToolStripMenuItem.Click += new System.EventHandler(this.deleteStudToolStripMenuItem_Click);
            // 
            // viewStudentInformationToolStripMenuItem
            // 
            this.viewStudentInformationToolStripMenuItem.Name = "viewStudentInformationToolStripMenuItem";
            this.viewStudentInformationToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            this.viewStudentInformationToolStripMenuItem.Text = "View Student Information";
            this.viewStudentInformationToolStripMenuItem.Click += new System.EventHandler(this.viewStudentInformationToolStripMenuItem_Click);
            // 
            // dailyExamAndAttendanceToolStripMenuItem
            // 
            this.dailyExamAndAttendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertExamMarksAttendanceToolStripMenuItem,
            this.absentStudentsToolStripMenuItem});
            this.dailyExamAndAttendanceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyExamAndAttendanceToolStripMenuItem.Name = "dailyExamAndAttendanceToolStripMenuItem";
            this.dailyExamAndAttendanceToolStripMenuItem.Size = new System.Drawing.Size(214, 25);
            this.dailyExamAndAttendanceToolStripMenuItem.Text = "Daily Exam and Attendance ";
            // 
            // insertExamMarksAttendanceToolStripMenuItem
            // 
            this.insertExamMarksAttendanceToolStripMenuItem.Name = "insertExamMarksAttendanceToolStripMenuItem";
            this.insertExamMarksAttendanceToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.insertExamMarksAttendanceToolStripMenuItem.Text = "Insert Marks and Attendance";
            this.insertExamMarksAttendanceToolStripMenuItem.Click += new System.EventHandler(this.insertExamMarksAttendanceToolStripMenuItem_Click);
            // 
            // absentStudentsToolStripMenuItem
            // 
            this.absentStudentsToolStripMenuItem.Name = "absentStudentsToolStripMenuItem";
            this.absentStudentsToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.absentStudentsToolStripMenuItem.Text = "Absent Students";
            this.absentStudentsToolStripMenuItem.Click += new System.EventHandler(this.absentStudentsToolStripMenuItem_Click);
            // 
            // paymentSectionToolStripMenuItem
            // 
            this.paymentSectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentWiseToolStripMenuItem,
            this.batchWiseToolStripMenuItem});
            this.paymentSectionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentSectionToolStripMenuItem.Name = "paymentSectionToolStripMenuItem";
            this.paymentSectionToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.paymentSectionToolStripMenuItem.Text = "Result Sheet";
            // 
            // studentWiseToolStripMenuItem
            // 
            this.studentWiseToolStripMenuItem.Name = "studentWiseToolStripMenuItem";
            this.studentWiseToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.studentWiseToolStripMenuItem.Text = "Student Wise";
            this.studentWiseToolStripMenuItem.Click += new System.EventHandler(this.studentWiseToolStripMenuItem_Click);
            // 
            // batchWiseToolStripMenuItem
            // 
            this.batchWiseToolStripMenuItem.Name = "batchWiseToolStripMenuItem";
            this.batchWiseToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.batchWiseToolStripMenuItem.Text = "Batch Wise";
            this.batchWiseToolStripMenuItem.Click += new System.EventHandler(this.batchWiseToolStripMenuItem_Click);
            // 
            // paymentSectionToolStripMenuItem1
            // 
            this.paymentSectionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualPaymentToolStripMenuItem,
            this.totalPaymentOfAMonthToolStripMenuItem,
            this.getDueAmountInformationToolStripMenuItem});
            this.paymentSectionToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentSectionToolStripMenuItem1.Name = "paymentSectionToolStripMenuItem1";
            this.paymentSectionToolStripMenuItem1.Size = new System.Drawing.Size(138, 25);
            this.paymentSectionToolStripMenuItem1.Text = "Payment Section";
            this.paymentSectionToolStripMenuItem1.Click += new System.EventHandler(this.paymentSectionToolStripMenuItem1_Click);
            // 
            // individualPaymentToolStripMenuItem
            // 
            this.individualPaymentToolStripMenuItem.Name = "individualPaymentToolStripMenuItem";
            this.individualPaymentToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.individualPaymentToolStripMenuItem.Text = "Add A Payment";
            this.individualPaymentToolStripMenuItem.Click += new System.EventHandler(this.individualPaymentToolStripMenuItem_Click);
            // 
            // totalPaymentOfAMonthToolStripMenuItem
            // 
            this.totalPaymentOfAMonthToolStripMenuItem.Name = "totalPaymentOfAMonthToolStripMenuItem";
            this.totalPaymentOfAMonthToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.totalPaymentOfAMonthToolStripMenuItem.Text = "Individual Payment";
            this.totalPaymentOfAMonthToolStripMenuItem.Click += new System.EventHandler(this.totalPaymentOfAMonthToolStripMenuItem_Click);
            // 
            // getDueAmountInformationToolStripMenuItem
            // 
            this.getDueAmountInformationToolStripMenuItem.Name = "getDueAmountInformationToolStripMenuItem";
            this.getDueAmountInformationToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.getDueAmountInformationToolStripMenuItem.Text = "Get Due Amount Information";
            this.getDueAmountInformationToolStripMenuItem.Click += new System.EventHandler(this.getDueAmountInformationToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 355);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyExamAndAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentSectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertExamMarksAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalPaymentOfAMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absentStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDueAmountInformationToolStripMenuItem;
    }
}