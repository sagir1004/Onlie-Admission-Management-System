namespace CoachingManagementSystem
{
    partial class StudentNumberInUniv
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
            this.number_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.number_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // session_comboBox
            // 
            this.session_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.session_comboBox.FormattingEnabled = true;
            this.session_comboBox.Location = new System.Drawing.Point(268, 47);
            this.session_comboBox.Name = "session_comboBox";
            this.session_comboBox.Size = new System.Drawing.Size(173, 24);
            this.session_comboBox.TabIndex = 0;
            this.session_comboBox.SelectedIndexChanged += new System.EventHandler(this.session_comboBox_SelectedIndexChanged);
            // 
            // number_dataGridView
            // 
            this.number_dataGridView.AllowUserToAddRows = false;
            this.number_dataGridView.AllowUserToDeleteRows = false;
            this.number_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.number_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.number_dataGridView.Location = new System.Drawing.Point(113, 96);
            this.number_dataGridView.Name = "number_dataGridView";
            this.number_dataGridView.RowHeadersVisible = false;
            this.number_dataGridView.Size = new System.Drawing.Size(492, 389);
            this.number_dataGridView.TabIndex = 1;
            // 
            // StudentNumberInUniv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 523);
            this.Controls.Add(this.number_dataGridView);
            this.Controls.Add(this.session_comboBox);
            this.Name = "StudentNumberInUniv";
            this.Text = "StudentNumberInUniv";
            this.Load += new System.EventHandler(this.StudentNumberInUniv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.number_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox session_comboBox;
        private System.Windows.Forms.DataGridView number_dataGridView;
    }
}