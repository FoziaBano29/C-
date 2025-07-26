using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CafeManagemntSystem
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;");

        void Populate()
        {
            Con.Open();
            string query = "SELECT * FROM Usertbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            UserListDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            UsersOrderForm uorder = new UsersOrderForm();
            uorder.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemsForm item = new ItemsForm();
            item.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "INSERT INTO Usertbl values('" + uname.Text + "' , '" + Unumber.Text + "' , '" + upassword.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User created");
            Con.Close();
            Populate();

        }


        private void UsersForm_Load(object sender, EventArgs e)
        {
            Populate();
        }


        private void UserListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = UserListDGV.Rows[e.RowIndex];
            uname.Text = selectedRow.Cells[0].Value?.ToString();
            Unumber.Text = selectedRow.Cells[1].Value?.ToString();
            upassword.Text = selectedRow.Cells[2].Value?.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Unumber.Text == "")
            {
                MessageBox.Show("Select a user to be deleted");
            }
            else
            {
                Con.Open();
                string query = "DELETE FROM Usertbl WHERE Uphone = '" + Unumber.Text + "'";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                MessageBox.Show("User's Details Deleted Sucessfully");
                Con.Close();
                Populate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Unumber.Text == "" || uname.Text == "" || upassword.Text == "")
            {
                MessageBox.Show("Fill all Fields");
            }
            else 
            {
                Con.Open();
                string query = "UPDATE Usertbl SET Uname='" + uname.Text + "', Upassword='" + upassword.Text + "', Uphone='" + Unumber.Text + "' WHERE Uphone='" + Unumber.Text + "'";
                SqlCommand cmd = new SqlCommand(@query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated sucessfully");
                Con.Close();
                Populate();
            }
        }
    }
}
        


