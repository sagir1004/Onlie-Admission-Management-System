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
    public partial class AbsentStudent : Form
    {
        public AbsentStudent()
        {
            InitializeComponent();
        }

        private void AbsentStudent_Load(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile();
            List<string> session = sp.getSession();
            for (int i = 0; i < session.Count; i++) {
                session_comboBox.Items.Add(session[i]);
            }
        }

        private void session_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StudentResult sr = new StudentResult();
                StudentProfile sp = new StudentProfile();
                DataTable dt1 = sr.getAbsentStudents(session_comboBox.Text);
                int length = dt1.Rows.Count;
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("StudentsMobileNo");
                dt.Columns.Add("GuardianMobileNo");
                dt.Columns.Add("AbsentDays");
                DataRow dr;
                for (int i = 0; i < length; i++)
                {
                    dr = dt.NewRow();
                    string id = dt1.Rows[i][0].ToString();
                    dr["ID"] = id;
                    dr["Name"] = sp.getNameOfSelectedId(id);
                    dr["StudentsMobileNo"] = sp.getStudentMblSelectedId(id);
                    dr["GuardianMobileNo"] = sp.getGuardianMblSelectedId(id);
                    dr["AbsentDays"] = dt1.Rows[i][1].ToString();
                    dt.Rows.Add(dr);
                }
                absentStudent_dataGridView.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void absentStudent_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
