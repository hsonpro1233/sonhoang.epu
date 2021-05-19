using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App1
{
    class connect
    {
        public static string id = "-1";
        public string strcon = "Data Source=LAPTOP-8N9JKN55\\KNIGHT;Initial Catalog=SouvernirManagement;Integrated Security=True";
        public SqlCommand cmd;
        public DataSet ds;
        public SqlConnection con;
        SqlDataAdapter da;

        public DataSet truyvan(string sql)
        {
            con = new SqlConnection(strcon);
            con.Open();
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public DataTable LayComboData(string sql)
        {
            con = new SqlConnection(strcon);
            con.Open();
            da= new SqlDataAdapter(sql,con);
            DataTable db = new DataTable();
            da.Fill(db);
            return db;
        }
        public bool capnhat(string sql)
        {
            bool ck = false;
            con = new SqlConnection(strcon);
            con.Open();
            cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                ck = true;
                con.Close();
            }
            catch
            {
                ck = false;
                con.Close();
            }
            
            return ck;
        }
        public string Laydatastring(string sql)
        {
            string a = "";
            con = new SqlConnection(strcon);
            con.Open();
            cmd = new SqlCommand(sql, con);
            a=cmd.ExecuteScalar().ToString();
            con.Close();
            return a;
        }
        public string reader(string sql, int i)
        {
            con = new SqlConnection(strcon);
            con.Open();
            string b = "";
            cmd = new SqlCommand(sql, con);
            SqlDataReader a = cmd.ExecuteReader();
            if (a.Read())
            {
                b = a.GetString(i);
            }
            return b;
        }
        public string readerdouble(string sql, int i)
        {
            con = new SqlConnection(strcon);
            con.Open();
            string b = "";
            cmd = new SqlCommand(sql, con);
            SqlDataReader a = cmd.ExecuteReader();
            if (a.Read())
            {
                b = a.GetDouble(i).ToString();
            }
            return b;
        }
        public string readertriple(string sql, int i)
        {
            con = new SqlConnection(strcon);
            con.Open();
            string b = "";
            cmd = new SqlCommand(sql, con);
            SqlDataReader a = cmd.ExecuteReader();
            if (a.Read())
            {
                b = a.GetDecimal(i).ToString();
            }
            con.Close();
            return b;
        }
        public string reader(string sql, int i, string dataformat)
        {
            con = new SqlConnection(strcon);
            con.Open();
            string b = dataformat;
            cmd = new SqlCommand(sql, con);
            SqlDataReader a = cmd.ExecuteReader();
            if (a.Read())
            {
                b = a.GetDateTime(i).ToString("dd/MM/yyyy");
            }
            return b;
        }
        public string reader(string sql, string i)
        {
            con = new SqlConnection(strcon);
            con.Open();
            string b = "";
            cmd = new SqlCommand(sql, con);
            SqlDataReader a = cmd.ExecuteReader();
            while (a.Read())
            {
                b = a.GetString(a.GetOrdinal(i));
            }
            return b;
        }
    }
}
