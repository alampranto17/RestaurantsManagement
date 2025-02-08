namespace Forms
{
    partial class FormExpense
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
            Button btnSalesHistory;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpense));
            label9 = new Label();
            panel5 = new Panel();
            lblWlcName = new Label();
            panel2 = new Panel();
            dgvExpense = new DataGridView();
            ExpenseId = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            CreatedBy = new DataGridViewTextBoxColumn();
            EditAction = new DataGridViewButtonColumn();
            DeleteAction = new DataGridViewButtonColumn();
            panel6 = new Panel();
            txtSearch = new TextBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label3 = new Label();
            label7 = new Label();
            panel12 = new Panel();
            btnAdd = new Button();
            label13 = new Label();
            lblThisYear = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            label12 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            lblThisDay = new Label();
            label4 = new Label();
            panel9 = new Panel();
            label5 = new Label();
            lblThisWeeK = new Label();
            label2 = new Label();
            panel8 = new Panel();
            panel1 = new Panel();
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
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).BeginInit();
            panel6.SuspendLayout();
            panel12.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(9, 9);
            label9.Name = "label9";
            label9.Size = new Size(262, 38);
            label9.TabIndex = 1;
            label9.Text = "Expense History";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblWlcName);
            panel5.Location = new Point(434, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 35);
            panel5.TabIndex = 5;
            // 
            // lblWlcName
            // 
            lblWlcName.AutoSize = true;
            lblWlcName.Dock = DockStyle.Right;
            lblWlcName.Font = new Font("Arial", 13F, FontStyle.Bold);
            lblWlcName.ForeColor = Color.DarkSlateGray;
            lblWlcName.Location = new Point(180, 0);
            lblWlcName.Name = "lblWlcName";
            lblWlcName.Size = new Size(222, 21);
            lblWlcName.TabIndex = 0;
            lblWlcName.Text = "Welcome, Asef Abdullah";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(186, 216, 182);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label9);
            panel2.ForeColor = Color.DarkSlateBlue;
            panel2.Location = new Point(199, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 56);
            panel2.TabIndex = 44;
            // 
            // dgvExpense
            // 
            dgvExpense.AllowUserToAddRows = false;
            dgvExpense.AllowUserToDeleteRows = false;
            dgvExpense.BackgroundColor = SystemColors.HighlightText;
            dgvExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpense.Columns.AddRange(new DataGridViewColumn[] { ExpenseId, Amount, Category, Description, Date, Time, CreatedBy, EditAction, DeleteAction });
            dgvExpense.Location = new Point(9, 10);
            dgvExpense.Name = "dgvExpense";
            dgvExpense.ReadOnly = true;
            dgvExpense.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpense.Size = new Size(831, 254);
            dgvExpense.TabIndex = 0;
            dgvExpense.CellContentClick += dgvExpense_CellContentClick;
            // 
            // ExpenseId
            // 
            ExpenseId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ExpenseId.DataPropertyName = "ExpenseID";
            ExpenseId.HeaderText = "Expense ID";
            ExpenseId.Name = "ExpenseId";
            ExpenseId.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Time
            // 
            Time.DataPropertyName = "Time";
            Time.HeaderText = "Time";
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // CreatedBy
            // 
            CreatedBy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CreatedBy.DataPropertyName = "CreatedBy";
            CreatedBy.HeaderText = "Created By";
            CreatedBy.Name = "CreatedBy";
            CreatedBy.ReadOnly = true;
            // 
            // EditAction
            // 
            EditAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EditAction.HeaderText = "";
            EditAction.Name = "EditAction";
            EditAction.ReadOnly = true;
            EditAction.Text = "Edit";
            EditAction.UseColumnTextForButtonValue = true;
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
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dgvExpense);
            panel6.Location = new Point(198, 285);
            panel6.Name = "panel6";
            panel6.Size = new Size(849, 273);
            panel6.TabIndex = 45;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(11, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Serach by Category";
            txtSearch.Size = new Size(288, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Location = new Point(606, 13);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(228, 25);
            dtpStartDate.TabIndex = 4;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Location = new Point(606, 49);
            dtpEndDate.MaxDate = new DateTime(2025, 12, 25, 0, 0, 0, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(228, 25);
            dtpEndDate.TabIndex = 5;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(546, 13);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 6;
            label3.Text = "From:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(546, 49);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 7;
            label7.Text = "To:";
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(btnAdd);
            panel12.Controls.Add(label7);
            panel12.Controls.Add(label3);
            panel12.Controls.Add(dtpEndDate);
            panel12.Controls.Add(dtpStartDate);
            panel12.Controls.Add(txtSearch);
            panel12.Location = new Point(198, 193);
            panel12.Name = "panel12";
            panel12.Size = new Size(849, 85);
            panel12.TabIndex = 46;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(438, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 37);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Expense";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(9, 6);
            label13.Name = "label13";
            label13.Size = new Size(89, 20);
            label13.TabIndex = 7;
            label13.Text = "Total Expense";
            // 
            // lblThisYear
            // 
            lblThisYear.AutoSize = true;
            lblThisYear.BackColor = Color.White;
            lblThisYear.Font = new Font("Arial", 19F);
            lblThisYear.ForeColor = Color.Black;
            lblThisYear.Location = new Point(156, 66);
            lblThisYear.Name = "lblThisYear";
            lblThisYear.Size = new Size(124, 31);
            lblThisYear.TabIndex = 8;
            lblThisYear.Text = "00.00  TK";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.BackColor = Color.White;
            lblStartDate.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = Color.Black;
            lblStartDate.Location = new Point(14, 31);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(82, 17);
            lblStartDate.TabIndex = 9;
            lblStartDate.Text = "29-01-2020";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.BackColor = Color.White;
            lblEndDate.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndDate.ForeColor = Color.Black;
            lblEndDate.Location = new Point(36, 49);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(82, 17);
            lblEndDate.TabIndex = 10;
            lblEndDate.Text = "29-01-2020";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(14, 50);
            label12.Name = "label12";
            label12.Size = new Size(20, 17);
            label12.TabIndex = 11;
            label12.Text = "to";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label12);
            panel4.Controls.Add(lblEndDate);
            panel4.Controls.Add(lblStartDate);
            panel4.Controls.Add(lblThisYear);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(750, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 108);
            panel4.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(5, 7);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 0;
            label10.Text = "Total Expense";
            // 
            // lblThisDay
            // 
            lblThisDay.AutoSize = true;
            lblThisDay.Font = new Font("Arial", 19F);
            lblThisDay.ForeColor = Color.White;
            lblThisDay.Location = new Point(110, 66);
            lblThisDay.Name = "lblThisDay";
            lblThisDay.Size = new Size(124, 31);
            lblThisDay.TabIndex = 5;
            lblThisDay.Text = "00.00  TK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(7, 27);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 6;
            label4.Text = "Since Today";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(49, 108, 181);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(lblThisDay);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(198, 77);
            panel9.Name = "panel9";
            panel9.Size = new Size(259, 108);
            panel9.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(10, 11);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 7;
            label5.Text = "Total Expence ";
            // 
            // lblThisWeeK
            // 
            lblThisWeeK.AutoSize = true;
            lblThisWeeK.BackColor = Color.White;
            lblThisWeeK.Font = new Font("Arial", 19F);
            lblThisWeeK.ForeColor = Color.Black;
            lblThisWeeK.Location = new Point(133, 66);
            lblThisWeeK.Name = "lblThisWeeK";
            lblThisWeeK.Size = new Size(124, 31);
            lblThisWeeK.TabIndex = 8;
            lblThisWeeK.Text = "00.00  TK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 9;
            label2.Text = "Since this Week";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label2);
            panel8.Controls.Add(lblThisWeeK);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(463, 77);
            panel8.Name = "panel8";
            panel8.Size = new Size(281, 109);
            panel8.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 18, 44);
            panel1.Controls.Add(pictureBox11);
            panel1.Controls.Add(btnAttendance);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExpense);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(btnOverview);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(btnManu);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnSalesHistory);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(2, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 552);
            panel1.TabIndex = 55;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(13, 309);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(36, 33);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 27;
            pictureBox11.TabStop = false;
            // 
            // btnAttendance
            // 
            btnAttendance.Cursor = Cursors.Hand;
            btnAttendance.FlatStyle = FlatStyle.Popup;
            btnAttendance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(55, 309);
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
            btnExpense.BackColor = Color.RoyalBlue;
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
            pictureBox2.Location = new Point(8, 465);
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
            btnLogOut.Location = new Point(58, 465);
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
            // FormExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 561);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel4);
            Controls.Add(panel12);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormExpense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense";
            FormClosed += FormExpense_FormClosed;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).EndInit();
            panel6.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
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

        private Label label9;
        private Panel panel5;
        private Label lblWlcName;
        private Panel panel2;
        private DataGridView dgvExpense;
        private Panel panel6;
        private TextBox txtSearch;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label3;
        private Label label7;
        private Panel panel12;
        private Label label13;
        private Label lblThisYear;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label label12;
        private Panel panel4;
        private Label label10;
        private Label lblThisDay;
        private Label label4;
        private Panel panel9;
        private Label label5;
        private Label lblThisWeeK;
        private Label label2;
        private Panel panel8;
        private Panel panel1;
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
        private DataGridViewTextBoxColumn ExpenseId;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn CreatedBy;
        private DataGridViewButtonColumn EditAction;
        private DataGridViewButtonColumn DeleteAction;
        private Button btnAdd;
        private PictureBox pictureBox11;
        private Button btnAttendance;
    }
}