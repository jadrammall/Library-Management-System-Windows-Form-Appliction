namespace LMS_JadRammal
{
    partial class DeleteUser
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
            deleteuserPanel = new Panel();
            cancelBtn = new Button();
            contactTxt = new TextBox();
            deleteuserBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            emailTxt = new TextBox();
            usernameTxt = new TextBox();
            label5 = new Label();
            idTxt = new TextBox();
            label4 = new Label();
            deleteuserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // usersearchBtn
            // 
            usersearchBtn.BackColor = Color.FromArgb(46, 204, 113);
            usersearchBtn.FlatAppearance.BorderSize = 0;
            usersearchBtn.FlatStyle = FlatStyle.Flat;
            usersearchBtn.ForeColor = Color.White;
            usersearchBtn.Location = new Point(335, 3);
            usersearchBtn.Name = "usersearchBtn";
            usersearchBtn.Size = new Size(104, 23);
            usersearchBtn.TabIndex = 24;
            usersearchBtn.Text = "Search";
            usersearchBtn.UseVisualStyleBackColor = false;
            usersearchBtn.Click += usersearchBtn_Click;
            // 
            // idsearchTxt
            // 
            idsearchTxt.Location = new Point(90, 3);
            idsearchTxt.Name = "idsearchTxt";
            idsearchTxt.Size = new Size(239, 23);
            idsearchTxt.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 6);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 22;
            label1.Text = "User ID";
            // 
            // deleteuserPanel
            // 
            deleteuserPanel.Controls.Add(cancelBtn);
            deleteuserPanel.Controls.Add(contactTxt);
            deleteuserPanel.Controls.Add(deleteuserBtn);
            deleteuserPanel.Controls.Add(label3);
            deleteuserPanel.Controls.Add(label2);
            deleteuserPanel.Controls.Add(emailTxt);
            deleteuserPanel.Controls.Add(usernameTxt);
            deleteuserPanel.Controls.Add(label5);
            deleteuserPanel.Controls.Add(idTxt);
            deleteuserPanel.Controls.Add(label4);
            deleteuserPanel.Location = new Point(8, 35);
            deleteuserPanel.Name = "deleteuserPanel";
            deleteuserPanel.Size = new Size(431, 317);
            deleteuserPanel.TabIndex = 25;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(255, 128, 0);
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(10, 270);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(412, 31);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // contactTxt
            // 
            contactTxt.Location = new Point(82, 120);
            contactTxt.Name = "contactTxt";
            contactTxt.Size = new Size(340, 23);
            contactTxt.TabIndex = 15;
            // 
            // deleteuserBtn
            // 
            deleteuserBtn.BackColor = Color.Red;
            deleteuserBtn.FlatAppearance.BorderSize = 0;
            deleteuserBtn.FlatStyle = FlatStyle.Flat;
            deleteuserBtn.ForeColor = Color.White;
            deleteuserBtn.Location = new Point(10, 232);
            deleteuserBtn.Name = "deleteuserBtn";
            deleteuserBtn.Size = new Size(412, 31);
            deleteuserBtn.TabIndex = 12;
            deleteuserBtn.Text = "Delete";
            deleteuserBtn.UseVisualStyleBackColor = false;
            deleteuserBtn.Click += deleteuserBtn_Click;
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
            emailTxt.Size = new Size(340, 23);
            emailTxt.TabIndex = 10;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(82, 20);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(340, 23);
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
            idTxt.Size = new Size(340, 23);
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
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(usersearchBtn);
            Controls.Add(idsearchTxt);
            Controls.Add(label1);
            Controls.Add(deleteuserPanel);
            Name = "DeleteUser";
            Size = new Size(445, 360);
            Load += DeleteUser_Load;
            deleteuserPanel.ResumeLayout(false);
            deleteuserPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button usersearchBtn;
        private TextBox idsearchTxt;
        private Label label1;
        private Panel deleteuserPanel;
        private Button cancelBtn;
        private TextBox contactTxt;
        private Button deleteuserBtn;
        private Label label3;
        private Label label2;
        private TextBox emailTxt;
        private TextBox usernameTxt;
        private Label label5;
        private TextBox idTxt;
        private Label label4;
    }
}
