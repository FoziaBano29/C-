namespace CafeManagemntSystem
{
    partial class ViewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrder));
            Exit = new Label();
            panel1 = new Panel();
            button1 = new Button();
            Orderlistgv = new DataGridView();
            orderlistlb = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Orderlistgv).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.Firebrick;
            Exit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(416, 7);
            Exit.Name = "Exit";
            Exit.Size = new Size(28, 19);
            Exit.TabIndex = 7;
            Exit.Text = " X ";
            Exit.Click += Exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Orderlistgv);
            panel1.Controls.Add(orderlistlb);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 461);
            panel1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(163, 406);
            button1.Name = "button1";
            button1.Size = new Size(99, 39);
            button1.TabIndex = 29;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Orderlistgv
            // 
            Orderlistgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Orderlistgv.BackgroundColor = Color.Gainsboro;
            Orderlistgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Orderlistgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Orderlistgv.GridColor = SystemColors.InactiveCaptionText;
            Orderlistgv.Location = new Point(18, 54);
            Orderlistgv.Name = "Orderlistgv";
            Orderlistgv.Size = new Size(396, 336);
            Orderlistgv.TabIndex = 28;
            Orderlistgv.CellContentClick += Orderlistgv_CellContentClick;
            // 
            // orderlistlb
            // 
            orderlistlb.AutoSize = true;
            orderlistlb.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderlistlb.Location = new Point(134, 11);
            orderlistlb.Name = "orderlistlb";
            orderlistlb.Size = new Size(157, 26);
            orderlistlb.TabIndex = 27;
            orderlistlb.Text = "List of Orders";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ViewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(457, 527);
            Controls.Add(panel1);
            Controls.Add(Exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrder";
            Load += ViewOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Orderlistgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Exit;
        private Panel panel1;
        private DataGridView Orderlistgv;
        private Label orderlistlb;
        private Button button1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}