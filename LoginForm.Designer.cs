namespace StudentManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            ClearButton = new Button();
            BackButton = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Microsoft Sans Serif", 10F);
            UsernameLabel.Location = new Point(405, 215);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(77, 17);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Microsoft Sans Serif", 10F);
            PasswordLabel.Location = new Point(405, 255);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(73, 17);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameTextBox.Font = new Font("Microsoft Sans Serif", 10F);
            UsernameTextBox.Location = new Point(505, 212);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(210, 23);
            UsernameTextBox.TabIndex = 3;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 10F);
            PasswordTextBox.Location = new Point(505, 252);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(210, 23);
            PasswordTextBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(0, 123, 255);
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(649, 351);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 35);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.FromArgb(108, 117, 125);
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(549, 351);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 35);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(220, 53, 69);
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(448, 351);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 35);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold);
            label2.Location = new Point(257, 29);
            label2.Name = "label2";
            label2.Size = new Size(307, 46);
            label2.TabIndex = 9;
            label2.Text = "Skills International";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 127);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.Location = new Point(536, 137);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 11;
            label1.Text = "User Login";
            label1.Click += label1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(818, 499);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(BackButton);
            Controls.Add(ClearButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackButton;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}