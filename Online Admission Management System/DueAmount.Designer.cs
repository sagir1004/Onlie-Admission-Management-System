namespace CoachingManagementSystem
{
    partial class DueAmount
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
            this.label1 = new System.Windows.Forms.Label();
            this.due_dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.due_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // session_comboBox
            // 
            this.session_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.session_comboBox.FormattingEnabled = true;
            this.session_comboBox.Location = new System.Drawing.Point(216, 21);
            this.session_comboBox.Name = "session_comboBox";
            this.session_comboBox.Size = new System.Drawing.Size(160, 24);
            this.session_comboBox.TabIndex = 0;
            this.session_comboBox.SelectedIndexChanged += new System.EventHandler(this.session_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Session:";
            // 
            // due_dataGridView
            // 
            this.due_dataGridView.AllowUserToAddRows = false;
            this.due_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.due_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.due_dataGridView.Location = new System.Drawing.Point(42, 69);
            this.due_dataGridView.Name = "due_dataGridView";
            this.due_dataGridView.RowHeadersVisible = false;
            this.due_dataGridView.Size = new System.Drawing.Size(581, 303);
            this.due_dataGridView.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DueAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.due_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.session_comboBox);
            this.Name = "DueAmount";
            this.Text = "DueAmount";
            this.Load += new System.EventHandler(this.DueAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.due_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox session_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView due_dataGridView;
        private System.Windows.Forms.Button button1;
    }
}