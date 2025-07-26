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
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
            printDocument1.PrintPage += printDocument1_PrintPage;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;");

        void Populate()
        {
            Con.Open();
            string query = "SELECT * FROM Orderstbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            Orderlistgv.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Orderlistgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = Orderlistgv.Rows[e.RowIndex];

                string orderDetails = $"OrderNum: {selectedRow.Cells[0].Value}\n" +
                                      $"User: {selectedRow.Cells[1].Value}\n" +
                                      $"OrderAmt: {selectedRow.Cells[2].Value}\n" +
                                      $"OrderDate: {selectedRow.Cells[3].Value}";

                printDocument1.DefaultPageSettings.Landscape = false;
                printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(40, 40, 40, 40);
                printDocument1.PrintPage += (s, ev) =>
                {
                    ev.Graphics.DrawString(orderDetails, new Font("Arial", 12), Brushes.Black, new PointF(20, 250));
                };
                printPreviewDialog1.Document = printDocument1;
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("*********Order Summary*********", new Font("Century", 20, FontStyle.Bold), Brushes.Red, new Point(120,50));
            e.Graphics.DrawString("***********AF Cafe***********", new Font("Century", 20, FontStyle.Bold), Brushes.Red, new Point(150));
            e.Graphics.DrawString("*********Order Summary*********", new Font("Century", 20, FontStyle.Bold), Brushes.Red, new Point(120, 350));

        }
    }
}
