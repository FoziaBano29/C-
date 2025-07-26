namespace CafeManagemntSystem
{
    partial class ItemsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            button2 = new Button();
            label8 = new Label();
            label6 = new Label();
            itemprice = new TextBox();
            label7 = new Label();
            label4 = new Label();
            itemname = new TextBox();
            label5 = new Label();
            label3 = new Label();
            button1 = new Button();
            itemnumber = new TextBox();
            itemlistGV = new DataGridView();
            CB = new ComboBox();
            order = new Label();
            Exit = new Label();
            label1 = new Label();
            logout = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemlistGV).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.IndianRed;
            button3.Location = new Point(16, 118);
            button3.Name = "button3";
            button3.Size = new Size(94, 35);
            button3.TabIndex = 35;
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
            button4.Location = new Point(14, 62);
            button4.Name = "button4";
            button4.Size = new Size(94, 35);
            button4.TabIndex = 34;
            button4.Text = "Order";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(itemprice);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(itemname);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(itemnumber);
            panel1.Controls.Add(itemlistGV);
            panel1.Controls.Add(CB);
            panel1.Controls.Add(order);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(146, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 500);
            panel1.TabIndex = 33;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.IndianRed;
            button5.Location = new Point(95, 307);
            button5.Name = "button5";
            button5.Size = new Size(67, 39);
            button5.TabIndex = 27;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.IndianRed;
            button2.Location = new Point(167, 307);
            button2.Name = "button2";
            button2.Size = new Size(67, 39);
            button2.TabIndex = 26;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(453, 68);
            label8.Name = "label8";
            label8.Size = new Size(98, 24);
            label8.TabIndex = 25;
            label8.Text = "Items List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 237);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 24;
            label6.Text = "Item Price:";
            // 
            // itemprice
            // 
            itemprice.Location = new Point(131, 237);
            itemprice.Name = "itemprice";
            itemprice.Size = new Size(153, 23);
            itemprice.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(79, 231);
            label7.Name = "label7";
            label7.Size = new Size(0, 23);
            label7.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 139);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 21;
            label4.Text = "Item Name:";
            // 
            // itemname
            // 
            itemname.Location = new Point(131, 139);
            itemname.Name = "itemname";
            itemname.Size = new Size(153, 23);
            itemname.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 131);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 101);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 18;
            label3.Text = "Item Number:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(23, 307);
            button1.Name = "button1";
            button1.Size = new Size(67, 39);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // itemnumber
            // 
            itemnumber.Location = new Point(131, 101);
            itemnumber.Name = "itemnumber";
            itemnumber.Size = new Size(153, 23);
            itemnumber.TabIndex = 10;
            // 
            // itemlistGV
            // 
            itemlistGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            itemlistGV.BackgroundColor = Color.Gainsboro;
            itemlistGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemlistGV.Location = new Point(302, 101);
            itemlistGV.Name = "itemlistGV";
            itemlistGV.Size = new Size(405, 368);
            itemlistGV.TabIndex = 9;
            itemlistGV.CellContentClick += itemlistGV_CellContentClick;
            // 
            // CB
            // 
            CB.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB.FormattingEnabled = true;
            CB.Items.AddRange(new object[] { "Food", "Baverages" });
            CB.Location = new Point(51, 184);
            CB.Name = "CB";
            CB.Size = new Size(153, 27);
            CB.TabIndex = 8;
            CB.Text = "Category";
            // 
            // order
            // 
            order.AutoSize = true;
            order.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order.Location = new Point(243, 13);
            order.Name = "order";
            order.Size = new Size(178, 32);
            order.TabIndex = 7;
            order.Text = "Manage Item";
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
            logout.Location = new Point(7, 454);
            logout.Name = "logout";
            logout.Size = new Size(52, 19);
            logout.TabIndex = 32;
            logout.Text = "Logout";
            logout.Click += logout_Click;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(865, 500);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(logout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemsForm";
            Load += ItemsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemlistGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button4;
        private Panel panel1;
        private Button button5;
        private Button button2;
        private Label label8;
        private Label label6;
        private TextBox itemprice;
        private Label label7;
        private Label label4;
        private TextBox itemname;
        private Label label5;
        private Label label3;
        private Button button1;
        private TextBox itemnumber;
        private DataGridView itemlistGV;
        private ComboBox CB;
        private Label order;
        private Label Exit;
        private Label label1;
        private Label logout;
    }
}