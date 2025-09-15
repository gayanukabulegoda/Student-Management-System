using System.Data;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    public partial class RegistrationForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-CF5UPHT\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Encrypt=False";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            ConfigureForm();
            LoadRegistrationNumbers();
            LoadRegistrationData();
        }

        private void ConfigureForm()
        {
            Text = "Student Registration - Skills International";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        private void LoadRegistrationNumbers()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "SELECT regNo FROM Registration ORDER BY regNo";
                using SqlCommand command = new SqlCommand(query, connection);
                using SqlDataReader reader = command.ExecuteReader();
                
                regNoComboBox.Items.Clear();
                while (reader.Read())
                {
                    regNoComboBox.Items.Add(reader["regNo"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading registration numbers: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRegistrationData()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM Registration ORDER BY regNo";
                using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                registrationDataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading registration data: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = @"INSERT INTO Registration (firstName, lastName, dateOfBirth, gender, address, email, 
                               mobilePhone, homePhone, parentName, nic, contactNo) 
                               VALUES (@firstName, @lastName, @dateOfBirth, @gender, @address, @email, 
                               @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

                using SqlCommand command = new SqlCommand(query, connection);
                AddParameters(command);
                command.ExecuteNonQuery();

                MessageBox.Show("Student registered successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadRegistrationNumbers();
                LoadRegistrationData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering student: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (regNoComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a registration number to update.", "Update Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = @"UPDATE Registration SET firstName = @firstName, lastName = @lastName, 
                               dateOfBirth = @dateOfBirth, gender = @gender, address = @address, email = @email, 
                               mobilePhone = @mobilePhone, homePhone = @homePhone, parentName = @parentName, 
                               nic = @nic, contactNo = @contactNo WHERE regNo = @regNo";

                using SqlCommand command = new SqlCommand(query, connection);
                AddParameters(command);
                command.Parameters.AddWithValue("@regNo", regNoComboBox.SelectedItem.ToString());
                command.ExecuteNonQuery();

                MessageBox.Show("Student record updated successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRegistrationData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (regNoComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a registration number to delete.", "Delete Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student record?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string query = "DELETE FROM Registration WHERE regNo = @regNo";
                    using SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@regNo", regNoComboBox.SelectedItem.ToString());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Student record deleted successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadRegistrationNumbers();
                    LoadRegistrationData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting student: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void regNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regNoComboBox.SelectedItem != null)
            {
                LoadStudentData(regNoComboBox.SelectedItem.ToString());
            }
        }

        private void LoadStudentData(string regNo)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM Registration WHERE regNo = @regNo";
                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@regNo", regNo);
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    firstNameTextBox.Text = reader["firstName"].ToString();
                    lastNameTextBox.Text = reader["lastName"].ToString();
                    dateOfBirthDateTimePicker.Value = Convert.ToDateTime(reader["dateOfBirth"]);
                    string gender = reader["gender"].ToString();
                    maleRadioButton.Checked = gender == "Male";
                    femaleRadioButton.Checked = gender == "Female";
                    addressTextBox.Text = reader["address"].ToString();
                    emailTextBox.Text = reader["email"].ToString();
                    mobilePhoneTextBox.Text = reader["mobilePhone"].ToString();
                    homePhoneTextBox.Text = reader["homePhone"].ToString();
                    parentNameTextBox.Text = reader["parentName"].ToString();
                    nicTextBox.Text = reader["nic"].ToString();
                    contactNoTextBox.Text = reader["contactNo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePhoneNumbers()
        {
            // Validate mobile phone
            if (!string.IsNullOrWhiteSpace(mobilePhoneTextBox.Text))
            {
                if (!int.TryParse(mobilePhoneTextBox.Text.Trim(), out _))
                {
                    MessageBox.Show("Mobile phone number must contain only numeric characters.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mobilePhoneTextBox.Focus();
                    return false;
                }
            }
            
            // Validate home phone
            if (!string.IsNullOrWhiteSpace(homePhoneTextBox.Text))
            {
                if (!int.TryParse(homePhoneTextBox.Text.Trim(), out _))
                {
                    MessageBox.Show("Home phone number must contain only numeric characters.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    homePhoneTextBox.Focus();
                    return false;
                }
            }
            
            // Validate contact number
            if (!string.IsNullOrWhiteSpace(contactNoTextBox.Text))
            {
                if (!int.TryParse(contactNoTextBox.Text.Trim(), out _))
                {
                    MessageBox.Show("Contact number must contain only numeric characters.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contactNoTextBox.Focus();
                    return false;
                }
            }
            
            return true;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || 
                string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter first name and last name.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!maleRadioButton.Checked && !femaleRadioButton.Checked)
            {
                MessageBox.Show("Please select gender.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (!ValidatePhoneNumbers())
            {
                return false;
            }

            return true;
        }

        private void AddParameters(SqlCommand command)
        {
            command.Parameters.AddWithValue("@firstName", firstNameTextBox.Text.Trim());
            command.Parameters.AddWithValue("@lastName", lastNameTextBox.Text.Trim());
            command.Parameters.AddWithValue("@dateOfBirth", dateOfBirthDateTimePicker.Value);
            command.Parameters.AddWithValue("@gender", maleRadioButton.Checked ? "Male" : "Female");
            command.Parameters.AddWithValue("@address", addressTextBox.Text.Trim());
            command.Parameters.AddWithValue("@email", emailTextBox.Text.Trim());
            
            // Add mobile phone parameter
            if (string.IsNullOrWhiteSpace(mobilePhoneTextBox.Text))
            {
                command.Parameters.AddWithValue("@mobilePhone", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@mobilePhone", int.Parse(mobilePhoneTextBox.Text.Trim()));
            }
            
            // Add home phone parameter
            if (string.IsNullOrWhiteSpace(homePhoneTextBox.Text))
            {
                command.Parameters.AddWithValue("@homePhone", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@homePhone", int.Parse(homePhoneTextBox.Text.Trim()));
            }
            
            command.Parameters.AddWithValue("@parentName", parentNameTextBox.Text.Trim());
            command.Parameters.AddWithValue("@nic", nicTextBox.Text.Trim());
            
            // Add contact number parameter
            if (string.IsNullOrWhiteSpace(contactNoTextBox.Text))
            {
                command.Parameters.AddWithValue("@contactNo", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@contactNo", int.Parse(contactNoTextBox.Text.Trim()));
            }
        }

        private void ClearFields()
        {
            regNoComboBox.SelectedIndex = -1;
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            dateOfBirthDateTimePicker.Value = DateTime.Now;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            addressTextBox.Clear();
            emailTextBox.Clear();
            mobilePhoneTextBox.Clear();
            homePhoneTextBox.Clear();
            parentNameTextBox.Clear();
            nicTextBox.Clear();
            contactNoTextBox.Clear();
        }
    }
}