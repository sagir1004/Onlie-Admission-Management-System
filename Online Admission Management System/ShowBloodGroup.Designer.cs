namespace CoachingManagementSystem
{
    partial class ShowBloodGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.bloodGroup_comboBox = new System.Windows.Forms.ComboBox();
            this.bloodGroup_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroup_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Blood Group:";
            // 
            // bloodGroup_comboBox
            // 
            this.bloodGroup_comboBox.FormattingEnabled = true;
            this.bloodGroup_comboBox.Location = new System.Drawing.Point(291, 53);
            this.bloodGroup_comboBox.Name = "bloodGroup_comboBox";
            this.bloodGroup_comboBox.Size = new System.Drawing.Size(125, 21);
            this.bloodGroup_comboBox.TabIndex = 1;
            this.bloodGroup_comboBox.SelectedIndexChanged += new System.EventHandler(this.bloodGroup_comboBox_SelectedIndexChanged);
            // 
            // bloodGroup_dataGridView
            // 
            this.bloodGroup_dataGridView.AllowUserToAddRows = false;
            this.bloodGroup_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bloodGroup_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bloodGroup_dataGridView.Location = new System.Drawing.Point(100, 98);
            this.bloodGroup_dataGridView.Name = "bloodGroup_dataGridView";
            this.bloodGroup_dataGridView.RowHeadersVisible = false;
            this.bloodGroup_dataGridView.Size = new System.Drawing.Size(478, 316);
            this.bloodGroup_dataGridView.TabIndex = 2;
            // 
            // ShowBloodGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 493);
            this.Controls.Add(this.bloodGroup_dataGridView);
            this.Controls.Add(this.bloodGroup_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "ShowBloodGroup";
            this.Text = "ShowBloodGroup";
            this.Load += new System.EventHandler(this.ShowBloodGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroup_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bloodGroup_comboBox;
        private System.Windows.Forms.DataGridView bloodGroup_dataGridView;
    }
}