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
    public partial class DueAmount : Form
    {
        public DueAmount()
        {
            InitializeComponent();
        }

        private void DueAmount_Load(object sender, EventArgs e)
        {
           StudentProfile sp=new StudentProfile();
           List<string> session = sp.getSession();
           for (int i = 0; i < session.Count; i++) {
               session_comboBox.Items.Add(session[i]);
           }


        }

        private void session_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentPayment spay = new StudentPayment();
            due_dataGridView.DataSource = spay.getDueAmountOfStudents(session_comboBox.Text);
        }
    }
}
