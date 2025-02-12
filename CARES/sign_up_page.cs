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
    public partial class sign_up_page : Form
    {
        public sign_up_page()
        {
            InitializeComponent();
        }

        private void tb_last_name_Click(object sender, EventArgs e)
        {

        }

        private void tb_email_Click(object sender, EventArgs e)
        {

        }

        private void btn_view1_password_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '●')
            {
                btn_hide1.BringToFront();
                txt_password.PasswordChar = '\0';
            }
        }

        private void btn_hide1_Click(object sender, EventArgs e)
        {
            if(txt_password.PasswordChar == '\0')
            {
                btn_view1.BringToFront();
                txt_password.PasswordChar = '●';
            }
        }

        private void btn_view2_Click(object sender, EventArgs e)
        {
            if (txt_confirm_password.PasswordChar == '●')
            {
                btn_hide2.BringToFront();
                txt_confirm_password.PasswordChar = '\0';
            }
        }

        private void btn_hide2_Click(object sender, EventArgs e)
        {
            if (txt_confirm_password.PasswordChar == '\0')
            {
                btn_view2.BringToFront();
                txt_confirm_password.PasswordChar = '●';
            }
        }
    }
}
