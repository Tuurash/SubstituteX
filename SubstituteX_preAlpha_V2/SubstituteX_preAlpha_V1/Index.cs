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
        int Interval = 0;
        string Directiory = "";

        public Index()
        {
            InitializeComponent();
            PanelSecheduler.Visible = false;
            btnBackup.Enabled = false;
        }
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            return "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBrowse.Text = browserDialog.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        #region Connection
        public SqlConnection Connection()
        {
            char trimChars = '"';
            serverName = txtServerName.Text;
            databaseName = txtDBName.Text;
            if (serverName != "" && databaseName != "")
            {
                connectionString = @"Data Source=" + serverName + "; Integrated Security=True; Initial Catalog=" + databaseName + ";";
            }
            else
            {
                connectionString = @txtCustomString.Text + ";";
                serverName = getBetween(connectionString, "Source=", "; Integrated").Trim(trimChars);
                databaseName = getBetween(connectionString, "Catalog=", ";").Trim(trimChars);
            }
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
        #endregion

        #region BackupRegion
        private void CreateBackup()
        {
            Directiory = txtBrowse.Text;
            try
            {
                Connection();
                DateTime d = DateTime.Now;
                string dd = d.Day + "." + d.Month + "." + d.Second;
                string query_1 = "use " + databaseName + ";";
                string query_2 = @"BACKUP DATABASE " + databaseName + " To DISK= '"+Directiory+"\\" + databaseName + " _" + dd + ".bak' with format,Medianame='Z_SQLServerBackups',Name='FullBackUp_" + databaseName + "';";

                ExecuteNonQuery(query_1);
                ExecuteNonQuery(query_2);
            }
            catch(Exception exc) { }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            CreateBackup();
            MessageBox.Show("Done!");
        }

        #endregion

        #region SchedulingRegion
        private void btnScheduler_Click(object sender, EventArgs e)
        {
            PanelSecheduler.Visible = true;
        }

        private void btnStartSchedule_Click(object sender, EventArgs e)
        {
            Interval = int.Parse(txtInterval.Text);
            BackupTimer.Interval = Interval * 60000;
            lblSchedulerStatus.Text = "Running";
            BackupTimer.Start();

        }

        private void BackupTimer_Tick(object sender, EventArgs e)
        {
            CreateBackup();
        }

        private void btnStopSchedule_Click(object sender, EventArgs e)
        {
            BackupTimer.Stop();
            lblSchedulerStatus.Text = "Not Running.";
            lblSchedulerStatus.ForeColor = System.Drawing.Color.Red;
            PanelSecheduler.Visible = false;
        }


        #endregion

        
    }
}
