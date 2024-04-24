using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS_JadRammal
{
    public partial class AddBook : UserControl
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void BookName_TextChanged(object sender, EventArgs e)
        {

        }
        private void BookCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        private void BookSave_Click(object sender, EventArgs e)
        {
            if (Quantity.Text == "0")
            {
                MessageBox.Show("Please enter book quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BookName.Text != "" && ISBN.Text != "" && PublishDate.Text != "" && Category.Text != "" && Quantity.Text != "" && Quantity.Text.All(Char.IsDigit))
            {
                String Name = BookName.Text;
                String BookISBN = ISBN.Text;
                String Date = PublishDate.Text;
                String Categ = Category.Text;
                Int64 Quan = Int64.Parse(Quantity.Text);
                String Author = Authortxt.Text;

                string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                string cmdText = "Select * From AddNewBook Where ISBN='" + ISBN.Text + "'";
                cmd.CommandText = cmdText;
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count < 1)
                {
                    conn.Open();
                    cmd.CommandText = "Insert Into AddNewBook (BookName,ISBN,PublishDate,Category,Quantity,AuthorName) Values ('" + Name + "','" + BookISBN + "','" + Date + "','" + Categ + "','" + Quan + "','" + Author + "') ";
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BookName.Clear();
                    ISBN.Clear();
                    Category.Clear();
                    Quantity.Clear();
                    Authortxt.Clear();

                }
                else
                {
                    MessageBox.Show("Primary Key Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill Complete Information or Data Type Issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
