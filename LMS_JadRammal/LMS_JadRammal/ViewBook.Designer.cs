namespace LMS_JadRammal
{
    partial class ViewBook
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
            SelectType = new TextBox();
            BookView = new Panel();
            viewbookDG = new DataGridView();
            searchbookBtn = new Button();
            selectCombo = new ComboBox();
            BookView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewbookDG).BeginInit();
            SuspendLayout();
            // 
            // SelectType
            // 
            SelectType.Location = new Point(165, 3);
            SelectType.Name = "SelectType";
            SelectType.Size = new Size(191, 23);
            SelectType.TabIndex = 11;
            // 
            // BookView
            // 
            BookView.Controls.Add(viewbookDG);
            BookView.Location = new Point(3, 33);
            BookView.Name = "BookView";
            BookView.Size = new Size(439, 324);
            BookView.TabIndex = 10;
            // 
            // viewbookDG
            // 
            viewbookDG.AllowUserToAddRows = false;
            viewbookDG.AllowUserToDeleteRows = false;
            viewbookDG.BackgroundColor = Color.FromArgb(224, 224, 224);
            viewbookDG.BorderStyle = BorderStyle.None;
            viewbookDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewbookDG.Location = new Point(0, -1);
            viewbookDG.Name = "viewbookDG";
            viewbookDG.ReadOnly = true;
            viewbookDG.RowTemplate.Height = 25;
            viewbookDG.Size = new Size(439, 328);
            viewbookDG.TabIndex = 0;
            // 
            // searchbookBtn
            // 
            searchbookBtn.BackColor = Color.FromArgb(46, 204, 113);
            searchbookBtn.FlatAppearance.BorderSize = 0;
            searchbookBtn.FlatStyle = FlatStyle.Flat;
            searchbookBtn.ForeColor = Color.White;
            searchbookBtn.Location = new Point(362, 3);
            searchbookBtn.Name = "searchbookBtn";
            searchbookBtn.Size = new Size(77, 23);
            searchbookBtn.TabIndex = 9;
            searchbookBtn.Text = "Search";
            searchbookBtn.UseVisualStyleBackColor = false;
            searchbookBtn.Click += searchbookBtn_Click;
            // 
            // selectCombo
            // 
            selectCombo.FormattingEnabled = true;
            selectCombo.Items.AddRange(new object[] { "ISBN", "Book Name", "Category" });
            selectCombo.Location = new Point(3, 4);
            selectCombo.Name = "selectCombo";
            selectCombo.Size = new Size(156, 23);
            selectCombo.TabIndex = 8;
            selectCombo.Text = "Select From Dropdown";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectType);
            Controls.Add(BookView);
            Controls.Add(searchbookBtn);
            Controls.Add(selectCombo);
            Name = "ViewBook";
            Size = new Size(445, 360);
            BookView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewbookDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SelectType;
        private Panel BookView;
        private DataGridView viewbookDG;
        private Button searchbookBtn;
        private ComboBox selectCombo;
    }
}
