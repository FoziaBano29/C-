namespace CafeManagemntSystem
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            button2 = new Button();
            label8 = new Label();
            label6 = new Label();
            upassword = new TextBox();
            label7 = new Label();
            label4 = new Label();
            uname = new TextBox();
            label5 = new Label();
            label3 = new Label();
            button1 = new Button();
            Unumber = new TextBox();
            UserListDGV = new DataGridView();
            order = new Label();
            Exit = new Label();
            label1 = new Label();
            logout = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserListDGV).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.IndianRed;
            button3.Location = new Point(12, 139);
            button3.Name = "button3";
            button3.Size = new Size(94, 35);
            button3.TabIndex = 27;
            button3.Text = "Items";
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
            button4.Location = new Point(13, 84);
            button4.Name = "button4";
            button4.Size = new Size(94, 35);
            button4.TabIndex = 26;
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
            panel1.Controls.Add(upassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(uname);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Unumber);
            panel1.Controls.Add(UserListDGV);
            panel1.Controls.Add(order);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(136, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 504);
            panel1.TabIndex = 25;
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
            label8.Text = "Users List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 229);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 24;
            label6.Text = "Password:";
            // 
            // upassword
            // 
            upassword.Location = new Point(127, 227);
            upassword.Name = "upassword";
            upassword.Size = new Size(153, 23);
            upassword.TabIndex = 23;
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
            label4.Location = new Point(5, 182);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 21;
            label4.Text = "User Name:";
            // 
            // uname
            // 
            uname.Location = new Point(127, 182);
            uname.Name = "uname";
            uname.Size = new Size(153, 23);
            uname.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(75, 174);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 144);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 18;
            label3.Text = "User Number:";
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
            // Unumber
            // 
            Unumber.Location = new Point(127, 144);
            Unumber.Name = "Unumber";
            Unumber.Size = new Size(153, 23);
            Unumber.TabIndex = 10;
            // 
            // UserListDGV
            // 
            UserListDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserListDGV.BackgroundColor = Color.Gainsboro;
            UserListDGV.Location = new Point(302, 101);
            UserListDGV.Name = "UserListDGV";
            UserListDGV.Size = new Size(405, 368);
            UserListDGV.TabIndex = 9;
            UserListDGV.CellContentClick += UserListDGV_CellContentClick;
            // 
            // order
            // 
            order.AutoSize = true;
            order.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order.Location = new Point(243, 13);
            order.Name = "order";
            order.Size = new Size(189, 32);
            order.TabIndex = 7;
            order.Text = "Manage Users";
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
            label1.Location = new Point(75, 136);
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
            logout.Location = new Point(10, 476);
            logout.Name = "logout";
            logout.Size = new Size(52, 19);
            logout.TabIndex = 24;
            logout.Text = "Logout";
            logout.Click += logout_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(855, 504);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(logout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersForm";
            Load += UsersForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserListDGV).EndInit();
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
        private TextBox upassword;
        private Label label7;
        private Label label4;
        private TextBox uname;
        private Label label5;
        private Label label3;
        private Button button1;
        private TextBox Unumber;
        private DataGridView UserListDGV;
        private Label order;
        private Label Exit;
        private Label label1;
        private Label logout;
    }
}