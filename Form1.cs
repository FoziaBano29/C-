using System.Data;
using System.Data.SqlClient;

namespace CafeManagemntSystem
{
    public partial class Form1 : Form
    {
        public Form1()  
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;");

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string user;
        private void guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestItemForm guest = new GuestItemForm();
            guest.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            /**/

            user = unametb.Text;
            if (unametb.Text == "" || upasstb.Text == "")
            {
                MessageBox.Show("Enter Username or password");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM Usertbl WHERE Uname = '"+unametb.Text+"' AND Upassword = '"+upasstb.Text+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    UsersOrderForm itemForm = new UsersOrderForm();
                    itemForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                Con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
