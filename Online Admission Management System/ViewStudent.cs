using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace CoachingManagementSystem
{
   
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile();
            showInfo_comboBox.Items.Add("View All Information Of A Student");
            showInfo_comboBox.Items.Add("Students Of Particular Blood Group");
            showInfo_comboBox.Items.Add("University Information And Educational Background");
            showInfo_comboBox.Items.Add("Number Of Student In Universities");
            List<string> ids;
            ids = sp.getID();
            for (int j = 0; j < ids.Count; j++)
            {
               ID_comboBox.Items.Add(ids[j]);
            }
           

        }
       

        private void showInfo_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
             
            if (showInfo_comboBox.SelectedIndex == 0)
            {
                id_label.Visible = true;
                ID_comboBox.Visible = true;
             }
            else if (showInfo_comboBox.SelectedIndex == 1) {
                ShowBloodGroup sbp = new ShowBloodGroup();
                sbp.Show();
                this.Hide();
                }
            else if (showInfo_comboBox.SelectedIndex == 2) {
                UnivInfo ui = new UnivInfo();
                ui.Show();
                this.Hide();
            }
            else if (showInfo_comboBox.SelectedIndex == 3) {
                StudentNumberInUniv ob = new StudentNumberInUniv();
                ob.Show();
                this.Hide();
            }
        }

        private void ID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StudentProfile sp = new StudentProfile();
                image.Visible = true;
                ssc_label.Visible = true;
                hsc_label.Visible = true;
                DataTable dt = sp.getInformationOfAStudent(ID_comboBox.Text);
                DataTable dt1 = sp.getEduBackOfAStudent(ID_comboBox.Text);
                session_label.Text = "Session: " + dt.Rows[0].Field<string>(1);
                name_label.Text = "Name :" + dt.Rows[0].Field<string>(2);
                fname_label.Text = "Father Name: " + dt.Rows[0].Field<string>(3);
                mname_label.Text = "Mother Name: " + dt.Rows[0].Field<string>(4);
                foccupation_label.Text = "Father's Ocuupation: " + dt.Rows[0].Field<string>(5);
                blood_label.Text = "Blood Group: " + dt.Rows[0].Field<string>(7);
                paddress_label.Text = "Present Address: " + dt.Rows[0].Field<string>(6);
                amntpayment_label.Text = "Total Payment: " + dt.Rows[0].Field<string>(14);
                infomedia_label.Text = "Info Media: " + dt.Rows[0].Field<string>(8);
                batch_label.Text = "Batch: " + dt.Rows[0].Field<string>(9);
                stdmbl_label.Text = "Student's Mobile No: " + dt.Rows[0].Field<string>(10);
                grdmbl_label.Text = "Guardian's Mobile No: " + dt.Rows[0].Field<string>(11);
                gender_label.Text = "Gender: " + dt.Rows[0].Field<string>(13);
                school_label.Text = "School Name: " + dt1.Rows[1].Field<string>(2);
                ssc_gpa_label.Text = "GPA: " + dt1.Rows[1].Field<string>(3);
                ssc_passyear_label.Text = "Passing Year: " + dt1.Rows[1].Field<string>(4);
                college_label.Text = "College Name: " + dt1.Rows[0].Field<string>(2);
                hsc_gpa_label.Text = "GPA: " + dt1.Rows[0].Field<string>(3);
                hsc_passyear_label.Text = "Passing Year: " + dt1.Rows[0].Field<string>(4);
             if (pictureBox1.Image != null)
             {
             pictureBox1.Image.Dispose();
           }
        //using filestream object write the column as bytes and store 
         FileStream FS1 = new FileStream("image.jpg", FileMode.Create);    
                Byte[] blob = (Byte[])dt.Rows[0].Field<Byte[]>(12);
                FS1.Write(blob, 0, blob.Length);
                FS1.Close();
                FS1 = null;
                pictureBox1.Image = Image.FromFile("image.jpg");
                 pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Refresh();
        
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            }

        private void bloodGroup_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

         }
    }
}
