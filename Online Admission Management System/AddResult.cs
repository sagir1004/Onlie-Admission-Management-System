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
    public partial class AddResult : Form
    {
        string date="";
        public AddResult()
        {
            InitializeComponent();
        }

        private void AddResult_Load(object sender, EventArgs e)
        {
            StudentProfile sp=new StudentProfile();
             List<string> session = sp.getSession();
             for (int i = 0; i < session.Count; i++) {
                 session_comboBox.Items.Add(session[i]);
             }
           date = dateTimePicker1.Value.ToShortDateString();
           subject_comboBox.Items.Add("Mathematics");
           subject_comboBox.Items.Add("Physics");
           subject_comboBox.Items.Add("Chemistry");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value.ToShortDateString();
        }

        private void session_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentProfile sp=new StudentProfile();
            List<string> id=sp.getIdOfSelectedSession(session_comboBox.Text);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Written");
            dt.Columns.Add("MCQ");
            dt.Columns.Add("Remarks");
            DataRow dr;
            for (int i = 0; i < id.Count; i++)
            {
                dr = dt.NewRow();
                dr["ID"] = id[i];
                dt.Rows.Add(dr);
            }
            this.InsertMark_dataGridView.DataSource = dt;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                StudentResult sr = new StudentResult();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Subject");
                dt.Columns.Add("Date");
                dt.Columns.Add("Written");
                dt.Columns.Add("MCQ");
                dt.Columns.Add("Total");
                dt.Columns.Add("Remarks");
                DataRow dr;
                int length = InsertMark_dataGridView.Rows.Count;
                for (int i = 0; i < length; i++) {
                    dr = dt.NewRow();
                    dr["ID"] = InsertMark_dataGridView.Rows[i].Cells[0].Value.ToString();
                    dr["Subject"] = subject_comboBox.Text;
                    dr["Date"] = date;
                     string wrtn=InsertMark_dataGridView.Rows[i].Cells[1].Value.ToString();
                     string mcq=InsertMark_dataGridView.Rows[i].Cells[2].Value.ToString();
                     double totalMark = Convert.ToDouble(wrtn) + Convert.ToDouble(mcq);
                    dr["Written"] = wrtn;
                    dr["MCQ"] = mcq;
                    dr["Total"] = totalMark.ToString();
                    dr["Remarks"] = InsertMark_dataGridView.Rows[i].Cells[3].Value.ToString();
                    dt.Rows.Add(dr);
                }
                sr.AddResult(dt);
                MessageBox.Show("Marks Saved Successfully");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      
    }
}
