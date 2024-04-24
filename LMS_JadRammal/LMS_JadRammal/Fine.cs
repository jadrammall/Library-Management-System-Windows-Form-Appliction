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
    public partial class Fine : UserControl
    {
        public Fine()
        {
            InitializeComponent();
        }

        private void Fine_Load(object sender, EventArgs e)
        {
            allfinepanel.Visible = false;
        }

        private void usersearchBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            if (idsearchTxt.Text != "")
            {
                string cmdText = "Select IB.UserID ,AU.UserName,IB.ISBN,IB.IssueDate,IB.ReturnDate,IB.IsReturned,IB.Fine from IssueBook AS IB inner join AddUser AS AU on IB.UserID=AU.UserID and IB.UserID='" + idsearchTxt.Text + "' ";
                cmd.CommandText = cmdText;
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count > 0)
                {
                    allfinepanel.Visible = true;
                    usernametxt.Text = Data.Tables[0].Rows[0][1].ToString();
                    useridtxt.Text = Data.Tables[0].Rows[0][0].ToString();

                    string cmdText1 = "Select Sum(Fine) From IssueBook Where UserID='" + idsearchTxt.Text + "'";
                    cmd.CommandText = cmdText1;
                    SqlDataAdapter Adapter1 = new SqlDataAdapter(cmd);
                    DataSet Data1 = new DataSet();
                    Adapter1.Fill(Data1);

                    string Fine = Data1.Tables[0].Rows[0][0].ToString();
                    totalfinetxt.Text = Fine + " $$";

                    string connString1 = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
                    SqlConnection conn1 = new SqlConnection(connString1);
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = conn1;

                    string cmdText2 = "Select IB.Fine,IB.ISBN,AU.UserID,AB.BookName from IssueBook as IB Inner Join AddNewBook as AB on IB.ISBN=AB.ISBN Inner Join AddUser as AU on AU.UserID=IB.UserID and IB.UserID='" + idsearchTxt.Text + "' and IB.Fine>0;";
                    cmd1.CommandText = cmdText2;
                    SqlDataAdapter Adapter2 = new SqlDataAdapter(cmd1);
                    DataSet Data2 = new DataSet();
                    Adapter2.Fill(Data2);

                    if (Data2.Tables[0].Rows.Count > 0)
                    {
                        fineDG.DataSource = Data2.Tables[0];
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("No Record Found Against This User", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearfineBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            string cmdText = "Select * From IssueBook Where UserID='" + idsearchTxt.Text + "'";
            cmd.CommandText = cmdText;
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            conn.Open();

            for (int i = 0; i < Data.Tables[0].Rows.Count; i++)
            {
                String UserID = Data.Tables[0].Rows[i][0].ToString();
                String ISBN = Data.Tables[0].Rows[i][1].ToString();
                int Fine = (int)Data.Tables[0].Rows[i][5];

                if (Fine > 0)
                {
                    string cmdText4 = "Update IssueBook Set Fine='" + 0 + "' Where UserID='" + UserID + "' and ISBN='" + ISBN + "' and IsReturned='" + 1 + "' and Fine>'" + 0 + "'";
                    cmd.CommandText = cmdText4;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Fine Cleared Successfully", "Fine Clear", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }
    }
}
