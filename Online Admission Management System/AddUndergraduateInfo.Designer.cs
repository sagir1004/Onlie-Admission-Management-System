﻿namespace CoachingManagementSystem
{
    partial class AddUndergraduateInfo
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
            this.under_Id_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.univ_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subject_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.merit_textBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // under_Id_textBox
            // 
            this.under_Id_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.under_Id_textBox.Location = new System.Drawing.Point(240, 64);
            this.under_Id_textBox.Name = "under_Id_textBox";
            this.under_Id_textBox.Size = new System.Drawing.Size(155, 22);
            this.under_Id_textBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "University:";
            // 
            // univ_textBox
            // 
            this.univ_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.univ_textBox.Location = new System.Drawing.Point(239, 117);
            this.univ_textBox.Name = "univ_textBox";
            this.univ_textBox.Size = new System.Drawing.Size(208, 22);
            this.univ_textBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject:";
            // 
            // subject_textBox
            // 
            this.subject_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_textBox.Location = new System.Drawing.Point(240, 174);
            this.subject_textBox.Name = "subject_textBox";
            this.subject_textBox.Size = new System.Drawing.Size(206, 22);
            this.subject_textBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Merit Position:";
            // 
            // merit_textBox
            // 
            this.merit_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merit_textBox.Location = new System.Drawing.Point(241, 220);
            this.merit_textBox.Name = "merit_textBox";
            this.merit_textBox.Size = new System.Drawing.Size(102, 22);
            this.merit_textBox.TabIndex = 9;
            this.merit_textBox.TextChanged += new System.EventHandler(this.merit_textBox_TextChanged);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(276, 276);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(119, 39);
            this.save_button.TabIndex = 10;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // AddUndergraduateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 423);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.merit_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subject_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.univ_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.under_Id_textBox);
            this.Controls.Add(this.label1);
            this.Name = "AddUndergraduateInfo";
            this.Text = "AddUndergraduateInfo";
            this.Load += new System.EventHandler(this.AddUndergraduateInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox under_Id_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox univ_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subject_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox merit_textBox;
        private System.Windows.Forms.Button save_button;
    }
}