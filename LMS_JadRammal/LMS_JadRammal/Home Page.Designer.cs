namespace LMS_JadRammal
{
    partial class Home_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            mainPanel = new Panel();
            deletebookBtn = new Button();
            updatebookBtn = new Button();
            viewbookBtn = new Button();
            addbookBtn = new Button();
            bookPanel = new Panel();
            deleteuserBtn = new Button();
            updateuserBtn = new Button();
            viewuserBtn = new Button();
            adduserBtn = new Button();
            pictureBox1 = new PictureBox();
            userBtn = new Button();
            bookBtn = new Button();
            issuebookBtn = new Button();
            receivebookBtn = new Button();
            payBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            userPanel = new Panel();
            bookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            userPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Location = new Point(270, 26);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(445, 360);
            mainPanel.TabIndex = 17;
            // 
            // deletebookBtn
            // 
            deletebookBtn.FlatAppearance.BorderColor = Color.White;
            deletebookBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deletebookBtn.ForeColor = Color.FromArgb(19, 15, 64);
            deletebookBtn.Image = (Image)resources.GetObject("deletebookBtn.Image");
            deletebookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deletebookBtn.Location = new Point(3, 126);
            deletebookBtn.Name = "deletebookBtn";
            deletebookBtn.Size = new Size(112, 35);
            deletebookBtn.TabIndex = 7;
            deletebookBtn.Text = "Delete Book";
            deletebookBtn.TextAlign = ContentAlignment.MiddleRight;
            deletebookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            deletebookBtn.UseVisualStyleBackColor = true;
            deletebookBtn.Click += deletebookBtn_Click;
            // 
            // updatebookBtn
            // 
            updatebookBtn.FlatAppearance.BorderColor = Color.White;
            updatebookBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            updatebookBtn.ForeColor = Color.FromArgb(19, 15, 64);
            updatebookBtn.Image = (Image)resources.GetObject("updatebookBtn.Image");
            updatebookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            updatebookBtn.Location = new Point(3, 85);
            updatebookBtn.Name = "updatebookBtn";
            updatebookBtn.Size = new Size(112, 35);
            updatebookBtn.TabIndex = 6;
            updatebookBtn.Text = "Update Book";
            updatebookBtn.TextAlign = ContentAlignment.MiddleRight;
            updatebookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            updatebookBtn.UseVisualStyleBackColor = true;
            updatebookBtn.Click += updatebookBtn_Click;
            // 
            // viewbookBtn
            // 
            viewbookBtn.FlatAppearance.BorderColor = Color.White;
            viewbookBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            viewbookBtn.ForeColor = Color.FromArgb(19, 15, 64);
            viewbookBtn.Image = (Image)resources.GetObject("viewbookBtn.Image");
            viewbookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            viewbookBtn.Location = new Point(3, 44);
            viewbookBtn.Name = "viewbookBtn";
            viewbookBtn.Size = new Size(112, 35);
            viewbookBtn.TabIndex = 5;
            viewbookBtn.Text = "View Book";
            viewbookBtn.TextAlign = ContentAlignment.MiddleRight;
            viewbookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            viewbookBtn.UseVisualStyleBackColor = true;
            viewbookBtn.Click += viewbookBtn_Click;
            // 
            // addbookBtn
            // 
            addbookBtn.FlatAppearance.BorderColor = Color.White;
            addbookBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addbookBtn.ForeColor = Color.FromArgb(19, 15, 64);
            addbookBtn.Image = (Image)resources.GetObject("addbookBtn.Image");
            addbookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addbookBtn.Location = new Point(3, 3);
            addbookBtn.Name = "addbookBtn";
            addbookBtn.Size = new Size(112, 35);
            addbookBtn.TabIndex = 4;
            addbookBtn.Text = "Add Book";
            addbookBtn.TextAlign = ContentAlignment.MiddleRight;
            addbookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addbookBtn.UseVisualStyleBackColor = true;
            addbookBtn.Click += addbookBtn_Click;
            // 
            // bookPanel
            // 
            bookPanel.Controls.Add(deletebookBtn);
            bookPanel.Controls.Add(updatebookBtn);
            bookPanel.Controls.Add(viewbookBtn);
            bookPanel.Controls.Add(addbookBtn);
            bookPanel.Location = new Point(134, 165);
            bookPanel.Name = "bookPanel";
            bookPanel.Size = new Size(118, 164);
            bookPanel.TabIndex = 16;
            // 
            // deleteuserBtn
            // 
            deleteuserBtn.FlatAppearance.BorderColor = Color.White;
            deleteuserBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteuserBtn.ForeColor = Color.FromArgb(19, 15, 64);
            deleteuserBtn.Image = (Image)resources.GetObject("deleteuserBtn.Image");
            deleteuserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteuserBtn.Location = new Point(3, 126);
            deleteuserBtn.Name = "deleteuserBtn";
            deleteuserBtn.Size = new Size(112, 35);
            deleteuserBtn.TabIndex = 7;
            deleteuserBtn.Text = "Delete User";
            deleteuserBtn.TextAlign = ContentAlignment.MiddleRight;
            deleteuserBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteuserBtn.UseVisualStyleBackColor = true;
            deleteuserBtn.Click += deleteuserBtn_Click;
            // 
            // updateuserBtn
            // 
            updateuserBtn.FlatAppearance.BorderColor = Color.White;
            updateuserBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            updateuserBtn.ForeColor = Color.FromArgb(19, 15, 64);
            updateuserBtn.Image = (Image)resources.GetObject("updateuserBtn.Image");
            updateuserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            updateuserBtn.Location = new Point(3, 85);
            updateuserBtn.Name = "updateuserBtn";
            updateuserBtn.Size = new Size(112, 35);
            updateuserBtn.TabIndex = 6;
            updateuserBtn.Text = "Update User";
            updateuserBtn.TextAlign = ContentAlignment.MiddleRight;
            updateuserBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            updateuserBtn.UseVisualStyleBackColor = true;
            updateuserBtn.Click += updateuserBtn_Click;
            // 
            // viewuserBtn
            // 
            viewuserBtn.FlatAppearance.BorderColor = Color.White;
            viewuserBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            viewuserBtn.ForeColor = Color.FromArgb(19, 15, 64);
            viewuserBtn.Image = (Image)resources.GetObject("viewuserBtn.Image");
            viewuserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            viewuserBtn.Location = new Point(3, 44);
            viewuserBtn.Name = "viewuserBtn";
            viewuserBtn.Size = new Size(112, 35);
            viewuserBtn.TabIndex = 5;
            viewuserBtn.Text = "View User";
            viewuserBtn.TextAlign = ContentAlignment.MiddleRight;
            viewuserBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            viewuserBtn.UseVisualStyleBackColor = true;
            viewuserBtn.Click += viewuserBtn_Click;
            // 
            // adduserBtn
            // 
            adduserBtn.FlatAppearance.BorderColor = Color.White;
            adduserBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            adduserBtn.ForeColor = Color.FromArgb(19, 15, 64);
            adduserBtn.Image = (Image)resources.GetObject("adduserBtn.Image");
            adduserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            adduserBtn.Location = new Point(3, 3);
            adduserBtn.Name = "adduserBtn";
            adduserBtn.Size = new Size(112, 35);
            adduserBtn.TabIndex = 4;
            adduserBtn.Text = "Add User";
            adduserBtn.TextAlign = ContentAlignment.MiddleRight;
            adduserBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            adduserBtn.UseVisualStyleBackColor = true;
            adduserBtn.Click += adduserBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(112, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // userBtn
            // 
            userBtn.FlatAppearance.BorderColor = Color.White;
            userBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userBtn.ForeColor = Color.FromArgb(19, 15, 64);
            userBtn.Image = (Image)resources.GetObject("userBtn.Image");
            userBtn.ImageAlign = ContentAlignment.MiddleLeft;
            userBtn.Location = new Point(3, 107);
            userBtn.Name = "userBtn";
            userBtn.Size = new Size(112, 35);
            userBtn.TabIndex = 3;
            userBtn.Text = "User";
            userBtn.TextAlign = ContentAlignment.MiddleRight;
            userBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            userBtn.UseVisualStyleBackColor = true;
            userBtn.Click += userBtn_Click;
            // 
            // bookBtn
            // 
            bookBtn.FlatAppearance.BorderColor = Color.White;
            bookBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bookBtn.ForeColor = Color.FromArgb(19, 15, 64);
            bookBtn.Image = (Image)resources.GetObject("bookBtn.Image");
            bookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            bookBtn.Location = new Point(3, 148);
            bookBtn.Name = "bookBtn";
            bookBtn.Size = new Size(112, 35);
            bookBtn.TabIndex = 2;
            bookBtn.Text = "Book";
            bookBtn.TextAlign = ContentAlignment.MiddleRight;
            bookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            bookBtn.UseVisualStyleBackColor = true;
            bookBtn.Click += bookBtn_Click;
            // 
            // issuebookBtn
            // 
            issuebookBtn.FlatAppearance.BorderColor = Color.White;
            issuebookBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            issuebookBtn.ForeColor = Color.FromArgb(19, 15, 64);
            issuebookBtn.Image = (Image)resources.GetObject("issuebookBtn.Image");
            issuebookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            issuebookBtn.Location = new Point(3, 189);
            issuebookBtn.Name = "issuebookBtn";
            issuebookBtn.Size = new Size(112, 35);
            issuebookBtn.TabIndex = 4;
            issuebookBtn.Text = "Issue Book";
            issuebookBtn.TextAlign = ContentAlignment.MiddleRight;
            issuebookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            issuebookBtn.UseVisualStyleBackColor = true;
            issuebookBtn.Click += issuebookBtn_Click;
            // 
            // receivebookBtn
            // 
            receivebookBtn.FlatAppearance.BorderColor = Color.White;
            receivebookBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            receivebookBtn.ForeColor = Color.FromArgb(19, 15, 64);
            receivebookBtn.Image = (Image)resources.GetObject("receivebookBtn.Image");
            receivebookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            receivebookBtn.Location = new Point(3, 230);
            receivebookBtn.Name = "receivebookBtn";
            receivebookBtn.Size = new Size(112, 35);
            receivebookBtn.TabIndex = 5;
            receivebookBtn.Text = "Receive Book";
            receivebookBtn.TextAlign = ContentAlignment.MiddleRight;
            receivebookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            receivebookBtn.UseVisualStyleBackColor = true;
            receivebookBtn.Click += receivebookBtn_Click;
            // 
            // payBtn
            // 
            payBtn.FlatAppearance.BorderColor = Color.White;
            payBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            payBtn.ForeColor = Color.FromArgb(19, 15, 64);
            payBtn.Image = (Image)resources.GetObject("payBtn.Image");
            payBtn.ImageAlign = ContentAlignment.MiddleLeft;
            payBtn.Location = new Point(3, 271);
            payBtn.Name = "payBtn";
            payBtn.Size = new Size(112, 35);
            payBtn.TabIndex = 7;
            payBtn.Text = "Pay Fine";
            payBtn.TextAlign = ContentAlignment.MiddleRight;
            payBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            payBtn.UseVisualStyleBackColor = true;
            payBtn.Click += payBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.BackColor = Color.FromArgb(241, 196, 15);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(userBtn);
            flowLayoutPanel1.Controls.Add(bookBtn);
            flowLayoutPanel1.Controls.Add(issuebookBtn);
            flowLayoutPanel1.Controls.Add(receivebookBtn);
            flowLayoutPanel1.Controls.Add(payBtn);
            flowLayoutPanel1.Location = new Point(11, 14);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(119, 372);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // userPanel
            // 
            userPanel.Controls.Add(deleteuserBtn);
            userPanel.Controls.Add(updateuserBtn);
            userPanel.Controls.Add(viewuserBtn);
            userPanel.Controls.Add(adduserBtn);
            userPanel.Location = new Point(136, 121);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(119, 164);
            userPanel.TabIndex = 14;
            // 
            // Home_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 425);
            Controls.Add(mainPanel);
            Controls.Add(bookPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(userPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home_Page";
            Text = "Home Page";
            Load += Home_Page_Load;
            bookPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            userPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel mainPanel;
        private Button deletebookBtn;
        private Button updatebookBtn;
        private Button viewbookBtn;
        private Button addbookBtn;
        private Panel bookPanel;
        private Button deleteuserBtn;
        private Button updateuserBtn;
        private Button viewuserBtn;
        private Button adduserBtn;
        private PictureBox pictureBox1;
        private Button userBtn;
        private Button bookBtn;
        private Button issuebookBtn;
        private Button receivebookBtn;
        private Button payBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel userPanel;
    }
}