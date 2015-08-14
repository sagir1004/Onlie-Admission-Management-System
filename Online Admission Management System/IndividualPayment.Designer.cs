namespace CoachingManagementSystem
{
    partial class IndividualPayment
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
            this.Id_comboBox = new System.Windows.Forms.ComboBox();
            this.individual_dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.individual_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select ID:";
            // 
            // Id_comboBox
            // 
            this.Id_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_comboBox.FormattingEnabled = true;
            this.Id_comboBox.Location = new System.Drawing.Point(273, 28);
            this.Id_comboBox.Name = "Id_comboBox";
            this.Id_comboBox.Size = new System.Drawing.Size(155, 24);
            this.Id_comboBox.TabIndex = 1;
            this.Id_comboBox.SelectedIndexChanged += new System.EventHandler(this.Id_comboBox_SelectedIndexChanged);
            // 
            // individual_dataGridView
            // 
            this.individual_dataGridView.AllowUserToAddRows = false;
            this.individual_dataGridView.AllowUserToDeleteRows = false;
            this.individual_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.individual_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.individual_dataGridView.Location = new System.Drawing.Point(136, 77);
            this.individual_dataGridView.Name = "individual_dataGridView";
            this.individual_dataGridView.RowHeadersVisible = false;
            this.individual_dataGridView.Size = new System.Drawing.Size(467, 288);
            this.individual_dataGridView.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IndividualPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.individual_dataGridView);
            this.Controls.Add(this.Id_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "IndividualPayment";
            this.Text = "IndividualPayment";
            this.Load += new System.EventHandler(this.IndividualPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.individual_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Id_comboBox;
        private System.Windows.Forms.DataGridView individual_dataGridView;
        private System.Windows.Forms.Button button1;
    }
}