namespace LMS_JadRammal
{
    partial class UpdateBook
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
            label6 = new Label();
            label2 = new Label();
            updatePanel = new Panel();
            qtyTxt = new TextBox();
            updatebookBtn = new Button();
            label3 = new Label();
            catTxt = new TextBox();
            nameTxt = new TextBox();
            label5 = new Label();
            isbnTxt = new TextBox();
            label4 = new Label();
            searchbookBtn = new Button();
            isbnsearchTxt = new TextBox();
            label1 = new Label();
            updatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // authorTxt
            // 
            authorTxt.Location = new Point(106, 245);
            authorTxt.Name = "authorTxt";
            authorTxt.Size = new Size(320, 23);
            authorTxt.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(5, 248);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 16;
            label7.Text = "Author";
            // 
            // dateTxt
            // 
            dateTxt.Location = new Point(106, 106);
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(320, 23);
            dateTxt.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(5, 203);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 13;
            label6.Text = "Quantity";
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
            // updatePanel
            // 
            updatePanel.Controls.Add(authorTxt);
            updatePanel.Controls.Add(label7);
            updatePanel.Controls.Add(dateTxt);
            updatePanel.Controls.Add(qtyTxt);
            updatePanel.Controls.Add(label6);
            updatePanel.Controls.Add(updatebookBtn);
            updatePanel.Controls.Add(label3);
            updatePanel.Controls.Add(label2);
            updatePanel.Controls.Add(catTxt);
            updatePanel.Controls.Add(nameTxt);
            updatePanel.Controls.Add(label5);
            updatePanel.Controls.Add(isbnTxt);
            updatePanel.Controls.Add(label4);
            updatePanel.Location = new Point(3, 43);
            updatePanel.Name = "updatePanel";
            updatePanel.Size = new Size(439, 314);
            updatePanel.TabIndex = 17;
            // 
            // qtyTxt
            // 
            qtyTxt.Location = new Point(106, 200);
            qtyTxt.Name = "qtyTxt";
            qtyTxt.Size = new Size(320, 23);
            qtyTxt.TabIndex = 14;
            // 
            // updatebookBtn
            // 
            updatebookBtn.BackColor = Color.FromArgb(46, 204, 113);
            updatebookBtn.FlatAppearance.BorderSize = 0;
            updatebookBtn.FlatStyle = FlatStyle.Flat;
            updatebookBtn.ForeColor = Color.White;
            updatebookBtn.Location = new Point(5, 285);
            updatebookBtn.Name = "updatebookBtn";
            updatebookBtn.Size = new Size(421, 26);
            updatebookBtn.TabIndex = 12;
            updatebookBtn.Text = "Update";
            updatebookBtn.UseVisualStyleBackColor = false;
            updatebookBtn.Click += updatebookBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 66);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 5;
            label3.Text = "ISBN";
            // 
            // catTxt
            // 
            catTxt.Location = new Point(106, 153);
            catTxt.Name = "catTxt";
            catTxt.Size = new Size(320, 23);
            catTxt.TabIndex = 10;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(106, 20);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(320, 23);
            nameTxt.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(5, 156);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 9;
            label5.Text = "Category";
            // 
            // isbnTxt
            // 
            isbnTxt.Location = new Point(106, 63);
            isbnTxt.Name = "isbnTxt";
            isbnTxt.Size = new Size(320, 23);
            isbnTxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 106);
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
            searchbookBtn.Location = new Point(349, 3);
            searchbookBtn.Name = "searchbookBtn";
            searchbookBtn.Size = new Size(93, 23);
            searchbookBtn.TabIndex = 16;
            searchbookBtn.Text = "Search";
            searchbookBtn.UseVisualStyleBackColor = false;
            searchbookBtn.Click += searchbookBtn_Click;
            // 
            // isbnsearchTxt
            // 
            isbnsearchTxt.Location = new Point(109, 4);
            isbnsearchTxt.Name = "isbnsearchTxt";
            isbnsearchTxt.Size = new Size(234, 23);
            isbnsearchTxt.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(37, 17);
            label1.TabIndex = 14;
            label1.Text = "ISBN";
            // 
            // UpdateBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(updatePanel);
            Controls.Add(searchbookBtn);
            Controls.Add(isbnsearchTxt);
            Controls.Add(label1);
            Name = "UpdateBook";
            Size = new Size(445, 360);
            Load += UpdateBook_Load;
            updatePanel.ResumeLayout(false);
            updatePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox authorTxt;
        private Label label7;
        private TextBox dateTxt;
        private Label label6;
        private Label label2;
        private Panel updatePanel;
        private TextBox qtyTxt;
        private Button updatebookBtn;
        private Label label3;
        private TextBox catTxt;
        private TextBox nameTxt;
        private Label label5;
        private TextBox isbnTxt;
        private Label label4;
        private Button searchbookBtn;
        private TextBox isbnsearchTxt;
        private Label label1;
    }
}
