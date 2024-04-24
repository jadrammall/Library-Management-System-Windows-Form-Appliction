using Microsoft.VisualBasic;
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
    public partial class UpdateUser : UserControl
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            updateuserPanel.Visible = false;
        }

        private void usersearchBtn_Click(object sender, EventArgs e)
        {
            if (idsearchTxt.Text != "")
            {
                string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                string cmdText = "Select * From AddUser Where UserID='" + idsearchTxt.Text + "'";
                cmd.CommandText = cmdText;
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count >= 1)
                {
                    updateuserPanel.Visible = true;
                    usernameTxt.Text = Data.Tables[0].Rows[0][0].ToString();
                    idTxt.Text = Data.Tables[0].Rows[0][1].ToString();
                    contactTxt.Text = Data.Tables[0].Rows[0][2].ToString();
                    emailTxt.Text = Data.Tables[0].Rows[0][3].ToString();

                    idTxt.Enabled = false;
                }
                else
                {
                    updateuserPanel.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter User ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateuserBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            string cmdText = "Update AddUser Set UserName = '" + usernameTxt.Text + "', UserContact = '" + contactTxt.Text + "', UserEmail = '" + emailTxt.Text + "' Where UserID = '" + idsearchTxt.Text + "'";
            cmd.CommandText = cmdText;
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            MessageBox.Show("Update Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            updateuserPanel.Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
