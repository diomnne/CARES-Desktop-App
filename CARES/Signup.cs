using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace CARES
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void tb_last_name_Click(object sender, EventArgs e)
        {

        }

        private void tb_email_Click(object sender, EventArgs e)
        {

        }

        private void pnl_signup_container_Paint(object sender, PaintEventArgs e)
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
            if (txt_repeat_password.PasswordChar == '●')
            {
                btn_hide2.BringToFront();
                txt_repeat_password.PasswordChar = '\0';
            }
        }

        private void btn_hide2_Click(object sender, EventArgs e)
        {
            if (txt_repeat_password.PasswordChar == '\0')
            {
                btn_view2.BringToFront();
                txt_repeat_password.PasswordChar = '●';
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            // Reset Error Messages
            lbl_firstname_error.Visible = false;
            lbl_lastname_error.Visible = false;
            lbl_email_error.Visible = false;
            lbl_password_error.Visible = false;
            lbl_repeatpass_error.Visible = false;

            // Validate First Name
            if (string.IsNullOrWhiteSpace(txt_first_name.Text))
            {
                lbl_firstname_error.Text = "This is a required field.";
                lbl_firstname_error.Visible = true;
                isValid = false;
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(txt_last_name.Text))
            {
                lbl_lastname_error.Text = "This is a required field.";
                lbl_lastname_error.Visible = true;
                isValid = false;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                lbl_email_error.Text = "This is a required field.";
                lbl_email_error.Visible = true;
                isValid = false;
            }

            if (!Regex.IsMatch(txt_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lbl_email_error.Text = "Enter a valid email address.";
                lbl_email_error.Visible = true;
                isValid = false;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                lbl_password_error.Text = "This is a required field.";
                lbl_password_error.Visible = true;
                isValid = false;
            }

            if (txt_password.Text.Length < 8)
            {
                lbl_password_error.Text = "Password must be at least 8 characters.";
                lbl_password_error.Visible = true;
                txt_repeat_password.Text = "";
                isValid = false;
            }

            // Validate Repeat Password
            if (txt_password.Text != txt_repeat_password.Text || string.IsNullOrWhiteSpace(txt_repeat_password.Text))
            {
                lbl_repeatpass_error.Text = "Passwords do not match.";
                lbl_repeatpass_error.Visible = true;
                isValid = false;
            }

            return isValid;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ll_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
