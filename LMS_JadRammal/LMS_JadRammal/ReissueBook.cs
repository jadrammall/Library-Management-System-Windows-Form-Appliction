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
    public partial class ReissueBook : UserControl
    {
        public ReissueBook()
        {
            InitializeComponent();
        }

        public string UserID { get; internal set; }

        private void ReissueBook_Load(object sender, EventArgs e)
        {
            idTxt.Text = UserID;
            reissuePanel.Visible = false;
        }

        private void isbnsearchBtn_Click(object sender, EventArgs e)
        {
            if (isbnsearchTxt.Text != "")
            {
                string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();

                string cmdText = "select * from IssueBook where UserID = '" + UserID + "' and ISBN='" + isbnsearchTxt.Text + "'and  IsReturned = '" + 0 + "'";
                cmd.CommandText = cmdText;
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);
                
                if (Data.Tables[0].Rows.Count > 0)
                {
                    string connString1 = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
                    SqlConnection conn1 = new SqlConnection(connString1);
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = conn1;
                    conn1.Open();

                    string cmdText1 = "Select * From AddNewBook Where ISBN='" + isbnsearchTxt.Text + "'";
                    cmd1.CommandText = cmdText1;
                    SqlDataAdapter Adapter1 = new SqlDataAdapter(cmd1);
                    DataSet Data1 = new DataSet();
                    Adapter1.Fill(Data1);
                    
                    if (Data1.Tables[0].Rows.Count >= 1)
                    {
                        reissuePanel.Visible = true;
                        booknameTxt.Text = Data1.Tables[0].Rows[0][0].ToString();
                        isbnTxt.Text = Data1.Tables[0].Rows[0][1].ToString();
                        dateTxt.Text = Data1.Tables[0].Rows[0][2].ToString();
                        catTxt.Text = Data1.Tables[0].Rows[0][3].ToString();

                        booknameTxt.Enabled = false;
                        idTxt.Enabled = false;
                        isbnTxt.Enabled = false;
                        catTxt.Enabled = false;
                        dateTxt.Enabled = false;
                        issueDTP.Enabled = false;
                    }
                    else
                    {
                        reissuePanel.Visible = false;
                    }
                    conn1.Close();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Book Against That ISBN Not Isueed Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void reissueBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            string cmdText = "Select * From IssueBook Where ISBN='" + isbnTxt.Text + "' and  UserID='" + idTxt.Text + "'";
            cmd.CommandText = cmdText;
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            conn.Open();
            string cmdText1 = "Update IssueBook Set ReturnDate ='" + returnDTP.Text + "' where ISBN='" + isbnTxt.Text + "' and  UserID='" + idTxt.Text + "'";
            cmd.CommandText = cmdText1;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Re-Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Parent.Controls.Remove(this);
            reissuePanel.Visible = true;
        }
    }
}
