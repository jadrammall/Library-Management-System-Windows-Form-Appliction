namespace LMS_JadRammal
{
    partial class DeleteBook
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
            authorTxt = new TextBox();
            label7 = new Label();
            dateTxt = new TextBox();
            qtyTxt = new TextBox();
            label6 = new Label();
            deletebookBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            catTxt = new TextBox();
            nameTxt = new TextBox();
            label5 = new Label();
            isbnTxt = new TextBox();
            label4 = new Label();
            searchbookBtn = new Button();
            isbnsearchTxt = new TextBox();
            label1 = new Label();
            deletePanel = new Panel();
            deletePanel.SuspendLayout();
            SuspendLayout();
            // 
            // authorTxt
            // 
            authorTxt.Location = new Point(102, 260);
            authorTxt.Name = "authorTxt";
            authorTxt.Size = new Size(336, 23);
            authorTxt.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 263);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 16;
            label7.Text = "Author";
            // 
            // dateTxt
            // 
            dateTxt.Location = new Point(99, 124);
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(336, 23);
            dateTxt.TabIndex = 15;
            // 
            // qtyTxt
            // 
            qtyTxt.Location = new Point(102, 215);
            qtyTxt.Name = "qtyTxt";
            qtyTxt.Size = new Size(336, 23);
            qtyTxt.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(8, 218);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 13;
            label6.Text = "Quantity";
            // 
            // deletebookBtn
            // 
            deletebookBtn.BackColor = Color.Red;
            deletebookBtn.FlatAppearance.BorderSize = 0;
            deletebookBtn.FlatStyle = FlatStyle.Flat;
            deletebookBtn.ForeColor = Color.White;
            deletebookBtn.Location = new Point(10, 289);
            deletebookBtn.Name = "deletebookBtn";
            deletebookBtn.Size = new Size(425, 25);
            deletebookBtn.TabIndex = 12;
            deletebookBtn.Text = "Delete";
            deletebookBtn.UseVisualStyleBackColor = false;
            deletebookBtn.Click += deletebookBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 78);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 5;
            label3.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 35);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // catTxt
            // 
            catTxt.Location = new Point(99, 167);
            catTxt.Name = "catTxt";
            catTxt.Size = new Size(336, 23);
            catTxt.TabIndex = 10;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(99, 32);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(336, 23);
            nameTxt.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(5, 170);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 9;
            label5.Text = "Category";
            // 
            // isbnTxt
            // 
            isbnTxt.Location = new Point(99, 75);
            isbnTxt.Name = "isbnTxt";
            isbnTxt.Size = new Size(336, 23);
            isbnTxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 124);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 7;
            label4.Text = "Publish Date";
            // 
            // searchbookBtn
            // 
            searchbookBtn.BackColor = Color.FromArgb(46, 204, 113);
            searchbookBtn.FlatAppearance.BorderSize = 0;
            searchbookBtn.FlatStyle = FlatStyle.Flat;
            searchbookBtn.ForeColor = Color.White;
            searchbookBtn.Location = new Point(331, 11);
            searchbookBtn.Name = "searchbookBtn";
            searchbookBtn.Size = new Size(109, 23);
            searchbookBtn.TabIndex = 20;
            searchbookBtn.Text = "Search";
            searchbookBtn.UseVisualStyleBackColor = false;
            searchbookBtn.Click += searchbookBtn_Click;
            // 
            // isbnsearchTxt
            // 
            isbnsearchTxt.Location = new Point(101, 12);
            isbnsearchTxt.Name = "isbnsearchTxt";
            isbnsearchTxt.Size = new Size(224, 23);
            isbnsearchTxt.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 18;
            label1.Text = "Book ISBN";
            // 
            // deletePanel
            // 
            deletePanel.Controls.Add(authorTxt);
            deletePanel.Controls.Add(label7);
            deletePanel.Controls.Add(dateTxt);
            deletePanel.Controls.Add(qtyTxt);
            deletePanel.Controls.Add(label6);
            deletePanel.Controls.Add(deletebookBtn);
            deletePanel.Controls.Add(label3);
            deletePanel.Controls.Add(label2);
            deletePanel.Controls.Add(catTxt);
            deletePanel.Controls.Add(nameTxt);
            deletePanel.Controls.Add(label5);
            deletePanel.Controls.Add(isbnTxt);
            deletePanel.Controls.Add(label4);
            deletePanel.Location = new Point(2, 44);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(438, 317);
            deletePanel.TabIndex = 21;
            // 
            // DeleteBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchbookBtn);
            Controls.Add(isbnsearchTxt);
            Controls.Add(label1);
            Controls.Add(deletePanel);
            Name = "DeleteBook";
            Size = new Size(445, 360);
            Load += DeleteBook_Load;
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox authorTxt;
        private Label label7;
        private TextBox dateTxt;
        private TextBox qtyTxt;
        private Label label6;
        private Button deletebookBtn;
        private Label label3;
        private Label label2;
        private TextBox catTxt;
        private TextBox nameTxt;
        private Label label5;
        private TextBox isbnTxt;
        private Label label4;
        private Button searchbookBtn;
        private TextBox isbnsearchTxt;
        private Label label1;
        private Panel deletePanel;
    }
}
