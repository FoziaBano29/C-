namespace CafeManagemntSystem
{
    partial class UsersOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            date = new Label();
            button5 = new Button();
            UserOrderGV = new DataGridView();
            DGV2 = new DataGridView();
            label3 = new Label();
            button2 = new Button();
            orderdetails = new Label();
            Amounttotal = new Label();
            qty = new TextBox();
            button1 = new Button();
            sellername = new TextBox();
            ordernumber = new TextBox();
            CB = new ComboBox();
            order = new Label();
            Exit = new Label();
            label1 = new Label();
            logout = new Label();
            vieworderbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserOrderGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.IndianRed;
            button3.Location = new Point(9, 124);
            button3.Name = "button3";
            button3.Size = new Size(94, 35);
            button3.TabIndex = 23;
            button3.Text = "User";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.IndianRed;
            button4.Location = new Point(9, 69);
            button4.Name = "button4";
            button4.Size = new Size(94, 35);
            button4.TabIndex = 22;
            button4.Text = "Items";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(vieworderbtn);
            panel1.Controls.Add(date);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(UserOrderGV);
            panel1.Controls.Add(DGV2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(orderdetails);
            panel1.Controls.Add(Amounttotal);
            panel1.Controls.Add(qty);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(sellername);
            panel1.Controls.Add(ordernumber);
            panel1.Controls.Add(CB);
            panel1.Controls.Add(order);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(131, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 497);
            panel1.TabIndex = 21;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date.Location = new Point(497, 31);
            date.Name = "date";
            date.Size = new Size(47, 19);
            date.TabIndex = 30;
            date.Text = "Date:";
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.IndianRed;
            button5.Location = new Point(41, 112);
            button5.Name = "button5";
            button5.Size = new Size(75, 26);
            button5.TabIndex = 27;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // UserOrderGV
            // 
            UserOrderGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserOrderGV.BackgroundColor = Color.Gainsboro;
            UserOrderGV.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UserOrderGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UserOrderGV.GridColor = SystemColors.InactiveCaptionText;
            UserOrderGV.Location = new Point(170, 77);
            UserOrderGV.Name = "UserOrderGV";
            UserOrderGV.Size = new Size(534, 168);
            UserOrderGV.TabIndex = 26;
            UserOrderGV.CellContentClick += UserOrderGV_CellContentClick;
            // 
            // DGV2
            // 
            DGV2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV2.BackgroundColor = Color.Gainsboro;
            DGV2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV2.GridColor = SystemColors.InactiveCaptionText;
            DGV2.Location = new Point(170, 278);
            DGV2.Name = "DGV2";
            DGV2.Size = new Size(534, 158);
            DGV2.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(390, 51);
            label3.Name = "label3";
            label3.Size = new Size(72, 26);
            label3.TabIndex = 24;
            label3.Text = "Menu";
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.IndianRed;
            button2.Location = new Point(335, 446);
            button2.Name = "button2";
            button2.Size = new Size(130, 39);
            button2.TabIndex = 23;
            button2.Text = "Confirm Order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // orderdetails
            // 
            orderdetails.AutoSize = true;
            orderdetails.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderdetails.Location = new Point(381, 249);
            orderdetails.Name = "orderdetails";
            orderdetails.Size = new Size(133, 26);
            orderdetails.TabIndex = 22;
            orderdetails.Text = "Your Order";
            // 
            // Amounttotal
            // 
            Amounttotal.AutoSize = true;
            Amounttotal.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Amounttotal.Location = new Point(511, 455);
            Amounttotal.Name = "Amounttotal";
            Amounttotal.Size = new Size(72, 26);
            Amounttotal.TabIndex = 20;
            Amounttotal.Text = "Total:";
            // 
            // qty
            // 
            qty.Location = new Point(24, 217);
            qty.Name = "qty";
            qty.Size = new Size(65, 23);
            qty.TabIndex = 17;
            qty.Text = "Quantity";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(30, 250);
            button1.Name = "button1";
            button1.Size = new Size(99, 39);
            button1.TabIndex = 13;
            button1.Text = "Add to Cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sellername
            // 
            sellername.Location = new Point(24, 181);
            sellername.Name = "sellername";
            sellername.Size = new Size(121, 23);
            sellername.TabIndex = 11;
            sellername.Text = "Seller Name";
            // 
            // ordernumber
            // 
            ordernumber.Location = new Point(23, 147);
            ordernumber.Name = "ordernumber";
            ordernumber.Size = new Size(121, 23);
            ordernumber.TabIndex = 10;
            ordernumber.Text = "Order Number";
            // 
            // CB
            // 
            CB.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB.FormattingEnabled = true;
            CB.Items.AddRange(new object[] { "Food", "Baverages" });
            CB.Location = new Point(21, 77);
            CB.Name = "CB";
            CB.Size = new Size(121, 27);
            CB.TabIndex = 8;
            CB.Text = "Category";
            CB.SelectedIndexChanged += CB_SelectedIndexChanged;
            // 
            // order
            // 
            order.AutoSize = true;
            order.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order.Location = new Point(243, 13);
            order.Name = "order";
            order.Size = new Size(163, 32);
            order.TabIndex = 7;
            order.Text = "Place Order";
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.Firebrick;
            Exit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(685, 7);
            Exit.Name = "Exit";
            Exit.Size = new Size(28, 19);
            Exit.TabIndex = 6;
            Exit.Text = " X ";
            Exit.Click += Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 93);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 1;
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.BackColor = Color.Transparent;
            logout.Font = new Font("Times New Roman", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Black;
            logout.Location = new Point(15, 461);
            logout.Name = "logout";
            logout.Size = new Size(52, 19);
            logout.TabIndex = 20;
            logout.Text = "Logout";
            logout.Click += logout_Click;
            // 
            // vieworderbtn
            // 
            vieworderbtn.BackColor = Color.LightGray;
            vieworderbtn.FlatAppearance.BorderSize = 0;
            vieworderbtn.FlatStyle = FlatStyle.Flat;
            vieworderbtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vieworderbtn.ForeColor = Color.IndianRed;
            vieworderbtn.Location = new Point(187, 446);
            vieworderbtn.Name = "vieworderbtn";
            vieworderbtn.Size = new Size(130, 39);
            vieworderbtn.TabIndex = 31;
            vieworderbtn.Text = "View Order";
            vieworderbtn.UseVisualStyleBackColor = false;
            vieworderbtn.Click += vieworderbtn_Click;
            // 
            // UsersOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fbg;
            ClientSize = new Size(850, 497);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(logout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersOrderForm";
            Load += UsersOrderForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserOrderGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label3;
        private Button button2;
        private Label orderdetails;
        private Label Amounttotal;
        private TextBox qty;
        private Button button1;
        private TextBox sellername;
        private TextBox ordernumber;
        private ComboBox CB;
        private Label order;
        private Label Exit;
        private Label label1;
        private Label logout;
        private DataGridView DGV2;
        private DataGridView UserOrderGV;
        private Button button5;
        private Label date;
        private Button vieworderbtn;
    }
}