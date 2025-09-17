namespace StudentManagementSystem
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            Text = "Student Management System - Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide welcome form
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(); // Shows as modal dialog
            this.Show(); // Show welcome form again after login form closes
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
