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

namespace LMS_JadRammal
{
    public partial class Add_User : UserControl
    {
        public Add_User()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (Uname.Text != "" && UID.Text != "" && UContact.Text != "" && UEmail.Text != "")
            {
                String Name = Uname.Text;
                String ID = UID.Text;
                String Contact = UContact.Text;
                String Email = UEmail.Text;

                string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                string cmdText = "Select * From AddUser Where UserID='" + UID.Text + "'";
                cmd.CommandText = cmdText;
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count < 1)
                {
                    conn.Open();
                    cmd.CommandText = "Insert Into AddUser (UserName,UserID,UserContact,UserEmail) Values ('" + Name + "','" + ID + "','" + Contact + "','" + Email + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Uname.Clear();
                    UID.Clear();
                    UContact.Clear();
                    UEmail.Clear();
                }
                else
                {
                    MessageBox.Show("User ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill Complete Information or Data Type Issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
