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
    public partial class IndividualPayment : Form
    {
        public IndividualPayment()
        {
            InitializeComponent();
        }

        private void IndividualPayment_Load(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile();
            List<string> id = sp.getID();
            for (int i = 0; i < id.Count; i++) {
                Id_comboBox.Items.Add(id[i]);
            }
            Id_comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Id_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Id_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                StudentPayment spay = new StudentPayment();
                individual_dataGridView.DataSource = spay.getAllReceiptOfAStudent(Id_comboBox.Text);
        }
      catch(Exception ex){
      MessageBox.Show(ex.ToString());
      }
        }

    }
}
