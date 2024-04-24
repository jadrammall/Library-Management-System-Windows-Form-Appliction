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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            userPanel.Visible = false;
            bookPanel.Visible = false;

            string connString = "Data Source=DESKTOP-HI25GN3 ;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            string cmdText = "Select * From IssueBook Where IsReturned='" + 0 + "'";
            cmd.CommandText = cmdText;
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            for (int i = 0; i < Data.Tables[0].Rows.Count; i++)
            {
                String UserID = Data.Tables[0].Rows[i][0].ToString();
                String ISBN = Data.Tables[0].Rows[i][1].ToString();
                String IssueDate = Data.Tables[0].Rows[i][2].ToString();
                String ReturnDate = Data.Tables[0].Rows[i][3].ToString();

                DateTime TodayDate = DateTime.Now;
                String Today = TodayDate.ToString("dddd, MMMM dd, yyyy");

                int N1 = (DateTime.Parse(ReturnDate) - DateTime.Parse(IssueDate)).Days;
                int N2 = (DateTime.Parse(Today) - DateTime.Parse(IssueDate)).Days;
                int N3 = (DateTime.Parse(Today) - DateTime.Parse(ReturnDate)).Days;

                int Fine = N3 * 10;
                if (N2 > N1)
                {
                    cmd.CommandText = "Update IssueBook Set Fine='" + Fine + "' Where UserID='" + UserID + "' and ISBN='" + ISBN + "' and IsReturned='" + 0 + "'";

                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            userPanel.Visible = true;
            bookPanel.Visible = false;
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            userPanel.Visible = false;
            bookPanel.Visible = true;
        }
        private void AddUserControl(UserControl UserControl)
        {
            UserControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(UserControl);
            UserControl.BringToFront();
        }
        private void adduserBtn_Click(object sender, EventArgs e)
        {
            Add_User Add = new Add_User();
            AddUserControl(Add);
        }

        private void addbookBtn_Click(object sender, EventArgs e)
        {
            AddBook BookAdd = new AddBook();
            AddUserControl(BookAdd);
        }
        private void viewbookBtn_Click(object sender, EventArgs e)
        {
            ViewBook View = new ViewBook();
            AddUserControl(View);
        }

        private void updatebookBtn_Click(object sender, EventArgs e)
        {
            UpdateBook Update = new UpdateBook();
            AddUserControl(Update);
        }

        private void deletebookBtn_Click(object sender, EventArgs e)
        {
            DeleteBook Delete = new DeleteBook();
            AddUserControl(Delete);
        }

        private void viewuserBtn_Click(object sender, EventArgs e)
        {
            ViewUser View = new ViewUser();
            AddUserControl(View);
        }

        private void updateuserBtn_Click(object sender, EventArgs e)
        {
            UpdateUser Update = new UpdateUser();
            AddUserControl(Update);
        }

        private void deleteuserBtn_Click(object sender, EventArgs e)
        {
            DeleteUser Delete = new DeleteUser();
            AddUserControl(Delete);
        }

        private void issuebookBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            bookPanel.Visible = false;
            IssueBook Issue = new IssueBook();
            AddUserControl(Issue);
        }

        private void receivebookBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            bookPanel.Visible = false;
            ReturnBook Return = new ReturnBook();
            AddUserControl(Return);
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            bookPanel.Visible = false;
            Fine Fn = new Fine();
            AddUserControl(Fn);
        }
    }
}
