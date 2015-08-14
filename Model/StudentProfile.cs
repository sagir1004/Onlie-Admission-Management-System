using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Threading.Tasks;
using System.Data;

namespace Model
{
    public class StudentProfile
    {
        Connection constring = new Connection();
        SqlCeConnection con = new SqlCeConnection();
        public void AddStudent(string id, string session, string batch,string name, Byte[] image, string fname, string mname, string
            foccupation, string padderss, string stdmbl, string grdmbl, string blood, string amntpaymnt, string infomedia) {
                con.ConnectionString = constring.getConnection();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCeCommand com = new SqlCeCommand("INSERT INTO StudentProfile VALUES(@ID,@Session,@Name,@FatherName,@MotherName,@FatherOccupaton,@PresentAddress,@BloodGroup,@InfoMedia,@Batch,@StudentMobileNo,@GuardianMobileNo,@Picture,@AmountOfPayment)", con);
                com.Parameters.AddWithValue("@ID", id);
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@Name", name);
               
                com.Parameters.AddWithValue("@FatherName", fname);
                com.Parameters.AddWithValue("@MotherName", mname);
                com.Parameters.AddWithValue("@FatherOccupaton", foccupation);
                com.Parameters.AddWithValue("@PresentAddress", padderss);
                com.Parameters.AddWithValue("@BloodGroup", blood);
                com.Parameters.AddWithValue("@AmountOfPayment",amntpaymnt);
                com.Parameters.AddWithValue("@InfoMedia", infomedia);
                com.Parameters.AddWithValue("@Batch", batch);
                com.Parameters.AddWithValue("@StudentMobileNo", stdmbl);
                com.Parameters.AddWithValue("@GuardianMobileNo", grdmbl);
                SqlCeParameter picparameter = new SqlCeParameter();
                picparameter.SqlDbType = SqlDbType.Image;
                picparameter.ParameterName = "Picture";
                picparameter.Value = image;
                com.Parameters.Add(picparameter);
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
        public void AddEducationalBackground(string id, string degree, string institution, string gpa, string passyear) {
            con.ConnectionString = constring.getConnection();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCeCommand com = new SqlCeCommand("INSERT INTO EducationalBackground VALUES(@ID,@Degree,@Institution,@GPA,@PassingYear)", con);
            com.Parameters.AddWithValue("@ID", id);
            com.Parameters.AddWithValue("@Degree",degree );
            com.Parameters.AddWithValue("@Institution", institution);
            com.Parameters.AddWithValue("@GPA", gpa);
            com.Parameters.AddWithValue("@PassingYear", passyear);
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
        public void addUndergraduateInfo(string id, string university, string subject, string merit) {
            con.ConnectionString = constring.getConnection();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCeCommand com = new SqlCeCommand("INSERT INTO UndergraduateInfo VALUES(@ID,@University,@Subject,@MeritPosition)", con);
            com.Parameters.AddWithValue("@ID", id);
            com.Parameters.AddWithValue("@University", university);
            com.Parameters.AddWithValue("@Subject", subject);
            com.Parameters.AddWithValue("@MeritPosition", merit);
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
        public List<string> getID()
        {
            con.ConnectionString = constring.getConnection();
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                List<string> s = new List<string>();
                SqlCeCommand a = new SqlCeCommand("SELECT * FROM StudentProfile", con);
                SqlCeDataReader dr = a.ExecuteReader();
                while (dr.Read())
                {
                    s.Add(dr.GetString(0));
                }
                con.Close();
                return s;
            }
            catch
            {
                throw;
            }
     }
        public DataTable getInformationOfAStudent(string id)
        {
            try
            {
                DataTable dt = new DataTable();
                con.ConnectionString = constring.getConnection();
                if (ConnectionState.Closed == con.State)
                    con.Open();

                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM StudentProfile WHERE ID = '" + id + "'", con);
                a.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable getEduBackOfAStudent(string id)
        {
            try
            {
                DataTable dt = new DataTable();
                con.ConnectionString = constring.getConnection();
                if (ConnectionState.Closed == con.State)
                    con.Open();

                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM EducationalBackground WHERE ID = '" + id + "'", con);
                a.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable getBloodGroupOfStudent(string group)
        {
            try
            {
                DataTable dt = new DataTable();
                con.ConnectionString = constring.getConnection();
                if (ConnectionState.Closed == con.State)
                    con.Open();

                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT Name,StudentMobileNo,PresentAddress FROM StudentProfile WHERE BloodGroup = '" + group + "'", con);
                a.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                throw;
            }
    
        }
         public DataTable getUniversityInfo(string session)
        {
            try
            {
                DataTable dt = new DataTable();
                con.ConnectionString = constring.getConnection();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "SELECT s.Name, t.University, v.GPA AS GPA_in_HSC ,v.Institution AS College_Name";
                query += " FROM  StudentProfile AS s INNER JOIN UndergraduateInfo AS t ON s.ID = t.ID INNER JOIN EducationalBackground AS v ON t.ID = v.ID ";
                query += "WHERE(v.Degree = 'HSC') AND (s.Session='" + session + "')";
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
         public List<string> getSession()
         {
             con.ConnectionString = constring.getConnection();
             if (ConnectionState.Closed == con.State)
                 con.Open();
             try
             {
                 List<string> s = new List<string>();
                 SqlCeCommand a = new SqlCeCommand("SELECT distinct Session FROM StudentProfile", con);
                 SqlCeDataReader dr = a.ExecuteReader();
                 while (dr.Read())
                 {
                     s.Add(dr.GetString(0));
                 }
                 con.Close();
                 return s;
             }
             catch
             {
                 throw;
             }
         }
         public DataTable getStudentNumberInUniversity(string session)
         {
             try
             {
                 DataTable dt = new DataTable();
                 con.ConnectionString = constring.getConnection();
                 if (ConnectionState.Closed == con.State)
                     con.Open();
                 string query="SELECT  t.University, COUNT(t.University) AS Number_Of_Students";
                 query += " FROM  UndergraduateInfo AS t INNER JOIN StudentProfile AS s ON s.ID = t.ID";
                       query+=" WHERE  (s.Session = '"+session+"')";
                       query+=" GROUP BY (t.University)";
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
         public List<string> getIdOfSelectedSession(string session) {
             con.ConnectionString = constring.getConnection();
             if (ConnectionState.Closed == con.State)
                 con.Open();
             try
             {
                 List<string> s = new List<string>();
                 SqlCeCommand a = new SqlCeCommand("SELECT ID FROM StudentProfile WHERE Session = '"+session+"'", con);
                 SqlCeDataReader dr = a.ExecuteReader();
                 while (dr.Read())
                 {
                     s.Add(dr.GetString(0));
                 }
                 con.Close();
                 return s;
             }
             catch
             {
                 throw;
             }
         
         }
         public string getNameOfSelectedId(string id) {
             con.ConnectionString = constring.getConnection();
             if (ConnectionState.Closed == con.State)
                 con.Open();
             try
             {
                 string s = "";
                 SqlCeCommand a = new SqlCeCommand("SELECT Name FROM StudentProfile WHERE ID = '"+id+"'", con);
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
         public string getGuardianMblSelectedId(string id)
         {
             con.ConnectionString = constring.getConnection();
             if (ConnectionState.Closed == con.State)
                 con.Open();
             try
             {
                 string s = "";
                 SqlCeCommand a = new SqlCeCommand("SELECT GuardianMobileNo FROM StudentProfile WHERE ID = '" + id + "'", con);
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
         public string getStudentMblSelectedId(string id)
         {
             con.ConnectionString = constring.getConnection();
             if (ConnectionState.Closed == con.State)
                 con.Open();
             try
             {
                 string s="";
                 SqlCeCommand a = new SqlCeCommand("SELECT StudentMobileNo FROM StudentProfile WHERE ID = '" + id + "'", con);
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
         public List<string> getBatch()
         {
             con.ConnectionString = constring.getConnection();
             if (ConnectionState.Closed == con.State)
                 con.Open();
             try
             {
                 List<string> s = new List<string>();
                 SqlCeCommand a = new SqlCeCommand("SELECT distinct Batch FROM StudentProfile", con);
                 SqlCeDataReader dr = a.ExecuteReader();
                 while (dr.Read())
                 {
                     s.Add(dr.GetString(0));
                 }
                 con.Close();
                 return s;
             }
             catch
             {
                 throw;
             }
         }
    }
}
