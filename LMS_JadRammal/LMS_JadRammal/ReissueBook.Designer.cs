namespace LMS_JadRammal
{
    partial class ReissueBook
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
            reissuePanel = new Panel();
            cancelBtn = new Button();
            returnDTP = new DateTimePicker();
            label8 = new Label();
            isbnTxt = new TextBox();
            label7 = new Label();
            issueDTP = new DateTimePicker();
            label6 = new Label();
            dateTxt = new TextBox();
            label5 = new Label();
            catTxt = new TextBox();
            label4 = new Label();
            idTxt = new TextBox();
            label3 = new Label();
            booknameTxt = new TextBox();
            label2 = new Label();
            reissueBtn = new Button();
            isbnsearchBtn = new Button();
            isbnsearchTxt = new TextBox();
            label1 = new Label();
            reissuePanel.SuspendLayout();
            SuspendLayout();
            // 
            // reissuePanel
            // 
            reissuePanel.Controls.Add(cancelBtn);
            reissuePanel.Controls.Add(returnDTP);
            reissuePanel.Controls.Add(label8);
            reissuePanel.Controls.Add(isbnTxt);
            reissuePanel.Controls.Add(label7);
            reissuePanel.Controls.Add(issueDTP);
            reissuePanel.Controls.Add(label6);
            reissuePanel.Controls.Add(dateTxt);
            reissuePanel.Controls.Add(label5);
            reissuePanel.Controls.Add(catTxt);
            reissuePanel.Controls.Add(label4);
            reissuePanel.Controls.Add(idTxt);
            reissuePanel.Controls.Add(label3);
            reissuePanel.Controls.Add(booknameTxt);
            reissuePanel.Controls.Add(label2);
            reissuePanel.Controls.Add(reissueBtn);
            reissuePanel.Location = new Point(6, 37);
            reissuePanel.Name = "reissuePanel";
            reissuePanel.Size = new Size(433, 317);
            reissuePanel.TabIndex = 22;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Red;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.Cornsilk;
            cancelBtn.Location = new Point(6, 269);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(424, 33);
            cancelBtn.TabIndex = 19;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // returnDTP
            // 
            returnDTP.Location = new Point(252, 135);
            returnDTP.Name = "returnDTP";
            returnDTP.Size = new Size(175, 23);
            returnDTP.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(252, 95);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 17;
            label8.Text = "Return Date";
            // 
            // isbnTxt
            // 
            isbnTxt.Location = new Point(92, 57);
            isbnTxt.Name = "isbnTxt";
            isbnTxt.Size = new Size(145, 23);
            isbnTxt.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 60);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 15;
            label7.Text = "ISBN";
            // 
            // issueDTP
            // 
            issueDTP.Location = new Point(252, 57);
            issueDTP.Name = "issueDTP";
            issueDTP.Size = new Size(175, 23);
            issueDTP.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 17);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 13;
            label6.Text = "Issue Date";
            // 
            // dateTxt
            // 
            dateTxt.Location = new Point(92, 187);
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(145, 23);
            dateTxt.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 187);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 11;
            label5.Text = "Publish Date";
            // 
            // catTxt
            // 
            catTxt.Location = new Point(92, 140);
            catTxt.Name = "catTxt";
            catTxt.Size = new Size(145, 23);
            catTxt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 143);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Category";
            // 
            // idTxt
            // 
            idTxt.Location = new Point(92, 17);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(145, 23);
            idTxt.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 17);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "User ID";
            // 
            // booknameTxt
            // 
            booknameTxt.Location = new Point(92, 95);
            booknameTxt.Name = "booknameTxt";
            booknameTxt.Size = new Size(145, 23);
            booknameTxt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 95);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // reissueBtn
            // 
            reissueBtn.BackColor = Color.FromArgb(46, 204, 113);
            reissueBtn.FlatAppearance.BorderSize = 0;
            reissueBtn.FlatStyle = FlatStyle.Flat;
            reissueBtn.ForeColor = Color.Cornsilk;
            reissueBtn.Location = new Point(6, 230);
            reissueBtn.Name = "reissueBtn";
            reissueBtn.Size = new Size(424, 33);
            reissueBtn.TabIndex = 4;
            reissueBtn.Text = "Re Issue Book";
            reissueBtn.UseVisualStyleBackColor = false;
            reissueBtn.Click += reissueBtn_Click;
            // 
            // isbnsearchBtn
            // 
            isbnsearchBtn.BackColor = Color.FromArgb(46, 204, 113);
            isbnsearchBtn.FlatAppearance.BorderSize = 0;
            isbnsearchBtn.FlatStyle = FlatStyle.Flat;
            isbnsearchBtn.ForeColor = Color.Cornsilk;
            isbnsearchBtn.Location = new Point(312, 6);
            isbnsearchBtn.Name = "isbnsearchBtn";
            isbnsearchBtn.Size = new Size(127, 23);
            isbnsearchBtn.TabIndex = 21;
            isbnsearchBtn.Text = "Search";
            isbnsearchBtn.UseVisualStyleBackColor = false;
            isbnsearchBtn.Click += isbnsearchBtn_Click;
            // 
            // isbnsearchTxt
            // 
            isbnsearchTxt.Location = new Point(98, 6);
            isbnsearchTxt.Name = "isbnsearchTxt";
            isbnsearchTxt.Size = new Size(208, 23);
            isbnsearchTxt.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 20;
            label1.Text = "ISBN";
            // 
            // ReissueBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(reissuePanel);
            Controls.Add(isbnsearchBtn);
            Controls.Add(isbnsearchTxt);
            Controls.Add(label1);
            Name = "ReissueBook";
            Size = new Size(445, 360);
            Load += ReissueBook_Load;
            reissuePanel.ResumeLayout(false);
            reissuePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel reissuePanel;
        private Button cancelBtn;
        private DateTimePicker returnDTP;
        private Label label8;
        private TextBox isbnTxt;
        private Label label7;
        private DateTimePicker issueDTP;
        private Label label6;
        private TextBox dateTxt;
        private Label label5;
        private TextBox catTxt;
        private Label label4;
        private TextBox idTxt;
        private Label label3;
        private TextBox booknameTxt;
        private Label label2;
        private Button reissueBtn;
        private Button isbnsearchBtn;
        private TextBox isbnsearchTxt;
        private Label label1;
    }
}
