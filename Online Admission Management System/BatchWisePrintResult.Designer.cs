namespace CoachingManagementSystem
{
    partial class BatchWisePrintResult
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
            this.batch_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.batchWise_dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.batchWise_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // session_comboBox
            // 
            this.session_comboBox.FormattingEnabled = true;
            this.session_comboBox.Location = new System.Drawing.Point(251, 29);
            this.session_comboBox.Name = "session_comboBox";
            this.session_comboBox.Size = new System.Drawing.Size(121, 21);
            this.session_comboBox.TabIndex = 0;
            // 
            // batch_comboBox
            // 
            this.batch_comboBox.FormattingEnabled = true;
            this.batch_comboBox.Location = new System.Drawing.Point(252, 72);
            this.batch_comboBox.Name = "batch_comboBox";
            this.batch_comboBox.Size = new System.Drawing.Size(121, 21);
            this.batch_comboBox.TabIndex = 1;
            this.batch_comboBox.SelectedIndexChanged += new System.EventHandler(this.batch_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Session:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Batch:";
            // 
            // batchWise_dataGridView
            // 
            this.batchWise_dataGridView.AllowUserToAddRows = false;
            this.batchWise_dataGridView.AllowUserToDeleteRows = false;
            this.batchWise_dataGridView.AllowUserToResizeRows = false;
            this.batchWise_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.batchWise_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batchWise_dataGridView.Location = new System.Drawing.Point(55, 99);
            this.batchWise_dataGridView.Name = "batchWise_dataGridView";
            this.batchWise_dataGridView.RowHeadersVisible = false;
            this.batchWise_dataGridView.Size = new System.Drawing.Size(575, 302);
            this.batchWise_dataGridView.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(449, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // BatchWisePrintResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 446);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.batchWise_dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.batch_comboBox);
            this.Controls.Add(this.session_comboBox);
            this.Name = "BatchWisePrintResult";
            this.Text = "BatchWisePrintResult";
            this.Load += new System.EventHandler(this.BatchWisePrintResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batchWise_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox session_comboBox;
        private System.Windows.Forms.ComboBox batch_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView batchWise_dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}