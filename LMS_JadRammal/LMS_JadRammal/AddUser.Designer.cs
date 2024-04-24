namespace LMS_JadRammal
{
    partial class Add_User
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
            saveBtn = new Button();
            UEmail = new TextBox();
            label4 = new Label();
            UContact = new TextBox();
            label3 = new Label();
            UID = new TextBox();
            label2 = new Label();
            Uname = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(40, 204, 113);
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.ForeColor = Color.Cornsilk;
            saveBtn.Location = new Point(25, 313);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(401, 37);
            saveBtn.TabIndex = 17;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // UEmail
            // 
            UEmail.Location = new Point(25, 266);
            UEmail.Name = "UEmail";
            UEmail.Size = new Size(401, 23);
            UEmail.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 236);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 15;
            label4.Text = "Email";
            // 
            // UContact
            // 
            UContact.Location = new Point(25, 187);
            UContact.Name = "UContact";
            UContact.Size = new Size(401, 23);
            UContact.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 156);
            label3.Name = "label3";
            label3.Size = new Size(109, 17);
            label3.TabIndex = 13;
            label3.Text = "Contact Number";
            // 
            // UID
            // 
            UID.Location = new Point(25, 112);
            UID.Name = "UID";
            UID.Size = new Size(401, 23);
            UID.TabIndex = 12;
            UID.Text = "XXXX-YY-ZZZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 11;
            label2.Text = "User ID";
            // 
            // Uname
            // 
            Uname.Location = new Point(25, 41);
            Uname.Name = "Uname";
            Uname.Size = new Size(401, 23);
            Uname.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 10);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // Add_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(saveBtn);
            Controls.Add(UEmail);
            Controls.Add(label4);
            Controls.Add(UContact);
            Controls.Add(label3);
            Controls.Add(UID);
            Controls.Add(label2);
            Controls.Add(Uname);
            Controls.Add(label1);
            Name = "Add_User";
            Size = new Size(445, 360);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private TextBox UEmail;
        private Label label4;
        private TextBox UContact;
        private Label label3;
        private TextBox UID;
        private Label label2;
        private TextBox Uname;
        private Label label1;
    }
}
