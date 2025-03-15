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
using static CARES.FormMethods;
using static CARES.Colors;
using Guna.UI.WinForms;

namespace CARES
{
    public partial class Admin_ManageUsers : Form
    {
        private string connectionString = "server=127.0.0.1;uid=root;pwd=20181024;database=cares_db";
        private GunaButton currentBtn = null;
        public Admin_ManageUsers()
        {
            InitializeComponent();

            ActivateButton(this, btnAllUsers, Colors.eggshell, Colors.teal, Colors.teal, Colors.eggshell);
        }

        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(this, sender, Colors.eggshell, Colors.teal, Colors.teal, Colors.eggshell);
        }

        private void btnClinicStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(this, sender, Colors.eggshell, Colors.teal, Colors.teal, Colors.eggshell);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ActivateButton(this, sender, Colors.eggshell, Colors.teal, Colors.teal, Colors.eggshell);
        }
    }
}
