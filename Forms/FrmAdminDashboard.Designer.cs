namespace Forms
{
    partial class FrmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminDashboard));
            panel3 = new Panel();
            pictureBox11 = new PictureBox();
            btnAttendance = new Button();
            pictureBox1 = new PictureBox();
            btnExpense = new Button();
            pictureBox8 = new PictureBox();
            btnOverview = new Button();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            btnManu = new Button();
            btnLogOut = new Button();
            btnUser = new Button();
            btnSalesHistory = new Button();
            panel5 = new Panel();
            lblWlcName = new Label();
            label10 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            lblExpense = new Label();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            lblSale = new Label();
            label2 = new Label();
            panel7 = new Panel();
            pictureBox10 = new PictureBox();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox9 = new PictureBox();
            LblProfit = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(9, 18, 44);
            panel3.Controls.Add(pictureBox11);
            panel3.Controls.Add(btnAttendance);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnExpense);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(btnOverview);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(btnManu);
            panel3.Controls.Add(btnLogOut);
            panel3.Controls.Add(btnUser);
            panel3.Controls.Add(btnSalesHistory);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(2, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 555);
            panel3.TabIndex = 2;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(13, 308);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(36, 33);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 25;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Cursor = Cursors.Hand;
            btnAttendance.FlatStyle = FlatStyle.Popup;
            btnAttendance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(55, 308);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(124, 33);
            btnAttendance.TabIndex = 24;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.expense_8910710;
            pictureBox1.Location = new Point(13, 245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btnExpense
            // 
            btnExpense.Cursor = Cursors.Hand;
            btnExpense.FlatStyle = FlatStyle.Popup;
            btnExpense.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpense.ForeColor = Color.White;
            btnExpense.Location = new Point(55, 245);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(124, 33);
            btnExpense.TabIndex = 20;
            btnExpense.Text = "Expenses";
            btnExpense.TextAlign = ContentAlignment.MiddleLeft;
            btnExpense.UseVisualStyleBackColor = false;
            btnExpense.Click += btnExpense_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.dashboard_9823585;
            pictureBox8.Location = new Point(13, 12);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.RoyalBlue;
            btnOverview.BackgroundImageLayout = ImageLayout.Zoom;
            btnOverview.Cursor = Cursors.Hand;
            btnOverview.FlatStyle = FlatStyle.Popup;
            btnOverview.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOverview.ForeColor = Color.White;
            btnOverview.ImageAlign = ContentAlignment.MiddleLeft;
            btnOverview.ImageKey = "(none)";
            btnOverview.Location = new Point(55, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(124, 33);
            btnOverview.TabIndex = 14;
            btnOverview.Text = "Overview";
            btnOverview.TextAlign = ContentAlignment.MiddleLeft;
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.switch_11302228;
            pictureBox2.Location = new Point(8, 457);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.patience_7977760;
            pictureBox5.Location = new Point(13, 188);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.business_chart_12488714;
            pictureBox6.Location = new Point(13, 132);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.menu_3751751;
            pictureBox7.Location = new Point(13, 71);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(36, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            // 
            // btnManu
            // 
            btnManu.BackgroundImageLayout = ImageLayout.Zoom;
            btnManu.Cursor = Cursors.Hand;
            btnManu.FlatStyle = FlatStyle.Popup;
            btnManu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManu.ForeColor = Color.White;
            btnManu.ImageAlign = ContentAlignment.MiddleLeft;
            btnManu.ImageKey = "(none)";
            btnManu.Location = new Point(55, 71);
            btnManu.Name = "btnManu";
            btnManu.Size = new Size(124, 33);
            btnManu.TabIndex = 2;
            btnManu.Text = "Manu";
            btnManu.TextAlign = ContentAlignment.MiddleLeft;
            btnManu.UseVisualStyleBackColor = false;
            btnManu.Click += btnManu_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(58, 457);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(124, 31);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log-Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnUser
            // 
            btnUser.Cursor = Cursors.Hand;
            btnUser.FlatStyle = FlatStyle.Popup;
            btnUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(58, 188);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(124, 33);
            btnUser.TabIndex = 5;
            btnUser.Text = "All Users";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnSalesHistory
            // 
            btnSalesHistory.Cursor = Cursors.Hand;
            btnSalesHistory.FlatStyle = FlatStyle.Popup;
            btnSalesHistory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalesHistory.ForeColor = Color.White;
            btnSalesHistory.Location = new Point(55, 130);
            btnSalesHistory.Name = "btnSalesHistory";
            btnSalesHistory.Size = new Size(124, 33);
            btnSalesHistory.TabIndex = 4;
            btnSalesHistory.Text = "Sales History";
            btnSalesHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesHistory.UseVisualStyleBackColor = false;
            btnSalesHistory.Click += btnSalesHistory_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblWlcName);
            panel5.Location = new Point(439, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(403, 35);
            panel5.TabIndex = 3;
            // 
            // lblWlcName
            // 
            lblWlcName.AutoSize = true;
            lblWlcName.Dock = DockStyle.Right;
            lblWlcName.Font = new Font("Arial", 13F, FontStyle.Bold);
            lblWlcName.ForeColor = Color.DarkSlateGray;
            lblWlcName.Location = new Point(181, 0);
            lblWlcName.Name = "lblWlcName";
            lblWlcName.Size = new Size(222, 21);
            lblWlcName.TabIndex = 0;
            lblWlcName.Text = "Welcome, Asef Abdullah";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(3, 9);
            label10.Name = "label10";
            label10.Size = new Size(278, 38);
            label10.TabIndex = 2;
            label10.Text = "Admin Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(186, 216, 182);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(199, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(851, 61);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(lblExpense);
            panel4.Location = new Point(484, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 103);
            panel4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(119, 55);
            label5.Name = "label5";
            label5.Size = new Size(48, 32);
            label5.TabIndex = 5;
            label5.Text = "TK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 4;
            label3.Text = "Total Expense";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.mil_16161044;
            pictureBox3.Location = new Point(210, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblExpense
            // 
            lblExpense.AutoSize = true;
            lblExpense.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpense.ForeColor = SystemColors.ActiveCaptionText;
            lblExpense.Location = new Point(10, 55);
            lblExpense.Name = "lblExpense";
            lblExpense.Size = new Size(90, 32);
            lblExpense.TabIndex = 1;
            lblExpense.Text = "00.00 ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 108, 181);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(lblSale);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(201, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 104);
            panel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(128, 54);
            label4.Name = "label4";
            label4.Size = new Size(48, 32);
            label4.TabIndex = 4;
            label4.Text = "TK";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_16606522;
            pictureBox4.Location = new Point(211, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // lblSale
            // 
            lblSale.AutoSize = true;
            lblSale.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSale.ForeColor = Color.White;
            lblSale.Location = new Point(14, 54);
            lblSale.Name = "lblSale";
            lblSale.Size = new Size(82, 32);
            lblSale.TabIndex = 1;
            lblSale.Text = "00.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 19);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 0;
            label2.Text = "Total Sale";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(pictureBox10);
            panel7.Location = new Point(200, 181);
            panel7.Name = "panel7";
            panel7.Size = new Size(851, 377);
            panel7.TabIndex = 9;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(-1, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(852, 374);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox9);
            panel6.Controls.Add(LblProfit);
            panel6.Location = new Point(768, 71);
            panel6.Name = "panel6";
            panel6.Size = new Size(279, 103);
            panel6.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 4;
            label1.Text = "Total Profit";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(221, 14);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(50, 36);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 3;
            pictureBox9.TabStop = false;
            // 
            // LblProfit
            // 
            LblProfit.AutoSize = true;
            LblProfit.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProfit.ForeColor = SystemColors.ActiveCaptionText;
            LblProfit.Location = new Point(18, 52);
            LblProfit.Name = "LblProfit";
            LblProfit.Size = new Size(124, 32);
            LblProfit.TabIndex = 1;
            LblProfit.Text = "00.00 TK";
            // 
            // FrmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 561);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosed += FrmAdminDashboard_FormClosed;
            Load += FrmAdminDashboard_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnExpense;
        private PictureBox pictureBox8;
        protected Button btnOverview;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        protected Button btnManu;
        private Button btnLogOut;
        private Button btnUser;
        private Button btnSalesHistory;
        private Panel panel5;
        private Label lblWlcName;
        private Label label10;
        private Panel panel1;
        private Panel panel4;
        private Label label3;
        private PictureBox pictureBox3;
        private Label lblExpense;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label lblSale;
        private Label label2;
        private Panel panel7;
        private Panel panel6;
        private Label label1;
        private PictureBox pictureBox9;
        private Label LblProfit;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private Button btnAttendance;
        private Label label5;
        private Label label4;
    }
}