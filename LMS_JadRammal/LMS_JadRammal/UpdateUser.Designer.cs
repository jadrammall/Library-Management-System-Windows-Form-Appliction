namespace LMS_JadRammal
{
    partial class UpdateUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usersearchBtn = new Button();
            idsearchTxt = new TextBox();
            label1 = new Label();
            updateuserPanel = new Panel();
            cancelBtn = new Button();
            contactTxt = new TextBox();
            updateuserBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            emailTxt = new TextBox();
            usernameTxt = new TextBox();
            label5 = new Label();
            idTxt = new TextBox();
            label4 = new Label();
            updateuserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // usersearchBtn
            // 
            usersearchBtn.BackColor = Color.FromArgb(46, 204, 113);
            usersearchBtn.FlatAppearance.BorderSize = 0;
            usersearchBtn.FlatStyle = FlatStyle.Flat;
            usersearchBtn.ForeColor = Color.White;
            usersearchBtn.Location = new Point(319, 5);
            usersearchBtn.Name = "usersearchBtn";
            usersearchBtn.Size = new Size(104, 23);
            usersearchBtn.TabIndex = 20;
            usersearchBtn.Text = "Search";
            usersearchBtn.UseVisualStyleBackColor = false;
            usersearchBtn.Click += usersearchBtn_Click;
            // 
            // idsearchTxt
            // 
            idsearchTxt.Location = new Point(85, 5);
            idsearchTxt.Name = "idsearchTxt";
            idsearchTxt.Size = new Size(218, 23);
            idsearchTxt.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 18;
            label1.Text = "User ID";
            // 
            // updateuserPanel
            // 
            updateuserPanel.Controls.Add(cancelBtn);
            updateuserPanel.Controls.Add(contactTxt);
            updateuserPanel.Controls.Add(updateuserBtn);
            updateuserPanel.Controls.Add(label3);
            updateuserPanel.Controls.Add(label2);
            updateuserPanel.Controls.Add(emailTxt);
            updateuserPanel.Controls.Add(usernameTxt);
            updateuserPanel.Controls.Add(label5);
            updateuserPanel.Controls.Add(idTxt);
            updateuserPanel.Controls.Add(label4);
            updateuserPanel.Location = new Point(3, 37);
            updateuserPanel.Name = "updateuserPanel";
            updateuserPanel.Size = new Size(439, 318);
            updateuserPanel.TabIndex = 21;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(255, 128, 0);
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.WhiteSmoke;
            cancelBtn.Location = new Point(10, 271);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(410, 31);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // contactTxt
            // 
            contactTxt.Location = new Point(82, 120);
            contactTxt.Name = "contactTxt";
            contactTxt.Size = new Size(338, 23);
            contactTxt.TabIndex = 15;
            // 
            // updateuserBtn
            // 
            updateuserBtn.BackColor = Color.FromArgb(46, 204, 113);
            updateuserBtn.FlatAppearance.BorderSize = 0;
            updateuserBtn.FlatStyle = FlatStyle.Flat;
            updateuserBtn.ForeColor = Color.White;
            updateuserBtn.Location = new Point(10, 229);
            updateuserBtn.Name = "updateuserBtn";
            updateuserBtn.Size = new Size(410, 31);
            updateuserBtn.TabIndex = 12;
            updateuserBtn.Text = "Update";
            updateuserBtn.UseVisualStyleBackColor = false;
            updateuserBtn.Click += updateuserBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 66);
            label3.Name = "label3";
            label3.Size = new Size(21, 17);
            label3.TabIndex = 5;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 23);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(82, 164);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(338, 23);
            emailTxt.TabIndex = 10;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(82, 20);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(338, 23);
            usernameTxt.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(5, 167);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // idTxt
            // 
            idTxt.Location = new Point(82, 63);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(338, 23);
            idTxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 120);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 7;
            label4.Text = "Contact";
            // 
            // UpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(usersearchBtn);
            Controls.Add(idsearchTxt);
            Controls.Add(label1);
            Controls.Add(updateuserPanel);
            Name = "UpdateUser";
            Size = new Size(445, 360);
            Load += UpdateUser_Load;
            updateuserPanel.ResumeLayout(false);
            updateuserPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button usersearchBtn;
        private TextBox idsearchTxt;
        private Label label1;
        private Panel updateuserPanel;
        private Button cancelBtn;
        private TextBox contactTxt;
        private Button updateuserBtn;
        private Label label3;
        private Label label2;
        private TextBox emailTxt;
        private TextBox usernameTxt;
        private Label label5;
        private TextBox idTxt;
        private Label label4;
    }
}
