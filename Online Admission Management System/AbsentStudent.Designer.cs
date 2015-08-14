namespace CoachingManagementSystem
{
    partial class AbsentStudent
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
            this.session_comboBox = new System.Windows.Forms.ComboBox();
            this.absentStudent_dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.absentStudent_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // session_comboBox
            // 
            this.session_comboBox.FormattingEnabled = true;
            this.session_comboBox.Location = new System.Drawing.Point(249, 27);
            this.session_comboBox.Name = "session_comboBox";
            this.session_comboBox.Size = new System.Drawing.Size(182, 21);
            this.session_comboBox.TabIndex = 0;
            this.session_comboBox.SelectedIndexChanged += new System.EventHandler(this.session_comboBox_SelectedIndexChanged);
            // 
            // absentStudent_dataGridView
            // 
            this.absentStudent_dataGridView.AllowUserToAddRows = false;
            this.absentStudent_dataGridView.AllowUserToDeleteRows = false;
            this.absentStudent_dataGridView.AllowUserToResizeColumns = false;
            this.absentStudent_dataGridView.AllowUserToResizeRows = false;
            this.absentStudent_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.absentStudent_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.absentStudent_dataGridView.Location = new System.Drawing.Point(95, 73);
            this.absentStudent_dataGridView.Name = "absentStudent_dataGridView";
            this.absentStudent_dataGridView.RowHeadersVisible = false;
            this.absentStudent_dataGridView.Size = new System.Drawing.Size(544, 287);
            this.absentStudent_dataGridView.TabIndex = 1;
            this.absentStudent_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.absentStudent_dataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AbsentStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.absentStudent_dataGridView);
            this.Controls.Add(this.session_comboBox);
            this.Name = "AbsentStudent";
            this.Text = "AbsentStudent";
            this.Load += new System.EventHandler(this.AbsentStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.absentStudent_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox session_comboBox;
        private System.Windows.Forms.DataGridView absentStudent_dataGridView;
        private System.Windows.Forms.Button button1;
    }
}