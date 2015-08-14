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
    public partial class InsertPayment : Form
    {
        string date = "";
        public InsertPayment()
        {
            InitializeComponent();
        }

        private void InsertPayment_Load(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile();
            date = dateTimePicker1.Value.ToShortDateString();
            List<string> id = sp.getID();
            for (int i = 0; i < id.Count; i++) {
                Id_comboBox.Items.Add(id[i]);
            }
            Id_comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Id_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value.ToShortDateString();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
          //  try
           // {
                StudentPayment sp = new StudentPayment();
                string id = Id_comboBox.Text;
                string recept = recept_textBox.Text;
                string due = amount_textBox.Text;
                string remark = remarks_textBox.Text;
                double dueamnt = Convert.ToDouble(sp.getDueAmountOfA_Student(id));
                dueamnt = dueamnt - Convert.ToDouble(due);
                sp.UpdateDuePayment(id, dueamnt.ToString(), remark);
                sp.InsertRecipt(id, date, recept);
                MessageBox.Show("Saved Successfully");
            //}
           // catch (Exception ex) {
             //   MessageBox.Show(ex.ToString());
           // }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
