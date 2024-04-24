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
    public partial class GrantBook : UserControl
    {
        public String UserID { get; set; }
        public GrantBook()
        {
            InitializeComponent();
        }

        private void GrantBook_Load(object sender, EventArgs e)
        {
            idTxt.Text = UserID;
            grantbookBtn.Enabled = false;
        }

        private void isbnsearchBtn_Click(object sender, EventArgs e)
        {
            if (isbnsearchTxt.Text != "")
            {
                string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                string cmdText = "Select * From AddNewBook Where ISBN='" + isbnsearchTxt.Text + "'";
                cmd.CommandText = cmdText;
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count >= 1)
                {
                    grantbookBtn.Visible = true;
                    booknameTxt.Text = Data.Tables[0].Rows[0][0].ToString();
                    isbnTxt.Text = Data.Tables[0].Rows[0][1].ToString();
                    dateTxt.Text = Data.Tables[0].Rows[0][2].ToString();
                    catTxt.Text = Data.Tables[0].Rows[0][3].ToString();

                    booknameTxt.Enabled = false;
                    idTxt.Enabled = false;
                    isbnTxt.Enabled = false;
                    catTxt.Enabled = false;
                    dateTxt.Enabled = false;
                    grantbookBtn.Enabled = true;
                }
                else
                {
                    grantbookPanel.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter ISBN", "Enter ISBN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void grantbookBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            string cmdText = "Select * From IssueBook Where ISBN='" + isbnTxt.Text + "' and  UserID='" + UserID + "' and IsReturned='" + 0 + "'";
            cmd.CommandText = cmdText;
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            int res;
            if (Data.Tables[0].Rows.Count < 1)
            {
                conn.Open();
                string cmdText1 = "Select Quantity from AddNewBook where ISBN = '" + isbnTxt.Text + "'";
                cmd.CommandText = cmdText1;
                cmd.ExecuteNonQuery();
                res = (int)cmd.ExecuteScalar();
                if (res == 0)
                {
                    MessageBox.Show("Book Quantity is Zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string cmdText2 = "Insert Into IssueBook (UserID,ISBN,IssueDate,ReturnDate,IsReturned,Fine) Values ('" + idTxt.Text + "','" + isbnTxt.Text + "','" + issueDTP.Text + "','" + returnDTP.Text + "','0','10')";
                    cmd.CommandText = cmdText2;
                    cmd.ExecuteNonQuery();
                    string cmdText3 = "update AddNewBook set Quantity = Quantity - 1 where ISBN = '" + isbnTxt.Text + "'";
                    cmd.CommandText = cmdText3;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Parent.Controls.Remove(this);
                grantbookPanel.Visible = true;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Book Issued Already", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
