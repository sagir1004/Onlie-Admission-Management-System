using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;

namespace Model
{
    public class StudentPayment
    {
         Connection constring = new Connection();
        SqlCeConnection con = new SqlCeConnection();
        public void UpdateDuePayment(string id,string due,string remark) {

            con.ConnectionString = constring.getConnection();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string query = "UPDATE  StudentPayment" ;
                   query+= " SET      DueAmount = '"+due+"',Remarks = '"+remark+"'";
                   query+= " WHERE    (ID = '" + id + "')";
            SqlCeCommand com = new SqlCeCommand(query, con);
          
            try
            {
                com.ExecuteNonQuery();
                con.Close();


            }
            catch
            {
                throw;
            }
        
        }
        public void insert_DuePayment(string id, string due, string remark) {
            con.ConnectionString = constring.getConnection();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCeCommand com = new SqlCeCommand("INSERT INTO StudentPayment VALUES(@ID,@DueAmount,@Remarks)", con);
            com.Parameters.AddWithValue("@ID", id);
            com.Parameters.AddWithValue("@DueAmount", due);
            com.Parameters.AddWithValue("@Remarks", remark);
            try
            {
                com.ExecuteNonQuery();
                con.Close();


            }
            catch
            {
                throw;
            }
          
        
        }
        public string getDueAmountOfA_Student(string id) {
            con.ConnectionString = constring.getConnection();
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                string s = "";
                SqlCeCommand a = new SqlCeCommand("SELECT DueAmount FROM StudentPayment WHERE ID = '" + id + "'", con);
                SqlCeDataReader dr = a.ExecuteReader();
                while (dr.Read())
                {
                    s = dr.GetString(0);
                }
                con.Close();
                return s;

            }
            catch
            {
                throw;
            }
        }
        public void InsertRecipt(string id, string date, string recipt) {
            con.ConnectionString = constring.getConnection();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCeCommand com = new SqlCeCommand("INSERT INTO Receipts VALUES(@ID,@Date,@ReceiptNo)", con);
            com.Parameters.AddWithValue("@ID", id);
            com.Parameters.AddWithValue("@Date", date);
            com.Parameters.AddWithValue("@ReceiptNo", recipt);
            try
            {
                com.ExecuteNonQuery();
                con.Close();


            }
            catch
            {
                throw;
            }
          
        
        }
        public DataTable getAllReceiptOfAStudent(string id)
        {
            try
            {
                DataTable dt = new DataTable();
                con.ConnectionString = constring.getConnection();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "SELECT Date,ReceiptNo";
                query += " FROM  Receipts ";
                query += "WHERE(ID='" + id + "')";
                SqlCeDataAdapter a = new SqlCeDataAdapter(query, con);
                a.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                throw;
            }
         
        }
        public DataTable getDueAmountOfStudents(string session) {
            try
            {
                DataTable dt = new DataTable();
                con.ConnectionString = constring.getConnection();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "SELECT s.ID,S.Name,s.GuardianMobileNo,s.StudentMobileNo,t.DueAmount";
                query += " FROM  StudentProfile AS s INNER JOIN StudentPayment AS t ON s.ID = t.ID ";
                query += "WHERE(s.Session='" + session + "')";
                query += " ORDER BY t.DueAmount DESC";
                SqlCeDataAdapter a = new SqlCeDataAdapter(query, con);
                a.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                throw;
            }
         
        }
    }
}
