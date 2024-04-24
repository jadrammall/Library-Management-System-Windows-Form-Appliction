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
    public partial class DeleteBook : UserControl
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void DeleteBook_Load(object sender, EventArgs e)
        {
            deletePanel.Visible = false;
        }

        private void searchbookBtn_Click(object sender, EventArgs e)
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
                    deletePanel.Visible = true;
                    nameTxt.Text = Data.Tables[0].Rows[0][0].ToString();
                    isbnTxt.Text = Data.Tables[0].Rows[0][1].ToString();
                    dateTxt.Text = Data.Tables[0].Rows[0][2].ToString();
                    catTxt.Text = Data.Tables[0].Rows[0][3].ToString();
                    qtyTxt.Text = Data.Tables[0].Rows[0][4].ToString();
                    authorTxt.Text = Data.Tables[0].Rows[0][5].ToString();

                    nameTxt.Enabled = false;
                    isbnTxt.Enabled = false;
                    dateTxt.Enabled = false;
                    catTxt.Enabled = false;
                    qtyTxt.Enabled = false;
                    authorTxt.Enabled = false;
                }
                else
                {
                    deletePanel.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter ISBN", "Enter ISBN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deletebookBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            string cmdText = "Delete From AddNewBook Where ISBN='" + isbnsearchTxt.Text + "'";
            cmd.CommandText = cmdText;
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            MessageBox.Show("Delete Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            deletePanel.Visible = false;
        }

    }
}
