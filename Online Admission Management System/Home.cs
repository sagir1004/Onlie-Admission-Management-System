using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachingManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

        private void insertExamMarksAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddResult ar = new AddResult();
            ar.Show();
        }

        private void attendanceAndMarksRelationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void batchWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatchWisePrintResult br = new BatchWisePrintResult();
            br.Show();
        }

        private void viewStudentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent vs = new ViewStudent();
            vs.Show();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStudent a=new AddNewStudent();
            a.Show();
           

        }

        private void deleteStudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUndergraduateInfo ob = new AddUndergraduateInfo();
            ob.Show();
        }

        private void studentWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentWiseResultPrint s = new StudentWiseResultPrint();
            s.Show();
        }

        private void absentStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbsentStudent  a=new AbsentStudent();
            a.Show();
        }

        private void individualPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertPayment ip = new InsertPayment();
            ip.Show();
        }

        private void totalPaymentOfAMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualPayment ip = new IndividualPayment();
            ip.Show();
        }

        private void getDueAmountInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DueAmount da = new DueAmount();
            da.Show();
        }

        private void paymentSectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
