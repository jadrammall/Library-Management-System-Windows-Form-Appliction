namespace LMS_JadRammal
{
    partial class Fine
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
            clearfineBtn = new Button();
            useridtxt = new Label();
            usernametxt = new Label();
            label4 = new Label();
            label8 = new Label();
            label3 = new Label();
            userPanel = new Panel();
            label2 = new Label();
            fineDG = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            totalfinetxt = new Label();
            label7 = new Label();
            amountPanel = new Panel();
            usersearchBtn = new Button();
            label1 = new Label();
            idsearchTxt = new TextBox();
            finePanel = new Panel();
            allfinepanel = new Panel();
            userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fineDG).BeginInit();
            amountPanel.SuspendLayout();
            finePanel.SuspendLayout();
            allfinepanel.SuspendLayout();
            SuspendLayout();
            // 
            // clearfineBtn
            // 
            clearfineBtn.BackColor = Color.FromArgb(255, 128, 0);
            clearfineBtn.FlatStyle = FlatStyle.Flat;
            clearfineBtn.ForeColor = Color.White;
            clearfineBtn.Location = new Point(357, 278);
            clearfineBtn.Name = "clearfineBtn";
            clearfineBtn.Size = new Size(75, 33);
            clearfineBtn.TabIndex = 4;
            clearfineBtn.Text = "Clear Fine";
            clearfineBtn.UseVisualStyleBackColor = false;
            clearfineBtn.Click += clearfineBtn_Click;
            // 
            // useridtxt
            // 
            useridtxt.AutoSize = true;
            useridtxt.Location = new Point(110, 94);
            useridtxt.Name = "useridtxt";
            useridtxt.Size = new Size(0, 15);
            useridtxt.TabIndex = 10;
            // 
            // usernametxt
            // 
            usernametxt.AutoSize = true;
            usernametxt.Location = new Point(110, 55);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(0, 15);
            usernametxt.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 31);
            label4.Name = "label4";
            label4.Size = new Size(199, 15);
            label4.TabIndex = 8;
            label4.Text = "========================";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 16);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 8;
            label8.Text = "User Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 94);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 6;
            label3.Text = "User ID";
            // 
            // userPanel
            // 
            userPanel.BorderStyle = BorderStyle.FixedSingle;
            userPanel.Controls.Add(useridtxt);
            userPanel.Controls.Add(usernametxt);
            userPanel.Controls.Add(label4);
            userPanel.Controls.Add(label8);
            userPanel.Controls.Add(label3);
            userPanel.Controls.Add(label2);
            userPanel.Location = new Point(3, 3);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(205, 226);
            userPanel.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "User Name";
            // 
            // fineDG
            // 
            fineDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fineDG.Location = new Point(3, 49);
            fineDG.Name = "fineDG";
            fineDG.RowTemplate.Height = 25;
            fineDG.Size = new Size(210, 172);
            fineDG.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 31);
            label5.Name = "label5";
            label5.Size = new Size(215, 15);
            label5.TabIndex = 11;
            label5.Text = "==========================";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 16);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 12;
            label6.Text = "Fine Information";
            // 
            // totalfinetxt
            // 
            totalfinetxt.AutoSize = true;
            totalfinetxt.Location = new Point(392, 9);
            totalfinetxt.Name = "totalfinetxt";
            totalfinetxt.Size = new Size(28, 15);
            totalfinetxt.TabIndex = 1;
            totalfinetxt.Text = "0 $$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 9);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 0;
            label7.Text = "Total Amount ($$)";
            // 
            // amountPanel
            // 
            amountPanel.BorderStyle = BorderStyle.FixedSingle;
            amountPanel.Controls.Add(totalfinetxt);
            amountPanel.Controls.Add(label7);
            amountPanel.Location = new Point(3, 235);
            amountPanel.Name = "amountPanel";
            amountPanel.Size = new Size(429, 37);
            amountPanel.TabIndex = 10;
            // 
            // usersearchBtn
            // 
            usersearchBtn.Location = new Point(353, 12);
            usersearchBtn.Name = "usersearchBtn";
            usersearchBtn.Size = new Size(82, 23);
            usersearchBtn.TabIndex = 6;
            usersearchBtn.Text = "Search";
            usersearchBtn.UseVisualStyleBackColor = true;
            usersearchBtn.Click += usersearchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 5;
            label1.Text = "Enter User ID";
            // 
            // idsearchTxt
            // 
            idsearchTxt.Location = new Point(124, 12);
            idsearchTxt.Name = "idsearchTxt";
            idsearchTxt.Size = new Size(223, 23);
            idsearchTxt.TabIndex = 4;
            // 
            // finePanel
            // 
            finePanel.BorderStyle = BorderStyle.FixedSingle;
            finePanel.Controls.Add(fineDG);
            finePanel.Controls.Add(label5);
            finePanel.Controls.Add(label6);
            finePanel.Location = new Point(214, 3);
            finePanel.Name = "finePanel";
            finePanel.Size = new Size(218, 226);
            finePanel.TabIndex = 9;
            // 
            // allfinepanel
            // 
            allfinepanel.Controls.Add(amountPanel);
            allfinepanel.Controls.Add(finePanel);
            allfinepanel.Controls.Add(userPanel);
            allfinepanel.Controls.Add(clearfineBtn);
            allfinepanel.Location = new Point(3, 41);
            allfinepanel.Name = "allfinepanel";
            allfinepanel.Size = new Size(437, 316);
            allfinepanel.TabIndex = 7;
            // 
            // Fine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(usersearchBtn);
            Controls.Add(label1);
            Controls.Add(idsearchTxt);
            Controls.Add(allfinepanel);
            Name = "Fine";
            Size = new Size(445, 360);
            Load += Fine_Load;
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fineDG).EndInit();
            amountPanel.ResumeLayout(false);
            amountPanel.PerformLayout();
            finePanel.ResumeLayout(false);
            finePanel.PerformLayout();
            allfinepanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clearfineBtn;
        private Label useridtxt;
        private Label usernametxt;
        private Label label4;
        private Label label8;
        private Label label3;
        private Panel userPanel;
        private Label label2;
        private DataGridView fineDG;
        private Label label5;
        private Label label6;
        private Label totalfinetxt;
        private Label label7;
        private Panel amountPanel;
        private Button usersearchBtn;
        private Label label1;
        private TextBox idsearchTxt;
        private Panel finePanel;
        private Panel allfinepanel;
    }
}
