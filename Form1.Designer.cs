namespace CafeManagemntSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            afcafe = new Label();
            Username = new Label();
            unametb = new TextBox();
            upasstb = new TextBox();
            password = new Label();
            pictureBox1 = new PictureBox();
            guest = new Label();
            Welcome = new Label();
            label1 = new Label();
            welcome2 = new Label();
            panel1 = new Panel();
            Exit = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // afcafe
            // 
            afcafe.AutoSize = true;
            afcafe.BackColor = Color.Transparent;
            afcafe.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            afcafe.ForeColor = Color.Black;
            afcafe.Location = new Point(35, 27);
            afcafe.Name = "afcafe";
            afcafe.Size = new Size(111, 31);
            afcafe.TabIndex = 1;
            afcafe.Text = "AF Cafe";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.ForeColor = SystemColors.ActiveCaptionText;
            Username.Location = new Point(3, 93);
            Username.Name = "Username";
            Username.Size = new Size(82, 19);
            Username.TabIndex = 2;
            Username.Text = "Username:";
            // 
            // unametb
            // 
            unametb.BackColor = Color.DarkGray;
            unametb.Location = new Point(91, 89);
            unametb.Name = "unametb";
            unametb.Size = new Size(149, 23);
            unametb.TabIndex = 3;
            // 
            // upasstb
            // 
            upasstb.BackColor = Color.DarkGray;
            upasstb.Location = new Point(91, 146);
            upasstb.Name = "upasstb";
            upasstb.Size = new Size(149, 23);
            upasstb.TabIndex = 5;
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = Color.Transparent;
            password.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.ForeColor = Color.Black;
            password.Location = new Point(3, 150);
            password.Name = "password";
            password.Size = new Size(77, 19);
            password.TabIndex = 4;
            password.Text = "Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(152, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 61);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // guest
            // 
            guest.AutoSize = true;
            guest.BackColor = Color.Transparent;
            guest.Font = new Font("Times New Roman", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            guest.ForeColor = Color.Black;
            guest.Location = new Point(105, 254);
            guest.Name = "guest";
            guest.Size = new Size(44, 19);
            guest.TabIndex = 8;
            guest.Text = "Guest";
            guest.Click += guest_Click;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Welcome.Location = new Point(21, 50);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(258, 23);
            Welcome.TabIndex = 0;
            Welcome.Text = "Let's go on an extraordinary ";
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
            // welcome2
            // 
            welcome2.AutoSize = true;
            welcome2.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome2.Location = new Point(99, 86);
            welcome2.Name = "welcome2";
            welcome2.Size = new Size(227, 23);
            welcome2.TabIndex = 2;
            welcome2.Text = "journey of your tastebuds";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(welcome2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Welcome);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(259, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 323);
            panel1.TabIndex = 0;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.Firebrick;
            Exit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(322, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(28, 19);
            Exit.TabIndex = 6;
            Exit.Text = " X ";
            Exit.Click += Exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(113, 293);
            label4.Name = "label4";
            label4.Size = new Size(58, 14);
            label4.TabIndex = 5;
            label4.Text = "Project by:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 285);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 4;
            label3.Text = "Arooba Shuja, Fozia Bano";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 300);
            label2.Name = "label2";
            label2.Size = new Size(153, 14);
            label2.TabIndex = 3;
            label2.Text = "FA21-BCS-005, FA21-BCS-010";
            // 
            // Login
            // 
            Login.BackColor = Color.Silver;
            Login.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Location = new Point(74, 207);
            Login.Name = "Login";
            Login.Size = new Size(114, 35);
            Login.TabIndex = 10;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(613, 323);
            Controls.Add(Login);
            Controls.Add(guest);
            Controls.Add(password);
            Controls.Add(pictureBox1);
            Controls.Add(upasstb);
            Controls.Add(unametb);
            Controls.Add(Username);
            Controls.Add(afcafe);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AFCafe";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label afcafe;
        private Label Username;
        private TextBox unametb;
        private TextBox upasstb;
        private Label password;
        private PictureBox pictureBox1;
        private Label guest;
        private Label Welcome;
        private Label label1;
        private Label welcome2;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label Exit;
        private Button Login;
    }
}
