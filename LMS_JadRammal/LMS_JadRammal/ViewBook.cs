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
    public partial class ViewBook : UserControl
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void searchbookBtn_Click(object sender, EventArgs e)
        {
            if (selectCombo.SelectedItem != null && SelectType.Text != "")
            {
                string X = selectCombo.SelectedItem.ToString();
                string Y = SelectType.Text.ToString();

                string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (X == "ISBN")
                {
                    string cmdText = "Select * From AddNewBook Where ISBN='" + Y + "'";
                    cmd.CommandText = cmdText;
                    SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                    DataSet Data = new DataSet();
                    Adapter.Fill(Data);
                    viewbookDG.DataSource = Data.Tables[0];
                }
                else if (X == "Book Name")
                {
                    string cmdText = "Select * From AddNewBook Where BookName='" + Y + "'";
                    cmd.CommandText = cmdText;
                    SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                    DataSet Data = new DataSet();
                    Adapter.Fill(Data);
                    viewbookDG.DataSource = Data.Tables[0];
                }
                else if (X == "Category")
                {
                    string cmdText = "Select * From AddNewBook Where Category='" + Y + "'";
                    cmd.CommandText = cmdText;
                    SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                    DataSet Data = new DataSet();
                    Adapter.Fill(Data);
                    viewbookDG.DataSource = Data.Tables[0];
                }
                else
                {
                    MessageBox.Show("No Item Found", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Select Properly", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
