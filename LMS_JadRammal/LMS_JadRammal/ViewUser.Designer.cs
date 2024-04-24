namespace LMS_JadRammal
{
    partial class ViewUser
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
            viewuserDG = new DataGridView();
            UserID = new Label();
            idtxtsearch = new TextBox();
            BookView = new Panel();
            usersearchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)viewuserDG).BeginInit();
            BookView.SuspendLayout();
            SuspendLayout();
            // 
            // viewuserDG
            // 
            viewuserDG.AllowUserToAddRows = false;
            viewuserDG.AllowUserToDeleteRows = false;
            viewuserDG.BackgroundColor = Color.FromArgb(224, 224, 224);
            viewuserDG.BorderStyle = BorderStyle.None;
            viewuserDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewuserDG.Location = new Point(3, 3);
            viewuserDG.Name = "viewuserDG";
            viewuserDG.ReadOnly = true;
            viewuserDG.RowTemplate.Height = 25;
            viewuserDG.Size = new Size(436, 315);
            viewuserDG.TabIndex = 0;
            // 
            // UserID
            // 
            UserID.AutoSize = true;
            UserID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserID.Location = new Point(6, 8);
            UserID.Name = "UserID";
            UserID.Size = new Size(52, 17);
            UserID.TabIndex = 12;
            UserID.Text = "User ID";
            // 
            // idtxtsearch
            // 
            idtxtsearch.Location = new Point(80, 7);
            idtxtsearch.Name = "idtxtsearch";
            idtxtsearch.Size = new Size(240, 23);
            idtxtsearch.TabIndex = 11;
            // 
            // BookView
            // 
            BookView.Controls.Add(viewuserDG);
            BookView.Location = new Point(3, 36);
            BookView.Name = "BookView";
            BookView.Size = new Size(439, 318);
            BookView.TabIndex = 10;
            // 
            // usersearchBtn
            // 
            usersearchBtn.BackColor = Color.FromArgb(46, 204, 113);
            usersearchBtn.FlatAppearance.BorderSize = 0;
            usersearchBtn.FlatStyle = FlatStyle.Flat;
            usersearchBtn.ForeColor = Color.White;
            usersearchBtn.Location = new Point(326, 6);
            usersearchBtn.Name = "usersearchBtn";
            usersearchBtn.Size = new Size(104, 23);
            usersearchBtn.TabIndex = 9;
            usersearchBtn.Text = "Search";
            usersearchBtn.UseVisualStyleBackColor = false;
            usersearchBtn.Click += usersearchBtn_Click;
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UserID);
            Controls.Add(idtxtsearch);
            Controls.Add(BookView);
            Controls.Add(usersearchBtn);
            Name = "ViewUser";
            Size = new Size(445, 360);
            ((System.ComponentModel.ISupportInitialize)viewuserDG).EndInit();
            BookView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView viewuserDG;
        private Label UserID;
        private TextBox idtxtsearch;
        private Panel BookView;
        private Button usersearchBtn;
    }
}
