using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CARES
{
    public partial class Admin_LogTrail : Form
    {
        private string connectionString = "server=127.0.0.1;uid=root;pwd=20181024;database=cares_db";
        public Admin_LogTrail()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT logs.log_id, logs.account_id, accounts.role, logs.action, logs.description, logs.time_stamp 
                FROM logs
                INNER JOIN accounts ON logs.account_id = accounts.account_id
                ORDER BY logs.time_stamp DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind data to DataGridView
                    dtgLogTrail.DataSource = dt;

                    // Customize column headers
                    dtgLogTrail.Columns["log_id"].HeaderText = "Log ID";
                    dtgLogTrail.Columns["account_id"].HeaderText = "Acc ID";
                    dtgLogTrail.Columns["role"].HeaderText = "Role";
                    dtgLogTrail.Columns["action"].HeaderText = "Action";
                    dtgLogTrail.Columns["description"].HeaderText = "Description";
                    dtgLogTrail.Columns["time_stamp"].HeaderText = "Time Stamp";

                    // Adjust column width
                    dtgLogTrail.Columns["log_id"].Width = 34;
                    dtgLogTrail.Columns["account_id"].Width = 35;
                    dtgLogTrail.Columns["role"].Width = 70;
                    dtgLogTrail.Columns["action"].Width = 50;
                    dtgLogTrail.Columns["description"].Width = 120;
                    dtgLogTrail.Columns["time_stamp"].Width = 150;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
