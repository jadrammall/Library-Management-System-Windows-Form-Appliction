using System.Data;
using System.Data.SqlClient;
using System;
using System.Xml;

namespace LMS_JadRammal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            string cmdText = "Select * From Login Where Username='" + UsernameText.Text + "' and Password='" + PasswordText.Text + "' COLLATE Latin1_General_CS_AS";
            cmd.CommandText = cmdText;
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);
            if (Data.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Home_Page HP = new Home_Page();
                HP.Show();
            }
            else
            {
                MessageBox.Show("Username or Password Wrong", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordText_TextChanged_1(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = '*';
        }
    }
}