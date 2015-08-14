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
    public partial class StudentWiseResultPrint : Form
    {
        public StudentWiseResultPrint()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentResult sr = new StudentResult();
            studentwise_dataGridView.DataSource = sr.getResultOfSelectedStudent(Id_comboBox.Text);
        }

        private void StudentWiseResultPrint_Load(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile();
            List<string> id = sp.getID();
            for (int i = 0; i < id.Count; i++) {
                Id_comboBox.Items.Add(id[i]);
            }
            Id_comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Id_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
