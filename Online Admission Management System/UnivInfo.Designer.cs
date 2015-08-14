namespace CoachingManagementSystem
{
    partial class UnivInfo
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
            this.session_comboBox = new System.Windows.Forms.ComboBox();
            this.univInfo_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.univInfo_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Session:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // session_comboBox
            // 
            this.session_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.session_comboBox.FormattingEnabled = true;
            this.session_comboBox.Location = new System.Drawing.Point(292, 61);
            this.session_comboBox.Name = "session_comboBox";
            this.session_comboBox.Size = new System.Drawing.Size(175, 24);
            this.session_comboBox.TabIndex = 1;
            this.session_comboBox.SelectedIndexChanged += new System.EventHandler(this.session_comboBox_SelectedIndexChanged);
            // 
            // univInfo_dataGridView
            // 
            this.univInfo_dataGridView.AllowUserToAddRows = false;
            this.univInfo_dataGridView.AllowUserToDeleteRows = false;
            this.univInfo_dataGridView.AllowUserToResizeColumns = false;
            this.univInfo_dataGridView.AllowUserToResizeRows = false;
            this.univInfo_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.univInfo_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.univInfo_dataGridView.Location = new System.Drawing.Point(43, 104);
            this.univInfo_dataGridView.Name = "univInfo_dataGridView";
            this.univInfo_dataGridView.RowHeadersVisible = false;
            this.univInfo_dataGridView.Size = new System.Drawing.Size(668, 354);
            this.univInfo_dataGridView.TabIndex = 2;
            // 
            // UnivInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 489);
            this.Controls.Add(this.univInfo_dataGridView);
            this.Controls.Add(this.session_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "UnivInfo";
            this.Text = "UnivInfo";
            this.Load += new System.EventHandler(this.UnivInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.univInfo_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox session_comboBox;
        private System.Windows.Forms.DataGridView univInfo_dataGridView;
    }
}