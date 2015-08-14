using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model
{
    public class StudentResult
    {
        Connection constring = new Connection();
        SqlCeConnection con = new SqlCeConnection();
        public void AddResult(DataTable dt)
        {

            try
            {
                con.ConnectionString = constring.getConnection();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                int length = dt.Rows.Count;
                for (int i = 0; i < length; i++)
                {
                  
                    SqlCeCommand com = new SqlCeCommand("INSERT INTO StudentResult VALUES(@ID,@Subject,@Date,@Written,@MCQ,@Total,@Remarks)", con);
                    com.Parameters.AddWithValue("@ID", dt.Rows[i][0].ToString());
                    com.Parameters.AddWithValue("@Subject", dt.Rows[i][1].ToString());
                    com.Parameters.AddWithValue("@Date", dt.Rows[i][2].ToString());
                    com.Parameters.AddWithValue("@Written", dt.Rows[i][3].ToString());
                    com.Parameters.AddWithValue("@MCQ", dt.Rows[i][4].ToString());
                    com.Parameters.AddWithValue("@Total", dt.Rows[i][5].ToString());
                    com.Parameters.AddWithValue("@Remarks",dt.Rows[i][6].ToString());
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch
            {
                throw;
            }

        }
        public DataTable getResultOfSelectedStudent(string id) {

            con.ConnectionString = constring.getConnection();
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                DataTable dt=new DataTable();
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT Subject,Date,Written,MCQ,Total,Remarks FROM StudentResult WHERE ID='"+id+"'", con);
                a.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable getAbsentStudents(string session)
        {

            con.ConnectionString = constring.getConnection();
            if (ConnectionState.Closed == con.State)
                con.Open();
          string query="  SELECT        s.ID, COUNT(s.Remarks) AS Absent_Days";
               query+=" FROM            StudentResult as s INNER JOIN StudentProfile as t ON s.ID=t.ID";
                query+=" WHERE        (s.Remarks = 'Absent' AND t.Session='"+session+"')";
                query += " GROUP BY s.ID";
            try
            {
                DataTable dt = new DataTable();
                SqlCeDataAdapter a = new SqlCeDataAdapter(query, con);
                a.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable getBatchwiseResult(string session,string batch,string date) {
            con.ConnectionString = constring.getConnection();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string query = "  SELECT        s.ID,t.Name,s.Date,s.Subject,s.Written,s.MCQ,s.Total,s.Remarks";
            query += " FROM            StudentResult as s INNER JOIN StudentProfile as t ON s.ID=t.ID";
            query += " WHERE        (t.Batch='" + batch + "' AND t.Session='"+session+"' AND s.Date='"+date+"')";
            try
            {
                DataTable dt = new DataTable();
                SqlCeDataAdapter a = new SqlCeDataAdapter(query, con);
                a.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        
        }
       
    }
}
