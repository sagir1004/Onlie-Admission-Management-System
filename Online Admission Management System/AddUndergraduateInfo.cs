using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace CoachingManagementSystem
{
    public partial class AddUndergraduateInfo : Form
    {
        public AddUndergraduateInfo()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile();
            string id=under_Id_textBox.Text;
            string university=univ_textBox.Text;
            string subject=subject_textBox.Text;
            string merit=merit_textBox.Text;
            try
            {
                sp.addUndergraduateInfo(id, university, subject, merit);
                MessageBox.Show("Information Saved Successfully");
            }
            catch (Exception ) {
                MessageBox.Show("Informations Already Exists");
            }
        }

        private void merit_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUndergraduateInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
