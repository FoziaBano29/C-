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

namespace CafeManagemntSystem
{
    public partial class UsersOrderForm : Form
    {
        public UsersOrderForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;");

        void Populate()
        {
            Con.Open();
            string query = "SELECT * FROM Itemtbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            UserOrderGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        void FilterByCategory()
        {
            Con.Open();
            string query = "SELECT * FROM Itemtbl WHERE ItemCat = '" + CB.SelectedItem.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            UserOrderGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm item = new ItemsForm();
            item.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm user = new UsersForm();
            user.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        int num = 0;
        int price, total;
        string cat;
        int flag = 0;
        int sum = 0;

        DataTable table = new DataTable();
        private void UsersOrderForm_Load(object sender, EventArgs e)
        {
            Populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            DGV2.DataSource = table;
            date.Text = DateTime.Now.ToString();
            sellername.Text = Form1.user;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qty.Text == "Quantity")
            {
                MessageBox.Show("What is quantity of item?");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select product  to be added");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(qty.Text);
                table.Rows.Add(num, Name, cat, price, total);
                flag = 0;
            }

            sum = sum + total;
            Amounttotal.Text = "" + sum;
        }

        private void UserOrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = UserOrderGV.Rows[e.RowIndex];
            Name = selectedRow.Cells[1].Value?.ToString();
            cat = selectedRow.Cells[2].Value?.ToString();

            //ordernumber.Text = selectedRow.Cells[0].Value?.ToString();
            //sellername.Text = selectedRow.Cells[1].Value?.ToString();
            //CB.SelectedItem = selectedRow.Cells[2].Value?.ToString();
            int.TryParse(selectedRow.Cells[3].Value?.ToString(), out price);

            flag = 1;
        }

        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "INSERT INTO Orderstbl (OrderNum, OrderDate, [User], OrderAmt) VALUES (@OrderNum, @OrderDate, @User, @OrderAmt)";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@OrderNum", ordernumber.Text);
            cmd.Parameters.AddWithValue("@OrderDate", date.Text);
            cmd.Parameters.AddWithValue("@User", sellername.Text);
            cmd.Parameters.AddWithValue("@OrderAmt", Amounttotal.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order placed Sucessfully");
            Con.Close();
        }

        private void vieworderbtn_Click(object sender, EventArgs e)
        {
            ViewOrder view = new ViewOrder();
            view.Show();
        }
    }
}
