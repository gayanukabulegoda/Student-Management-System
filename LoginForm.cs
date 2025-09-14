using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            Text = "Student Management System - Login";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (AuthenticateUser())
            {
                ShowSuccess();
                NavigateToRegistrationForm();
            }
            else
            {
                ShowError();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) || 
                string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool AuthenticateUser()
        {
            string connectionString = "Data Source=DESKTOP-CF5UPHT\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Encrypt=False";

            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT loginId, username, role FROM Logins WHERE username = @username AND password = @password";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", UsernameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@password", PasswordTextBox.Text);

                using SqlDataReader reader = command.ExecuteReader();
                return reader.Read(); // Returns true if a matching record is found
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ShowSuccess()
        {
            MessageBox.Show("Login successful!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowError()
        {
            MessageBox.Show("Invalid username or password.", "Login Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            PasswordTextBox.Clear();
            PasswordTextBox.Focus();
        }

        private void NavigateToRegistrationForm()
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            UsernameTextBox.Focus();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Add the missing event handlers that are referenced in the designer
        private void label1_Click(object sender, EventArgs e)
        {
            // Empty event handler for label1 click
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Empty event handler for label2 click
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Empty event handler for username textbox text changed
        }
    }
}