using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubstituteX_preAlpha_V1
{
    public partial class Index : MetroFramework.Forms.MetroForm
    {
        private SqlConnection connection;
        string connectionString;
        string serverName = "";
        string databaseName = "";
        public Index()
        {
          
            InitializeComponent();
        }


        public SqlConnection Connection()
        {
            serverName = txtServerName.Text;
            databaseName = txtDBName.Text;
            connectionString = @"Data Source=" + serverName + "; Integrated Security=True; Initial Catalog=" + databaseName + "";
           
            return new SqlConnection(connectionString);
        }

        public int ExecuteNonQuery(string sqlQuery)
        {
            int res = -1;
            using (connection = Connection())
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                res = cmd.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return res;
        }

        public DataTable ExecuteQuery(string sqlQuery)
        {
            DataTable dt = new DataTable();
            using (connection = Connection())
            {
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, connection);

                da.Fill(dt);
            }
            return dt;
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
            Connection();
            DateTime d = DateTime.Now;
            string dd = d.Day + "." + d.Month;

            string query_1 = "use " + databaseName + ";";
            string query_2 = @"BACKUP DATABASE " + databaseName + " To DISK= 'D:\\DatabaseBackups\\"+databaseName+" _" + dd + ".bak' with format,Medianame='Z_SQLServerBackups',Name='FullBackUp_" + databaseName + "';";

            ExecuteNonQuery(query_1);
            ExecuteNonQuery(query_2);

            MessageBox.Show("Done!");
            
        }
    }
}
