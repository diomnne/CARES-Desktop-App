using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace CARES
{
    public partial class Login : Form
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=20181024;database=cares_db";
        private int failedAttempts = 0;
        private System.Windows.Forms.Timer lockoutTimer;
        private int lockoutDuration = 30;
        public Login()
        {
            InitializeComponent();
            InitializeLockoutTimer();
        }

        private void InitializeLockoutTimer()
        {
            lockoutTimer = new System.Windows.Forms.Timer();
            lockoutTimer.Interval = 1000;
            lockoutTimer.Tick += LockoutTimer_Tick;
        }

        private void LockoutTimer_Tick(object sender, EventArgs e)
        {
            lockoutDuration--;
            btnLogin.Text = $"Locked ({lockoutDuration}s)";
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;

            if (lockoutDuration <= 0)
            {
                lockoutTimer.Stop();
                btnLogin.Enabled = true;
                btnLogin.Text = "Log in";
                txtEmail.Enabled = true;
                txtPassword.Enabled = true;

                failedAttempts = 0;  
                lockoutDuration = 30;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnView.BringToFront();
                txtPassword.PasswordChar = '●';
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            // Reset error messages
            lblEmailError.Visible = false;
            lblPasswordError.Visible = false;

            // Validate Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblEmailError.Text = "This is a required field.";
                lblEmailError.Visible = true;
                isValid = false;
            }
            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
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

            return isValid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return; 

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string checkEmailQuery = "SELECT account_id, password, role FROM accounts WHERE email = @Email";
                    int accountId = -1;
                    string storedPassword = "";
                    string role = "";

                    using (MySqlCommand checkEmailCmd = new MySqlCommand(checkEmailQuery, conn))
                    {
                        checkEmailCmd.Parameters.AddWithValue("@Email", email);
                        using (MySqlDataReader reader = checkEmailCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                accountId = reader.GetInt32("account_id");
                                storedPassword = reader.GetString("password");
                                role = reader.GetString("role");
                            }
                            else
                            {
                                lblEmailError.Text = "Account does not exist.";
                                lblEmailError.Visible = true;
                                return;
                            }
                        }
                    }

                    if (storedPassword != password) 
                    {
                        failedAttempts++;

                        if (failedAttempts >= 3)
                        {
                            MessageBox.Show($"Too many failed attempts. Try again in {lockoutDuration} seconds.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                            btnLogin.Enabled = false;
                            txtEmail.Enabled = false;
                            txtPassword.Enabled = false;

                            lockoutTimer.Start();
                            return;
                        }

                        lblPasswordError.Text = $"Incorrect password. {3 - failedAttempts} attempts left.";
                        lblPasswordError.Visible = true;
                        return;
                    }

                    failedAttempts = 0;
                    
                    string logQuery = "INSERT INTO logs (account_id, action, description, time_stamp) VALUES (@AccountId, @Action, @Description, NOW())";

                    using (MySqlCommand logCmd = new MySqlCommand(logQuery, conn))
                    {
                        logCmd.Parameters.AddWithValue("@AccountId", accountId);
                        logCmd.Parameters.AddWithValue("@Action", "Login");
                        logCmd.Parameters.AddWithValue("@Description", $"User {email} logged in as {role}");
                        logCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form f = null;

                    switch (role.ToLower())
                    {
                        case "admin":
                            f = new Admin_Main();
                            break;
                        case "doctor":
                            f = new Doctor_Main();
                            break;
                        case "nurse":
                            f = new Nurse_Main();
                            break;
                        case "medical records officer":
                            f = new MRO_Main();
                            break;
                        case "medicine inventory handler":
                            f = new MIH_Main();
                            break;
                        case "patient":
                            f = new Patient_Main();
                            break;
                        default:
                            MessageBox.Show("Unknown role detected. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    f.Show();
                    this.Hide();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup s = new Signup();
            s.Show();
            this.Hide();
        }
    }
}
