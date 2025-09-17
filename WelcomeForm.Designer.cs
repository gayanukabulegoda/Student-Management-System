namespace StudentManagementSystem
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            LogInButton = new Button();
            label1 = new Label();
            ExitButton = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogInButton
            // 
            LogInButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogInButton.BackColor = Color.PaleTurquoise;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.FlatAppearance.BorderSize = 0;
            LogInButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInButton.Location = new Point(422, 419);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(125, 42);
            LogInButton.TabIndex = 0;
            LogInButton.Text = "Let's Go";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 298);
            label1.Name = "label1";
            label1.Size = new Size(583, 54);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Skills International";
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExitButton.BackColor = Color.Bisque;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(278, 419);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(125, 42);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 17);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(318, 361);
            label2.Name = "label2";
            label2.Size = new Size(185, 19);
            label2.TabIndex = 4;
            label2.Text = "Student Management Portal";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(818, 499);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(ExitButton);
            Controls.Add(label1);
            Controls.Add(LogInButton);
            Name = "WelcomeForm";
            Text = "Welcome !!";
            Load += WelcomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogInButton;
        private Label label1;
        private Button ExitButton;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
