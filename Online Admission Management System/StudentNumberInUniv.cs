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
    public partial class StudentNumberInUniv : Form
    {
        public StudentNumberInUniv()
        {
            InitializeComponent();
        }

        private void StudentNumberInUniv_Load(object sender, EventArgs e)
        {
            StudentProfile sp=new StudentProfile();
            List<string> s = sp.getSession();
            for (int i = 0; i < s.Count;i++ )
            {
                session_comboBox.Items.Add(s[i]);
            }
        }

        private void session_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentProfile sp=new StudentProfile();
            number_dataGridView.DataSource = sp.getStudentNumberInUniversity(session_comboBox.SelectedItem.ToString());
        }

    }
}
