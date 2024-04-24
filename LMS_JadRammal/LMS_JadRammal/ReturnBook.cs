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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace LMS_JadRammal
{
    public partial class ReturnBook : UserControl
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void usersearchBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            if (idsearchTxt.Text != "")
            {
                conn.Open();
                string cmdText = "Select * From IssueBook Where UserID='" + idsearchTxt.Text + "' and IsReturned='" + 0 + "'";
                cmd.CommandText = cmdText;
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count >= 1)
                {
                    resultsDG.DataSource = Data.Tables[0];
                }
                else
                {
                    resultsDG.Columns.Clear();
                    MessageBox.Show("No Data Found for User About Issueing Book ", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter User ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            returnBtn.Enabled = false;
        }

        string User;
        string Book;
        private void resultsDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            returnBtn.Enabled = true;
            if (resultsDG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                User = resultsDG.Rows[e.RowIndex].Cells[0].Value.ToString();
                Book = resultsDG.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            string cmdText1 = "Update IssueBook Set IsReturned='1' Where UserID='" + User + "' and ISBN='" + Book + "'";
            cmd.CommandText = cmdText1;
            cmd.ExecuteNonQuery();
            string cmdText2 = "Update AddNewBook set Quantity = Quantity + 1 Where ISBN = '" + Book + "'";
            cmd.CommandText = cmdText2;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Book Returned Successfully !!", "Book Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }
    }
}
