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
using static System.Net.Mime.MediaTypeNames;

namespace LMS_JadRammal
{
    public partial class ViewUser : UserControl
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        private void usersearchBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            if (idtxtsearch.Text != "")
            {
                string cmdText = "Select * From AddUser Where UserID='" + idtxtsearch.Text + "'";
                cmd.CommandText = cmdText;
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);
                viewuserDG.DataSource = Data.Tables[0];
            }
            else
            {
                MessageBox.Show("Please Enter ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
