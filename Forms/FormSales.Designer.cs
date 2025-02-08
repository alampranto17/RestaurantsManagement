namespace Forms
{
    partial class FormSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSales));
            panel8 = new Panel();
            label2 = new Label();
            lblThisWeeK = new Label();
            label5 = new Label();
            panel9 = new Panel();
            label4 = new Label();
            lblThisDay = new Label();
            label10 = new Label();
            panel12 = new Panel();
            label7 = new Label();
            label3 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            txtSearch = new TextBox();
            btnAdd = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            lblWlcName = new Label();
            label9 = new Label();
            panel6 = new Panel();
            dgvSale = new DataGridView();
            SaleId = new DataGridViewTextBoxColumn();
            CreatedBy = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            GrandTotal = new DataGridViewTextBoxColumn();
            GivenAmount = new DataGridViewTextBoxColumn();
            Change = new DataGridViewTextBoxColumn();
            Details = new DataGridViewButtonColumn();
            DeleteAction = new DataGridViewButtonColumn();
            panel4 = new Panel();
            label12 = new Label();
            lblEndDate = new Label();
            lblStartDate = new Label();
            lblBetweenDates = new Label();
            label13 = new Label();
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
            btnUsers = new Button();
            button4 = new Button();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel12.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSale).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label2);
            panel8.Controls.Add(lblThisWeeK);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(468, 8);
            panel8.Name = "panel8";
            panel8.Size = new Size(278, 88);
            panel8.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(5, 26);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 9;
            label2.Text = "Since this Week";
            // 
            // lblThisWeeK
            // 
            lblThisWeeK.AutoSize = true;
            lblThisWeeK.BackColor = Color.White;
            lblThisWeeK.Font = new Font("Arial", 19F);
            lblThisWeeK.ForeColor = Color.Black;
            lblThisWeeK.Location = new Point(140, 48);
            lblThisWeeK.Name = "lblThisWeeK";
            lblThisWeeK.Size = new Size(124, 31);
            lblThisWeeK.TabIndex = 8;
            lblThisWeeK.Text = "00.00  TK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Total Sales";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(49, 108, 181);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(lblThisDay);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(200, 10);
            panel9.Name = "panel9";
            panel9.Size = new Size(260, 88);
            panel9.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 27);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 6;
            label4.Text = "Since Today";
            // 
            // lblThisDay
            // 
            lblThisDay.AutoSize = true;
            lblThisDay.Font = new Font("Arial", 19F);
            lblThisDay.ForeColor = Color.White;
            lblThisDay.Location = new Point(123, 47);
            lblThisDay.Name = "lblThisDay";
            lblThisDay.Size = new Size(124, 31);
            lblThisDay.TabIndex = 5;
            lblThisDay.Text = "00.00  TK";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(6, 7);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 0;
            label10.Text = "Total Sales";
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(label7);
            panel12.Controls.Add(label3);
            panel12.Controls.Add(dtpEndDate);
            panel12.Controls.Add(dtpStartDate);
            panel12.Controls.Add(txtSearch);
            panel12.Location = new Point(199, 103);
            panel12.Name = "panel12";
            panel12.Size = new Size(855, 85);
            panel12.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(558, 47);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 7;
            label7.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(558, 11);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 6;
            label3.Text = "From:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Location = new Point(618, 47);
            dtpEndDate.MaxDate = new DateTime(2025, 12, 25, 0, 0, 0, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(213, 25);
            dtpEndDate.TabIndex = 5;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Location = new Point(618, 11);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(213, 25);
            dtpStartDate.TabIndex = 4;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(10, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Serach by Created By";
            txtSearch.Size = new Size(375, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(728, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 33);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New Sale";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label9);
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(-81, -116);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 56);
            panel2.TabIndex = 49;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblWlcName);
            panel5.Location = new Point(546, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 35);
            panel5.TabIndex = 5;
            // 
            // lblWlcName
            // 
            lblWlcName.AutoSize = true;
            lblWlcName.Dock = DockStyle.Right;
            lblWlcName.Font = new Font("Arial", 13F, FontStyle.Bold);
            lblWlcName.ForeColor = Color.Black;
            lblWlcName.Location = new Point(180, 0);
            lblWlcName.Name = "lblWlcName";
            lblWlcName.Size = new Size(222, 21);
            lblWlcName.TabIndex = 0;
            lblWlcName.Text = "Welcome, Asef Abdullah";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(9, 9);
            label9.Name = "label9";
            label9.Size = new Size(217, 38);
            label9.TabIndex = 1;
            label9.Text = "Sales History";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dgvSale);
            panel6.Controls.Add(btnAdd);
            panel6.Location = new Point(199, 194);
            panel6.Name = "panel6";
            panel6.Size = new Size(855, 366);
            panel6.TabIndex = 50;
            // 
            // dgvSale
            // 
            dgvSale.AllowUserToAddRows = false;
            dgvSale.AllowUserToDeleteRows = false;
            dgvSale.BackgroundColor = SystemColors.HighlightText;
            dgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSale.Columns.AddRange(new DataGridViewColumn[] { SaleId, CreatedBy, Date, GrandTotal, GivenAmount, Change, Details, DeleteAction });
            dgvSale.Location = new Point(7, 43);
            dgvSale.Name = "dgvSale";
            dgvSale.ReadOnly = true;
            dgvSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSale.Size = new Size(842, 312);
            dgvSale.TabIndex = 0;
            dgvSale.CellContentClick += dgvSale_CellContentClick;
            // 
            // SaleId
            // 
            SaleId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SaleId.DataPropertyName = "SaleID";
            SaleId.HeaderText = "Sale ID";
            SaleId.Name = "SaleId";
            SaleId.ReadOnly = true;
            // 
            // CreatedBy
            // 
            CreatedBy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CreatedBy.DataPropertyName = "SalesmanName";
            CreatedBy.HeaderText = "Created By";
            CreatedBy.Name = "CreatedBy";
            CreatedBy.ReadOnly = true;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.DataPropertyName = "SaleDate";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // GrandTotal
            // 
            GrandTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GrandTotal.DataPropertyName = "TotalAmount";
            GrandTotal.HeaderText = "Grand Total";
            GrandTotal.Name = "GrandTotal";
            GrandTotal.ReadOnly = true;
            // 
            // GivenAmount
            // 
            GivenAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GivenAmount.DataPropertyName = "GivenAmount";
            GivenAmount.HeaderText = "Given Amount";
            GivenAmount.Name = "GivenAmount";
            GivenAmount.ReadOnly = true;
            // 
            // Change
            // 
            Change.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Change.DataPropertyName = "ChangeAmount";
            Change.HeaderText = "Change";
            Change.Name = "Change";
            Change.ReadOnly = true;
            // 
            // Details
            // 
            Details.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Details.HeaderText = "";
            Details.Name = "Details";
            Details.ReadOnly = true;
            Details.Text = "Details";
            Details.UseColumnTextForButtonValue = true;
            // 
            // DeleteAction
            // 
            DeleteAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeleteAction.HeaderText = "";
            DeleteAction.Name = "DeleteAction";
            DeleteAction.ReadOnly = true;
            DeleteAction.Resizable = DataGridViewTriState.True;
            DeleteAction.Text = "Delete";
            DeleteAction.UseColumnTextForButtonValue = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label12);
            panel4.Controls.Add(lblEndDate);
            panel4.Controls.Add(lblStartDate);
            panel4.Controls.Add(lblBetweenDates);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(754, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(293, 89);
            panel4.TabIndex = 52;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(5, 40);
            label12.Name = "label12";
            label12.Size = new Size(20, 17);
            label12.TabIndex = 11;
            label12.Text = "to";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.BackColor = Color.White;
            lblEndDate.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndDate.ForeColor = Color.Black;
            lblEndDate.Location = new Point(25, 40);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(82, 17);
            lblEndDate.TabIndex = 10;
            lblEndDate.Text = "29-01-2020";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.BackColor = Color.White;
            lblStartDate.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = Color.Black;
            lblStartDate.Location = new Point(3, 22);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(82, 17);
            lblStartDate.TabIndex = 9;
            lblStartDate.Text = "29-01-2020";
            // 
            // lblBetweenDates
            // 
            lblBetweenDates.AutoSize = true;
            lblBetweenDates.BackColor = Color.White;
            lblBetweenDates.Font = new Font("Arial", 19F);
            lblBetweenDates.ForeColor = Color.Black;
            lblBetweenDates.Location = new Point(158, 49);
            lblBetweenDates.Name = "lblBetweenDates";
            lblBetweenDates.Size = new Size(124, 31);
            lblBetweenDates.TabIndex = 8;
            lblBetweenDates.Text = "00.00  TK";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(5, 2);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 7;
            label13.Text = "Total Sales";
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
            panel3.Controls.Add(btnUsers);
            panel3.Controls.Add(button4);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(3, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 552);
            panel3.TabIndex = 53;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(13, 313);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(36, 33);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 27;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Cursor = Cursors.Hand;
            btnAttendance.FlatStyle = FlatStyle.Popup;
            btnAttendance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(55, 313);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(124, 33);
            btnAttendance.TabIndex = 26;
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
            // btnUsers
            // 
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.FlatStyle = FlatStyle.Popup;
            btnUsers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(58, 188);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(124, 33);
            btnUsers.TabIndex = 5;
            btnUsers.Text = "All Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(55, 130);
            button4.Name = "button4";
            button4.Size = new Size(124, 33);
            button4.TabIndex = 4;
            button4.Text = "Sales History";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FormSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 561);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel12);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Report";
            FormClosed += FormSales_FormClosed;
            Load += FormSales_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSale).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private Label label2;
        private Label lblThisWeeK;
        private Label label5;
        private Panel panel9;
        private Label label4;
        private Label lblThisDay;
        private Label label10;
        private Panel panel12;
        private Label label7;
        private Label label3;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Button btnAdd;
        private TextBox txtSearch;
        private Panel panel2;
        private Panel panel5;
        private Label lblWlcName;
        private Label label9;
        private Panel panel6;
        private DataGridView dgvSale;
        private Panel panel4;
        private Label label12;
        private Label lblEndDate;
        private Label lblStartDate;
        private Label lblBetweenDates;
        private Label label13;
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
        private Button btnUsers;
        private Button button4;
        private PictureBox pictureBox11;
        private Button btnAttendance;
        private DataGridViewTextBoxColumn SaleId;
        private DataGridViewTextBoxColumn CreatedBy;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn GrandTotal;
        private DataGridViewTextBoxColumn GivenAmount;
        private DataGridViewTextBoxColumn Change;
        private DataGridViewButtonColumn Details;
        private DataGridViewButtonColumn DeleteAction;
    }
}