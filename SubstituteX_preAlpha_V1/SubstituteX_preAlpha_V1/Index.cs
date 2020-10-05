using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Index()
        {
          
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            string dd = d.Day + "." + d.Month;

            string serverName = txtServerName.Text;
            string databaseName = txtDBName.Text;

            string connectionString = @"Data Source=" + serverName + "; Integrated Security=True; Initial Catalog=" + databaseName + "";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            string query_1 = "use " + databaseName + ";";
            string query_2 = @"BACKUP DATABASE " + databaseName + " To DISK= 'D:\\DatabaseBackups\\"+databaseName+" _" + dd + ".bak' with format,Medianame='Z_SQLServerBackups',Name='FullBackUp_" + databaseName + "';";

            SqlCommand cmd1 = new SqlCommand(query_1,con);
            SqlCommand cmd2 = new SqlCommand(query_2, con);

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            MessageBox.Show("Done!");
            con.Close();
        }
    }
}
