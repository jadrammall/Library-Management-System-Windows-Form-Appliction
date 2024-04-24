namespace LMS_JadRammal
{
    partial class IssueBook
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
            label4 = new Label();
            idTxt = new TextBox();
            label3 = new Label();
            usernameTxt = new TextBox();
            issueBtn = new Button();
            label12 = new Label();
            nbFineAmount = new Label();
            nbReturnedBooks = new Label();
            nbIssuedBooks = new Label();
            label8 = new Label();
            label7 = new Label();
            emailTxt = new TextBox();
            label5 = new Label();
            contactTxt = new TextBox();
            label6 = new Label();
            reissueBtn = new Button();
            panel2 = new Panel();
            label13 = new Label();
            label2 = new Label();
            idsearchTxt = new TextBox();
            panel3 = new Panel();
            usersearchBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 142);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 9;
            label4.Text = "Contact";
            // 
            // idTxt
            // 
            idTxt.Location = new Point(73, 79);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(227, 23);
            idTxt.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 80);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "User ID";
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(73, 25);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(227, 23);
            usernameTxt.TabIndex = 6;
            // 
            // issueBtn
            // 
            issueBtn.BackColor = Color.FromArgb(46, 204, 113);
            issueBtn.FlatAppearance.BorderSize = 0;
            issueBtn.FlatStyle = FlatStyle.Flat;
            issueBtn.ForeColor = Color.Cornsilk;
            issueBtn.Location = new Point(3, 281);
            issueBtn.Name = "issueBtn";
            issueBtn.Size = new Size(294, 33);
            issueBtn.TabIndex = 4;
            issueBtn.Text = "Issue Book";
            issueBtn.UseVisualStyleBackColor = false;
            issueBtn.Click += issueBtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(67, 226);
            label12.Name = "label12";
            label12.Size = new Size(19, 15);
            label12.TabIndex = 6;
            label12.Text = "$$";
            // 
            // nbFineAmount
            // 
            nbFineAmount.AutoSize = true;
            nbFineAmount.Location = new Point(5, 226);
            nbFineAmount.Name = "nbFineAmount";
            nbFineAmount.Size = new Size(13, 15);
            nbFineAmount.TabIndex = 5;
            nbFineAmount.Text = "0";
            // 
            // nbReturnedBooks
            // 
            nbReturnedBooks.AutoSize = true;
            nbReturnedBooks.Location = new Point(5, 144);
            nbReturnedBooks.Name = "nbReturnedBooks";
            nbReturnedBooks.Size = new Size(13, 15);
            nbReturnedBooks.TabIndex = 4;
            nbReturnedBooks.Text = "0";
            // 
            // nbIssuedBooks
            // 
            nbIssuedBooks.AutoSize = true;
            nbIssuedBooks.Location = new Point(5, 59);
            nbIssuedBooks.Name = "nbIssuedBooks";
            nbIssuedBooks.Size = new Size(13, 15);
            nbIssuedBooks.TabIndex = 3;
            nbIssuedBooks.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 188);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 2;
            label8.Text = "Fine Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 105);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 1;
            label7.Text = "Returned Books";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(73, 207);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(227, 23);
            emailTxt.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 208);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // contactTxt
            // 
            contactTxt.Location = new Point(73, 141);
            contactTxt.Name = "contactTxt";
            contactTxt.Size = new Size(227, 23);
            contactTxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 25);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 0;
            label6.Text = "Issued Books";
            // 
            // reissueBtn
            // 
            reissueBtn.BackColor = Color.FromArgb(255, 128, 0);
            reissueBtn.FlatAppearance.BorderSize = 0;
            reissueBtn.FlatStyle = FlatStyle.Flat;
            reissueBtn.ForeColor = Color.Cornsilk;
            reissueBtn.Location = new Point(3, 242);
            reissueBtn.Name = "reissueBtn";
            reissueBtn.Size = new Size(294, 33);
            reissueBtn.TabIndex = 14;
            reissueBtn.Text = "Re-Issue Book";
            reissueBtn.UseVisualStyleBackColor = false;
            reissueBtn.Click += reissueBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(reissueBtn);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(emailTxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(contactTxt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(idTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(usernameTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(issueBtn);
            panel2.Location = new Point(3, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 317);
            panel2.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(5, 252);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 26);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // idsearchTxt
            // 
            idsearchTxt.Location = new Point(76, 11);
            idsearchTxt.Name = "idsearchTxt";
            idsearchTxt.Size = new Size(227, 23);
            idsearchTxt.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label12);
            panel3.Controls.Add(nbFineAmount);
            panel3.Controls.Add(nbReturnedBooks);
            panel3.Controls.Add(nbIssuedBooks);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(309, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(127, 317);
            panel3.TabIndex = 11;
            // 
            // usersearchBtn
            // 
            usersearchBtn.BackColor = Color.FromArgb(46, 204, 113);
            usersearchBtn.FlatAppearance.BorderSize = 0;
            usersearchBtn.FlatStyle = FlatStyle.Flat;
            usersearchBtn.ForeColor = Color.Cornsilk;
            usersearchBtn.Location = new Point(309, 11);
            usersearchBtn.Name = "usersearchBtn";
            usersearchBtn.Size = new Size(127, 23);
            usersearchBtn.TabIndex = 2;
            usersearchBtn.Text = "Search";
            usersearchBtn.UseVisualStyleBackColor = false;
            usersearchBtn.Click += usersearchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "User ID";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(idsearchTxt);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(usersearchBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 360);
            panel1.TabIndex = 4;
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "IssueBook";
            Size = new Size(445, 360);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private TextBox idTxt;
        private Label label3;
        private TextBox usernameTxt;
        private Button issueBtn;
        private Label label12;
        private Label nbFineAmount;
        private Label nbReturnedBooks;
        private Label nbIssuedBooks;
        private Label label8;
        private Label label7;
        private TextBox emailTxt;
        private Label label5;
        private TextBox contactTxt;
        private Label label6;
        private Button reissueBtn;
        private Panel panel2;
        private Label label13;
        private Label label2;
        private TextBox idsearchTxt;
        private Panel panel3;
        private Button usersearchBtn;
        private Label label1;
        private Panel panel1;
    }
}
