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
    public partial class UnivInfo : Form
    {
        public UnivInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UnivInfo_Load(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile();
            List<string> s = sp.getSession();
            for (int i = 0; i < s.Count; i++) {
                session_comboBox.Items.Add(s[i]);
            }
         
        }

        private void session_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

               
                StudentProfile sp = new StudentProfile();
                univInfo_dataGridView.DataSource = sp.getUniversityInfo(session_comboBox.SelectedItem.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            }

    }
}
