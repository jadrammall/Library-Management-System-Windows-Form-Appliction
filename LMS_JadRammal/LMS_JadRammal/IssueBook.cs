using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS_JadRammal
{
    public partial class IssueBook : UserControl
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void usersearchBtn_Click(object sender, EventArgs e)
        {
            if (idsearchTxt.Text != "")
            {
                string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                string cmdText1 = "Select * From AddUser Where UserID='" + idsearchTxt.Text + "'";
                cmd.CommandText = cmdText1;
                SqlDataAdapter Adapter1 = new SqlDataAdapter(cmd);
                DataSet Data1 = new DataSet();
                Adapter1.Fill(Data1);

                string cmdText2 = "Select Count(*) From IssueBook Where UserID='" + idsearchTxt.Text + "' and IsReturned='" + 0 + "'";
                cmd.CommandText = cmdText2;
                SqlDataAdapter Adapter2 = new SqlDataAdapter(cmd);
                DataSet Data2 = new DataSet();
                Adapter2.Fill(Data2);

                string cmdText3 = "Select Count(*) From IssueBook Where UserID='" + idsearchTxt.Text + "'";
                cmd.CommandText = cmdText3;
                SqlDataAdapter Adapter3 = new SqlDataAdapter(cmd);
                DataSet Data3 = new DataSet();
                Adapter3.Fill(Data3);

                string cmdText4 = "Select Sum(Fine) From IssueBook Where UserID='" + idsearchTxt.Text + "'";
                cmd.CommandText = cmdText4;
                SqlDataAdapter Adapter4 = new SqlDataAdapter(cmd);
                DataSet Data4 = new DataSet();
                Adapter4.Fill(Data4);

                if (Data1.Tables[0].Rows.Count >= 1)
                {
                    panel2.Visible = true;
                    panel3.Visible = true;
                    usernameTxt.Text = Data1.Tables[0].Rows[0][0].ToString();
                    idTxt.Text = Data1.Tables[0].Rows[0][1].ToString();
                    contactTxt.Text = Data1.Tables[0].Rows[0][2].ToString();
                    emailTxt.Text = Data1.Tables[0].Rows[0][3].ToString();

                    usernameTxt.Enabled = false;
                    idTxt.Enabled = false;
                    contactTxt.Enabled = false;
                    emailTxt.Enabled = false;
                    nbIssuedBooks.Text = Data2.Tables[0].Rows[0][0].ToString();

                    int N1 = (int)Data2.Tables[0].Rows[0][0];
                    int N2 = (int)Data3.Tables[0].Rows[0][0];
                    nbReturnedBooks.Text = (N2 - N1).ToString();

                    string Fine = Data4.Tables[0].Rows[0][0].ToString();
                    nbFineAmount.Text = Fine;
                }
                else
                {
                    panel2.Visible = false;
                    panel3.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter User ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void AddUserControl(UserControl UserControl)
        {
            UserControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(UserControl);
            UserControl.BringToFront();
        }

        private void issueBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            string cmdText = "Select Count(*) From IssueBook Where UserID='" + idsearchTxt.Text + "' and IsReturned='" + 0 + "'";
            cmd.CommandText = cmdText;
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            if ((int)Data.Tables[0].Rows[0][0] >= 3)
            {
                MessageBox.Show("Maximum Books Are Already Issued and Limit Reached", "Maximum Book Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GrantBook GBook = new GrantBook();
                GBook.UserID = idsearchTxt.Text;
                AddUserControl(GBook);
            }
        }

        private void reissueBtn_Click(object sender, EventArgs e)
        {
            string size = nbIssuedBooks.Text;
            if (size != "0")
            {
                ReissueBook RBook = new ReissueBook();
                RBook.UserID = idsearchTxt.Text;
                AddUserControl(RBook);
            }
            else
            {
                MessageBox.Show("No Book Issued Yet", "Issue Book Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
