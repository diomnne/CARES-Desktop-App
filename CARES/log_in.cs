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
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void btn_view1_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '●')
            {
                btn_hide1.BringToFront();
                txt_password.PasswordChar = '\0';
            }
        }

        private void btn_hide1_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '\0')
            {
                btn_view1.BringToFront();
                txt_password.PasswordChar = '●';
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
