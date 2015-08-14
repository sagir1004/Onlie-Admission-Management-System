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
    public partial class AddNewStudent : Form
    {
        Byte[] buffer = new Byte[1000];
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void  Browse_button_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
      {
    // now open the file ..
        FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);

        Path_label.Text = openFileDialog.FileName;
         BinaryReader br = new BinaryReader(fs);
          buffer = br.ReadBytes((Int32)fs.Length);
          br.Close();
          fs.Close();
       }

            
        }

        private void AddStudent_button_Click(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile();
            StudentPayment pay = new StudentPayment();
            string id = Id_textBox.Text;
            string session = Session_textBox.Text;
            string batch = Batch_textBox.Text;
            string name = Name_textBox.Text;
            Byte [] image = buffer;
            string fname = FatherName_textBox.Text;
            string mname = MotherName_textBox.Text;
            string foccupation = FatherOccupation_textBox.Text;
            string paddress = PresentAddress_textBox.Text;
            string stdmbl = stdmbl_textBox.Text;
            string grdmbl = Guardianmbl_textBox.Text;
            string blood=BloodGroup_comboBox.SelectedItem.ToString();
            string payment = Payment_textBox.Text;
            string infomedia = InfoMedia_textBox.Text;
            string schoolname = school_textBox.Text;
            string sscgpa = SSC_Gpa_textBox.Text;
            string sscpassyear = SSCPassingYear_comboBox.SelectedItem.ToString();
            string collegename = College_textBox.Text;
            string hscgpa = hscgpa_textBox.Text;
            string hscpassyear = HSCPassingYear_comboBox.SelectedItem.ToString();
            try
            {
               
                sp.AddStudent(id,session,batch,name,image,fname,mname,foccupation,paddress,stdmbl,grdmbl,blood,payment,infomedia);
                sp.AddEducationalBackground(id, "SSC", schoolname, sscgpa, sscpassyear);
                sp.AddEducationalBackground(id, "HSC", collegename, hscgpa, hscpassyear);
                pay.insert_DuePayment(id, payment, "Not Paid");
                MessageBox.Show("Information Saved Successfully");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString()+ex.StackTrace);
            }

        }

        private void AddNewStudent_Load(object sender, EventArgs e)
        {
            this.BloodGroup_comboBox.Items.Add("A+");
            this.BloodGroup_comboBox.Items.Add("A-");
            this.BloodGroup_comboBox.Items.Add("B+");
            this.BloodGroup_comboBox.Items.Add("B-");
            this.BloodGroup_comboBox.Items.Add("AB+");
            this.BloodGroup_comboBox.Items.Add("AB-");
            this.BloodGroup_comboBox.Items.Add("O+");
            this.BloodGroup_comboBox.Items.Add("O-");
            for (int i = 2000; i < 2020; i++) {
                HSCPassingYear_comboBox.Items.Add(i.ToString());
                SSCPassingYear_comboBox.Items.Add(i.ToString());
            }
            this.gender_comboBox.Items.Add("Male");
            this.gender_comboBox.Items.Add("Female");






        }
    }
}
