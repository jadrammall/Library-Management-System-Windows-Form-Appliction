namespace LMS_JadRammal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            PasswordText = new TextBox();
            Password = new Label();
            loginBtn = new Button();
            UsernameText = new TextBox();
            Username = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PasswordText
            // 
            PasswordText.Anchor = AnchorStyles.None;
            PasswordText.Location = new Point(254, 195);
            PasswordText.Margin = new Padding(0);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(201, 23);
            PasswordText.TabIndex = 15;
            PasswordText.TextChanged += PasswordText_TextChanged_1;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.None;
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Password.Location = new Point(251, 166);
            Password.Name = "Password";
            Password.Size = new Size(66, 17);
            Password.TabIndex = 14;
            Password.Text = "Password";
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.None;
            loginBtn.BackColor = Color.FromArgb(46, 204, 113);
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(254, 249);
            loginBtn.Margin = new Padding(0);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(201, 35);
            loginBtn.TabIndex = 13;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // UsernameText
            // 
            UsernameText.Anchor = AnchorStyles.None;
            UsernameText.Location = new Point(254, 123);
            UsernameText.Margin = new Padding(0);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(201, 23);
            UsernameText.TabIndex = 12;
            UsernameText.TextChanged += UsernameText_TextChanged;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.None;
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Username.Location = new Point(251, 94);
            Username.Name = "Username";
            Username.Size = new Size(69, 17);
            Username.TabIndex = 11;
            Username.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(309, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 349);
            Controls.Add(PasswordText);
            Controls.Add(Password);
            Controls.Add(loginBtn);
            Controls.Add(UsernameText);
            Controls.Add(Username);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordText;
        private Label Password;
        private Button loginBtn;
        private TextBox UsernameText;
        private Label Username;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}