using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Budgeting_Application
{
    public class DbConnection
    {
        static string debugPath = Environment.CurrentDirectory;
        //static string path = Directory.GetParent(debugPath).Parent.FullName;
        static string path = Application.StartupPath;
        SqlConnection cn;
        //string connectionString = ConfigurationManager.ConnectionStrings["Budgeting_Application.Properties.Settings.MainDBConnectionString"].ConnectionString;
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + @"\ApplicationData\MainDB.mdf;Integrated Security = False; Connect Timeout = 30";

        public void OpenConnection()
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
        }

        public void CloseConnection()
        {
            cn.Close();
        }

        public void ExcecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, cn);
            cmd.ExecuteNonQuery();              
        }

        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, connectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            
            object dataum = ds.Tables[0];
            return dataum;
            
        }
    }    
}
