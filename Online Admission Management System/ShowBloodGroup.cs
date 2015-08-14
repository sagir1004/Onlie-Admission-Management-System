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
    public partial class ShowBloodGroup : Form
    {
        public ShowBloodGroup()
        {
            InitializeComponent();
        }

        private void ShowBloodGroup_Load(object sender, EventArgs e)
        {
            this.bloodGroup_comboBox.Items.Add("A+");
            this.bloodGroup_comboBox.Items.Add("A-");
            this.bloodGroup_comboBox.Items.Add("B+");
            this.bloodGroup_comboBox.Items.Add("B-");
            this.bloodGroup_comboBox.Items.Add("AB+");
            this.bloodGroup_comboBox.Items.Add("AB-");
            this.bloodGroup_comboBox.Items.Add("O+");
            this.bloodGroup_comboBox.Items.Add("O-");
        }

        private void bloodGroup_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile();
            bloodGroup_dataGridView.DataSource = sp.getBloodGroupOfStudent(bloodGroup_comboBox.SelectedItem.ToString());
        }
    }
}
