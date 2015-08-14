namespace CoachingManagementSystem
{
    partial class StudentWiseResultPrint
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
            this.Id_comboBox = new System.Windows.Forms.ComboBox();
            this.studentwise_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentwise_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_comboBox
            // 
            this.Id_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_comboBox.FormattingEnabled = true;
            this.Id_comboBox.Location = new System.Drawing.Point(268, 18);
            this.Id_comboBox.Name = "Id_comboBox";
            this.Id_comboBox.Size = new System.Drawing.Size(153, 24);
            this.Id_comboBox.TabIndex = 0;
            this.Id_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studentwise_dataGridView
            // 
            this.studentwise_dataGridView.AllowUserToAddRows = false;
            this.studentwise_dataGridView.AllowUserToDeleteRows = false;
            this.studentwise_dataGridView.AllowUserToResizeColumns = false;
            this.studentwise_dataGridView.AllowUserToResizeRows = false;
            this.studentwise_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentwise_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentwise_dataGridView.Location = new System.Drawing.Point(57, 69);
            this.studentwise_dataGridView.Name = "studentwise_dataGridView";
            this.studentwise_dataGridView.RowHeadersVisible = false;
            this.studentwise_dataGridView.Size = new System.Drawing.Size(628, 320);
            this.studentwise_dataGridView.TabIndex = 1;
            // 
            // StudentWiseResultPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.studentwise_dataGridView);
            this.Controls.Add(this.Id_comboBox);
            this.Name = "StudentWiseResultPrint";
            this.Text = "StudentWiseResultPrint";
            this.Load += new System.EventHandler(this.StudentWiseResultPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentwise_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Id_comboBox;
        private System.Windows.Forms.DataGridView studentwise_dataGridView;
    }
}