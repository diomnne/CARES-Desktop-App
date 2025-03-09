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

namespace CARES
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
            LoadDashboardCounts();
        }

        private void LoadDashboardCounts()
        {
            string connectionString = "server=127.0.0.1;uid=root;pwd=20181024;database=cares_db";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                lblUsersCtr.Text = GetCount(conn, "SELECT COUNT(*) FROM accounts").ToString();

                lblRecentLoginsCtr.Text = GetCount(conn,
                    "SELECT COUNT(*) FROM logs WHERE action = 'Login' AND CAST(time_stamp AS DATE) = CAST(GETDATE() AS DATE)").ToString();

                // Uncomment when pending approvals logic is ready
                // lblPendingApprovalsCtr.Text = GetCount(conn, "SELECT COUNT(*) FROM Users WHERE Status = 'Pending'").ToString();
            }
        }

        private int GetCount(SqlConnection conn, string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }
    }
}
