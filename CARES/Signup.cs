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
using MySql.Data.MySqlClient;

namespace CARES
{
    public partial class Signup : Form
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=20181024;database=cares_db";
        public Signup()
        {
            InitializeComponent();
        }

        private bool EmailExists(string email)
        {
            bool exists = false;
            string connectionString = "server=127.0.0.1;uid=root;pwd=20181024;database=cares_db";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM accounts WHERE email = @Email";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }

            return exists;
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
            lblGenderError.Visible = false;

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

            if (EmailExists(txtEmail.Text))
            {
                lblEmailError.Text = "Email is already registered.";
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

            //Validate Gender select
            if (cmbGender.SelectedIndex == -1)
            {
                lblGenderError.Text = "Please select an option.";
                lblGenderError.Visible = true;
                isValid = false;
            }

            //Validate MI
            if (!string.IsNullOrWhiteSpace(txtMI.Text))
            {
                if (!Regex.IsMatch(txtMI.Text, @"^[A-Za-z]$")) // Only 1 letter
                {
                    lblMIError.Text = "Invalid M.I.";
                    lblMIError.Visible = true;
                    isValid = false;
                }
                else
                {
                    txtMI.Text = txtMI.Text.ToUpper(); // Convert to uppercase before saving
                }
            }

            return isValid;
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    string connectionString = "server=127.0.0.1;uid=root;pwd=20181024;database=cares_db";
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string insertQuery = @"
                            INSERT INTO accounts (email, password, date_created, role)
                            VALUES (@Email, @Password, NOW(), 'Patient');";

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                            cmd.ExecuteNonQuery();
                        }

                        // Retrieve the inserted account's ID
                        int accountId = Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID();", conn).ExecuteScalar());
                        string genderValue = cmbGender.SelectedItem.ToString();

                        // Insert into patients table
                        string insertPatientQuery = @"
                            INSERT INTO patients (account_id, first_name, last_name, middle_initial, date_of_birth, gender)
                            VALUES (@AccountId, @FirstName, @LastName, @MiddleInitial, @DOB, @Gender);";

                        using (MySqlCommand cmdPatient = new MySqlCommand(insertPatientQuery, conn))
                        {
                            cmdPatient.Parameters.AddWithValue("@AccountId", accountId);
                            cmdPatient.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                            cmdPatient.Parameters.AddWithValue("@LastName", txtLastName.Text);
                            cmdPatient.Parameters.AddWithValue("@MiddleInitial", string.IsNullOrEmpty(txtMI.Text) ? DBNull.Value.ToString() : txtMI.Text);
                            cmdPatient.Parameters.AddWithValue("@DOB", dtpDateOfBirth.Value);
                            cmdPatient.Parameters.AddWithValue("@Gender", genderValue);

                            cmdPatient.ExecuteNonQuery();
                        }

                        // Insert log entry into logs table
                        string insertLogQuery = @"
                            INSERT INTO logs (account_id, action, description, time_stamp)
                            VALUES (@AccountId, @Action, @Description, NOW());";

                        using (MySqlCommand cmdLog = new MySqlCommand(insertLogQuery, conn))
                        {
                            cmdLog.Parameters.AddWithValue("@AccountId", accountId);
                            cmdLog.Parameters.AddWithValue("@Action", "Sign-up");
                            cmdLog.Parameters.AddWithValue("@Description",
                                $"New patient account created: {txtFirstName.Text} {txtLastName.Text} (Email: {txtEmail.Text})");
                            cmdLog.ExecuteNonQuery();
                        }

                    }

                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
