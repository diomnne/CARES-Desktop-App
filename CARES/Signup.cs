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

        private bool ValidateForm()
        {
            bool isValid = true;

            // Reset Error Messages
            lblFirstnameEror.Visible = false;
            lblLastnameError.Visible = false;
            lblEmailError.Visible = false;
            lblPasswordError.Visible = false;
            lblRepeatPassError.Visible = false;

            // Validate First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                lblFirstnameEror.Text = "This is a required field.";
                lblFirstnameEror.Visible = true;
                isValid = false;
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                lblLastnameError.Text = "This is a required field.";
                lblLastnameError.Visible = true;
                isValid = false;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblEmailError.Text = "This is a required field.";
                lblEmailError.Visible = true;
                isValid = false;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblEmailError.Text = "Enter a valid email address.";
                lblEmailError.Visible = true;
                isValid = false;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblPasswordError.Text = "This is a required field.";
                lblPasswordError.Visible = true;
                isValid = false;
            }

            if (txtPassword.Text.Length < 8)
            {
                lblPasswordError.Text = "Password must be at least 8 characters.";
                lblPasswordError.Visible = true;
                txtRepeatPass.Text = "";
                isValid = false;
            }

            // Validate Repeat Password
            if (txtPassword.Text != txtRepeatPass.Text || string.IsNullOrWhiteSpace(txtRepeatPass.Text))
            {
                lblRepeatPassError.Text = "Passwords do not match.";
                lblRepeatPassError.Visible = true;
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

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnView1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                btnHide1.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnView1.BringToFront();
                txtPassword.PasswordChar = '●';
            }
        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            if (txtRepeatPass.PasswordChar == '●')
            {
                btnHide2.BringToFront();
                txtRepeatPass.PasswordChar = '\0';
            }
        }

        private void btnHide2_Click(object sender, EventArgs e)
        {
            if (txtRepeatPass.PasswordChar == '\0')
            {
                btnView2.BringToFront();
                txtRepeatPass.PasswordChar = '●';
            }
        }

        
    }
}
