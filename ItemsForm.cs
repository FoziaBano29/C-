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
    public partial class ItemsForm : Form
    {
        public ItemsForm()
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
            itemlistGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm user = new UsersForm();
            user.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersOrderForm order = new UsersOrderForm();
            order.Show();
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
            if (itemname.Text == "" || itemnumber.Text == "" || itemprice.Text == "")
            {
                MessageBox.Show("Fill all fields");
            }
            else
            {
                Con.Open();
                string query = "INSERT INTO Itemtbl values('" + itemnumber.Text + "' , '" + itemname.Text + "','" + CB.SelectedItem.ToString() + "' , '" + itemprice.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item added successfully");
                Con.Close();
                Populate();
            }
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void itemlistGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = itemlistGV.Rows[e.RowIndex];
            itemname.Text = selectedRow.Cells[1].Value?.ToString();
            itemnumber.Text = selectedRow.Cells[0].Value?.ToString();
            CB.SelectedItem = selectedRow.Cells[2].Value?.ToString();
            itemprice.Text = selectedRow.Cells[3].Value?.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (itemnumber.Text == "")
            {
                MessageBox.Show("Select a user to be deleted");
            }
            else
            {
                Con.Open();
                string query = "DELETE FROM Itemtbl WHERE ItemNum = '" + itemnumber.Text + "'";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                MessageBox.Show("Item's Details Deleted Sucessfully");
                Con.Close();
                Populate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (itemnumber.Text == "" || itemname.Text == "" || itemprice.Text == "")
            {
                MessageBox.Show("Fill all Fields");
            }
            else
            {
                Con.Open();
                string query = "UPDATE Itemtbl SET ItemName='" + itemname.Text + "', ItemCat ='" + CB.SelectedItem.ToString() + "', ItemPrice ='" + itemprice.Text + "', ItemNum ='" + itemnumber.Text + "' WHERE ItemNum='" + itemnumber.Text + "'";
                SqlCommand cmd = new SqlCommand(@query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated sucessfully");
                Con.Close();
                Populate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
