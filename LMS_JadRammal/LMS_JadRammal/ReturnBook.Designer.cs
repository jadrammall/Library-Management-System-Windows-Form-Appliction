namespace LMS_JadRammal
{
    partial class ReturnBook
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
            returnBtn = new Button();
            resultsDG = new DataGridView();
            usersearchBtn = new Button();
            idsearchTxt = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)resultsDG).BeginInit();
            SuspendLayout();
            // 
            // returnBtn
            // 
            returnBtn.Location = new Point(315, 317);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(127, 35);
            returnBtn.TabIndex = 9;
            returnBtn.Text = "Return";
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // resultsDG
            // 
            resultsDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDG.Location = new Point(3, 47);
            resultsDG.Name = "resultsDG";
            resultsDG.RowTemplate.Height = 25;
            resultsDG.Size = new Size(439, 264);
            resultsDG.TabIndex = 8;
            resultsDG.CellClick += resultsDG_CellClick;
            // 
            // usersearchBtn
            // 
            usersearchBtn.Location = new Point(315, 9);
            usersearchBtn.Name = "usersearchBtn";
            usersearchBtn.Size = new Size(127, 23);
            usersearchBtn.TabIndex = 7;
            usersearchBtn.Text = "Search";
            usersearchBtn.UseVisualStyleBackColor = true;
            usersearchBtn.Click += usersearchBtn_Click;
            // 
            // idsearchTxt
            // 
            idsearchTxt.Location = new Point(80, 9);
            idsearchTxt.Name = "idsearchTxt";
            idsearchTxt.Size = new Size(213, 23);
            idsearchTxt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "User ID";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(returnBtn);
            Controls.Add(resultsDG);
            Controls.Add(usersearchBtn);
            Controls.Add(idsearchTxt);
            Controls.Add(label1);
            Name = "ReturnBook";
            Size = new Size(445, 360);
            ((System.ComponentModel.ISupportInitialize)resultsDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBtn;
        private DataGridView resultsDG;
        private Button usersearchBtn;
        private TextBox idsearchTxt;
        private Label label1;
    }
}
