namespace StudentManagementSystem
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            titleLabel = new Label();
            logoutLinkLabel = new LinkLabel();
            studentRegistrationGroupBox = new GroupBox();
            regNoLabel = new Label();
            regNoComboBox = new ComboBox();
            basicDetailsGroupBox = new GroupBox();
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            dateOfBirthLabel = new Label();
            dateOfBirthDateTimePicker = new DateTimePicker();
            genderLabel = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            contactDetailsGroupBox = new GroupBox();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            mobilePhoneLabel = new Label();
            mobilePhoneTextBox = new TextBox();
            homePhoneLabel = new Label();
            homePhoneTextBox = new TextBox();
            parentDetailsGroupBox = new GroupBox();
            parentNameLabel = new Label();
            parentNameTextBox = new TextBox();
            nicLabel = new Label();
            nicTextBox = new TextBox();
            contactNoLabel = new Label();
            contactNoTextBox = new TextBox();
            registerButton = new Button();
            updateButton = new Button();
            clearButton = new Button();
            deleteButton = new Button();
            registrationDataGridView = new DataGridView();
            studentRegistrationGroupBox.SuspendLayout();
            basicDetailsGroupBox.SuspendLayout();
            contactDetailsGroupBox.SuspendLayout();
            parentDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registrationDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Location = new Point(292, 23);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(306, 37);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Skills International";
            // 
            // logoutLinkLabel
            // 
            logoutLinkLabel.AutoSize = true;
            logoutLinkLabel.Location = new Point(43, 45);
            logoutLinkLabel.Margin = new Padding(4, 0, 4, 0);
            logoutLinkLabel.Name = "logoutLinkLabel";
            logoutLinkLabel.Size = new Size(45, 15);
            logoutLinkLabel.TabIndex = 1;
            logoutLinkLabel.TabStop = true;
            logoutLinkLabel.Text = "Logout";
            logoutLinkLabel.LinkClicked += LogoutLinkLabel_LinkClicked;
            // 
            // studentRegistrationGroupBox
            // 
            studentRegistrationGroupBox.Controls.Add(regNoLabel);
            studentRegistrationGroupBox.Controls.Add(regNoComboBox);
            studentRegistrationGroupBox.Location = new Point(51, 123);
            studentRegistrationGroupBox.Margin = new Padding(4, 3, 4, 3);
            studentRegistrationGroupBox.Name = "studentRegistrationGroupBox";
            studentRegistrationGroupBox.Padding = new Padding(4, 3, 4, 3);
            studentRegistrationGroupBox.Size = new Size(333, 92);
            studentRegistrationGroupBox.TabIndex = 3;
            studentRegistrationGroupBox.TabStop = false;
            studentRegistrationGroupBox.Text = "Student Registration";
            // 
            // regNoLabel
            // 
            regNoLabel.AutoSize = true;
            regNoLabel.Location = new Point(18, 35);
            regNoLabel.Margin = new Padding(4, 0, 4, 0);
            regNoLabel.Name = "regNoLabel";
            regNoLabel.Size = new Size(46, 15);
            regNoLabel.TabIndex = 0;
            regNoLabel.Text = "Reg No";
            // 
            // regNoComboBox
            // 
            regNoComboBox.FormattingEnabled = true;
            regNoComboBox.Location = new Point(18, 52);
            regNoComboBox.Margin = new Padding(4, 3, 4, 3);
            regNoComboBox.Name = "regNoComboBox";
            regNoComboBox.Size = new Size(245, 23);
            regNoComboBox.TabIndex = 1;
            regNoComboBox.SelectedIndexChanged += regNoComboBox_SelectedIndexChanged;
            // 
            // basicDetailsGroupBox
            // 
            basicDetailsGroupBox.Controls.Add(firstNameLabel);
            basicDetailsGroupBox.Controls.Add(firstNameTextBox);
            basicDetailsGroupBox.Controls.Add(lastNameLabel);
            basicDetailsGroupBox.Controls.Add(lastNameTextBox);
            basicDetailsGroupBox.Controls.Add(dateOfBirthLabel);
            basicDetailsGroupBox.Controls.Add(dateOfBirthDateTimePicker);
            basicDetailsGroupBox.Controls.Add(genderLabel);
            basicDetailsGroupBox.Controls.Add(maleRadioButton);
            basicDetailsGroupBox.Controls.Add(femaleRadioButton);
            basicDetailsGroupBox.Location = new Point(421, 77);
            basicDetailsGroupBox.Margin = new Padding(4, 3, 4, 3);
            basicDetailsGroupBox.Name = "basicDetailsGroupBox";
            basicDetailsGroupBox.Padding = new Padding(4, 3, 4, 3);
            basicDetailsGroupBox.Size = new Size(459, 173);
            basicDetailsGroupBox.TabIndex = 4;
            basicDetailsGroupBox.TabStop = false;
            basicDetailsGroupBox.Text = "Basic Details";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(18, 35);
            firstNameLabel.Margin = new Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(117, 31);
            firstNameTextBox.Margin = new Padding(4, 3, 4, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(318, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(18, 63);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(117, 60);
            lastNameTextBox.Margin = new Padding(4, 3, 4, 3);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(318, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(18, 92);
            dateOfBirthLabel.Margin = new Padding(4, 0, 4, 0);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(73, 15);
            dateOfBirthLabel.TabIndex = 4;
            dateOfBirthLabel.Text = "Date of Birth";
            // 
            // dateOfBirthDateTimePicker
            // 
            dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short;
            dateOfBirthDateTimePicker.Location = new Point(117, 89);
            dateOfBirthDateTimePicker.Margin = new Padding(4, 3, 4, 3);
            dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            dateOfBirthDateTimePicker.Size = new Size(209, 23);
            dateOfBirthDateTimePicker.TabIndex = 5;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(18, 127);
            genderLabel.Margin = new Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(45, 15);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Gender";
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(117, 127);
            maleRadioButton.Margin = new Padding(4, 3, 4, 3);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(51, 19);
            maleRadioButton.TabIndex = 7;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(210, 127);
            femaleRadioButton.Margin = new Padding(4, 3, 4, 3);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(63, 19);
            femaleRadioButton.TabIndex = 8;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // contactDetailsGroupBox
            // 
            contactDetailsGroupBox.Controls.Add(addressLabel);
            contactDetailsGroupBox.Controls.Add(addressTextBox);
            contactDetailsGroupBox.Controls.Add(emailLabel);
            contactDetailsGroupBox.Controls.Add(emailTextBox);
            contactDetailsGroupBox.Controls.Add(mobilePhoneLabel);
            contactDetailsGroupBox.Controls.Add(mobilePhoneTextBox);
            contactDetailsGroupBox.Controls.Add(homePhoneLabel);
            contactDetailsGroupBox.Controls.Add(homePhoneTextBox);
            contactDetailsGroupBox.Location = new Point(55, 252);
            contactDetailsGroupBox.Margin = new Padding(4, 3, 4, 3);
            contactDetailsGroupBox.Name = "contactDetailsGroupBox";
            contactDetailsGroupBox.Padding = new Padding(4, 3, 4, 3);
            contactDetailsGroupBox.Size = new Size(823, 144);
            contactDetailsGroupBox.TabIndex = 5;
            contactDetailsGroupBox.TabStop = false;
            contactDetailsGroupBox.Text = "Contact Details";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(18, 35);
            addressLabel.Margin = new Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(49, 15);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(117, 31);
            addressTextBox.Margin = new Padding(4, 3, 4, 3);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(682, 40);
            addressTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(18, 87);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(117, 83);
            emailTextBox.Margin = new Padding(4, 3, 4, 3);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(542, 23);
            emailTextBox.TabIndex = 3;
            // 
            // mobilePhoneLabel
            // 
            mobilePhoneLabel.AutoSize = true;
            mobilePhoneLabel.Location = new Point(18, 115);
            mobilePhoneLabel.Margin = new Padding(4, 0, 4, 0);
            mobilePhoneLabel.Name = "mobilePhoneLabel";
            mobilePhoneLabel.Size = new Size(81, 15);
            mobilePhoneLabel.TabIndex = 4;
            mobilePhoneLabel.Text = "Mobile Phone";
            // 
            // mobilePhoneTextBox
            // 
            mobilePhoneTextBox.Location = new Point(117, 112);
            mobilePhoneTextBox.Margin = new Padding(4, 3, 4, 3);
            mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            mobilePhoneTextBox.Size = new Size(174, 23);
            mobilePhoneTextBox.TabIndex = 5;
            // 
            // homePhoneLabel
            // 
            homePhoneLabel.AutoSize = true;
            homePhoneLabel.Location = new Point(315, 115);
            homePhoneLabel.Margin = new Padding(4, 0, 4, 0);
            homePhoneLabel.Name = "homePhoneLabel";
            homePhoneLabel.Size = new Size(77, 15);
            homePhoneLabel.TabIndex = 6;
            homePhoneLabel.Text = "Home Phone";
            // 
            // homePhoneTextBox
            // 
            homePhoneTextBox.Location = new Point(408, 112);
            homePhoneTextBox.Margin = new Padding(4, 3, 4, 3);
            homePhoneTextBox.Name = "homePhoneTextBox";
            homePhoneTextBox.Size = new Size(174, 23);
            homePhoneTextBox.TabIndex = 7;
            // 
            // parentDetailsGroupBox
            // 
            parentDetailsGroupBox.Controls.Add(parentNameLabel);
            parentDetailsGroupBox.Controls.Add(parentNameTextBox);
            parentDetailsGroupBox.Controls.Add(nicLabel);
            parentDetailsGroupBox.Controls.Add(nicTextBox);
            parentDetailsGroupBox.Controls.Add(contactNoLabel);
            parentDetailsGroupBox.Controls.Add(contactNoTextBox);
            parentDetailsGroupBox.Location = new Point(57, 407);
            parentDetailsGroupBox.Margin = new Padding(4, 3, 4, 3);
            parentDetailsGroupBox.Name = "parentDetailsGroupBox";
            parentDetailsGroupBox.Padding = new Padding(4, 3, 4, 3);
            parentDetailsGroupBox.Size = new Size(618, 115);
            parentDetailsGroupBox.TabIndex = 6;
            parentDetailsGroupBox.TabStop = false;
            parentDetailsGroupBox.Text = "Parent Details";
            // 
            // parentNameLabel
            // 
            parentNameLabel.AutoSize = true;
            parentNameLabel.Location = new Point(18, 35);
            parentNameLabel.Margin = new Padding(4, 0, 4, 0);
            parentNameLabel.Name = "parentNameLabel";
            parentNameLabel.Size = new Size(76, 15);
            parentNameLabel.TabIndex = 0;
            parentNameLabel.Text = "Parent Name";
            // 
            // parentNameTextBox
            // 
            parentNameTextBox.Location = new Point(117, 31);
            parentNameTextBox.Margin = new Padding(4, 3, 4, 3);
            parentNameTextBox.Name = "parentNameTextBox";
            parentNameTextBox.Size = new Size(466, 23);
            parentNameTextBox.TabIndex = 1;
            // 
            // nicLabel
            // 
            nicLabel.AutoSize = true;
            nicLabel.Location = new Point(18, 69);
            nicLabel.Margin = new Padding(4, 0, 4, 0);
            nicLabel.Name = "nicLabel";
            nicLabel.Size = new Size(27, 15);
            nicLabel.TabIndex = 2;
            nicLabel.Text = "NIC";
            // 
            // nicTextBox
            // 
            nicTextBox.Location = new Point(117, 66);
            nicTextBox.Margin = new Padding(4, 3, 4, 3);
            nicTextBox.Name = "nicTextBox";
            nicTextBox.Size = new Size(174, 23);
            nicTextBox.TabIndex = 3;
            // 
            // contactNoLabel
            // 
            contactNoLabel.AutoSize = true;
            contactNoLabel.Location = new Point(315, 69);
            contactNoLabel.Margin = new Padding(4, 0, 4, 0);
            contactNoLabel.Name = "contactNoLabel";
            contactNoLabel.Size = new Size(68, 15);
            contactNoLabel.TabIndex = 4;
            contactNoLabel.Text = "Contact No";
            // 
            // contactNoTextBox
            // 
            contactNoTextBox.Location = new Point(408, 66);
            contactNoTextBox.Margin = new Padding(4, 3, 4, 3);
            contactNoTextBox.Name = "contactNoTextBox";
            contactNoTextBox.Size = new Size(174, 23);
            contactNoTextBox.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(189, 541);
            registerButton.Margin = new Padding(4, 3, 4, 3);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(88, 27);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += RegisterButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(305, 541);
            updateButton.Margin = new Padding(4, 3, 4, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 27);
            updateButton.TabIndex = 8;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(539, 541);
            clearButton.Margin = new Padding(4, 3, 4, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(88, 27);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(655, 541);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 27);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // registrationDataGridView
            // 
            registrationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            registrationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registrationDataGridView.Location = new Point(25, 587);
            registrationDataGridView.Margin = new Padding(4, 3, 4, 3);
            registrationDataGridView.Name = "registrationDataGridView";
            registrationDataGridView.ReadOnly = true;
            registrationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            registrationDataGridView.Size = new Size(884, 173);
            registrationDataGridView.TabIndex = 11;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(933, 779);
            Controls.Add(registrationDataGridView);
            Controls.Add(deleteButton);
            Controls.Add(clearButton);
            Controls.Add(updateButton);
            Controls.Add(registerButton);
            Controls.Add(parentDetailsGroupBox);
            Controls.Add(contactDetailsGroupBox);
            Controls.Add(basicDetailsGroupBox);
            Controls.Add(studentRegistrationGroupBox);
            Controls.Add(logoutLinkLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistrationForm";
            Text = "Student Registration";
            Load += RegistrationForm_Load;
            studentRegistrationGroupBox.ResumeLayout(false);
            studentRegistrationGroupBox.PerformLayout();
            basicDetailsGroupBox.ResumeLayout(false);
            basicDetailsGroupBox.PerformLayout();
            contactDetailsGroupBox.ResumeLayout(false);
            contactDetailsGroupBox.PerformLayout();
            parentDetailsGroupBox.ResumeLayout(false);
            parentDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)registrationDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.GroupBox studentRegistrationGroupBox;
        private System.Windows.Forms.Label regNoLabel;
        private System.Windows.Forms.ComboBox regNoComboBox;
        private System.Windows.Forms.GroupBox basicDetailsGroupBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.GroupBox contactDetailsGroupBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label mobilePhoneLabel;
        private System.Windows.Forms.TextBox mobilePhoneTextBox;
        private System.Windows.Forms.Label homePhoneLabel;
        private System.Windows.Forms.TextBox homePhoneTextBox;
        private System.Windows.Forms.GroupBox parentDetailsGroupBox;
        private System.Windows.Forms.Label parentNameLabel;
        private System.Windows.Forms.TextBox parentNameTextBox;
        private System.Windows.Forms.Label nicLabel;
        private System.Windows.Forms.TextBox nicTextBox;
        private System.Windows.Forms.Label contactNoLabel;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView registrationDataGridView;
    }
}