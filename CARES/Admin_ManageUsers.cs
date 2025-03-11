using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARES
{
    public partial class Admin_ManageUsers : Form
    {
        private string connectionString = "server=127.0.0.1;uid=root;pwd=20181024;database=cares_db";
        public Admin_ManageUsers()
        {
            InitializeComponent();
        }

    }
}
