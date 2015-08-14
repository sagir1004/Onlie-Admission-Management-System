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
    public partial class BatchWisePrintResult : Form
    {
        string date = "";
        public BatchWisePrintResult()
        {
            InitializeComponent();
        }

        private void batch_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StudentResult sr=new StudentResult();
                batchWise_dataGridView.DataSource = sr.getBatchwiseResult(session_comboBox.Text,batch_comboBox.Text,date);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BatchWisePrintResult_Load(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile();
            List<string> sesssion = sp.getSession();
            List<string> batch = sp.getBatch();
            for (int i = 0; i < sesssion.Count; i++) {
                session_comboBox.Items.Add(sesssion[i]);
            }
            for (int i = 0; i < batch.Count; i++) {
                batch_comboBox.Items.Add(batch[i]);
            }
            date = dateTimePicker1.Value.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
