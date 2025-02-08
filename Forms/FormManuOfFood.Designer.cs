namespace Forms
{
    partial class FormManuOfFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManuOfFood));
            panel1 = new Panel();
            label10 = new Label();
            panel5 = new Panel();
            lblWlcName = new Label();
            panel3 = new Panel();
            pictureBox11 = new PictureBox();
            btnAttendance = new Button();
            pictureBox1 = new PictureBox();
            btnExpenses = new Button();
            pictureBox8 = new PictureBox();
            btnOverview = new Button();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            btnManu = new Button();
            btnLogOut = new Button();
            btnUsers = new Button();
            btnSalesHistory = new Button();
            panel12 = new Panel();
            txtSearch = new TextBox();
            btnAdd = new Button();
            panel6 = new Panel();
            dgvFoodTable = new DataGridView();
            FoodID = new DataGridViewTextBoxColumn();
            FoodName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            StockQuantity = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            EditAction = new DataGridViewButtonColumn();
            DeleteAction = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel12.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(186, 216, 182);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(201, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 61);
            panel1.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(3, 9);
            label10.Name = "label10";
            label10.Size = new Size(237, 38);
            label10.TabIndex = 2;
            label10.Text = "Manu Of Foods";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblWlcName);
            panel5.Location = new Point(483, 7);
            panel5.Name = "panel5";
            panel5.Size = new Size(358, 35);
            panel5.TabIndex = 3;
            // 
            // lblWlcName
            // 
            lblWlcName.AutoSize = true;
            lblWlcName.Dock = DockStyle.Right;
            lblWlcName.Font = new Font("Arial", 13F, FontStyle.Bold);
            lblWlcName.ForeColor = Color.DarkSlateGray;
            lblWlcName.Location = new Point(136, 0);
            lblWlcName.Name = "lblWlcName";
            lblWlcName.Size = new Size(222, 21);
            lblWlcName.TabIndex = 0;
            lblWlcName.Text = "Welcome, Asef Abdullah";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(9, 18, 44);
            panel3.Controls.Add(pictureBox11);
            panel3.Controls.Add(btnAttendance);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnExpenses);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(btnOverview);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(btnManu);
            panel3.Controls.Add(btnLogOut);
            panel3.Controls.Add(btnUsers);
            panel3.Controls.Add(btnSalesHistory);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 555);
            panel3.TabIndex = 10;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(13, 316);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(36, 33);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 29;
            pictureBox11.TabStop = false;
            // 
            // btnAttendance
            // 
            btnAttendance.Cursor = Cursors.Hand;
            btnAttendance.FlatStyle = FlatStyle.Popup;
            btnAttendance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(55, 316);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(124, 33);
            btnAttendance.TabIndex = 28;
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
            // btnExpenses
            // 
            btnExpenses.Cursor = Cursors.Hand;
            btnExpenses.FlatStyle = FlatStyle.Popup;
            btnExpenses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpenses.ForeColor = Color.White;
            btnExpenses.Location = new Point(55, 245);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(124, 33);
            btnExpenses.TabIndex = 20;
            btnExpenses.Text = "Expenses";
            btnExpenses.TextAlign = ContentAlignment.MiddleLeft;
            btnExpenses.UseVisualStyleBackColor = false;
            btnExpenses.Click += btnExpenses_Click;
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
            btnManu.BackColor = Color.RoyalBlue;
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
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(txtSearch);
            panel12.Controls.Add(btnAdd);
            panel12.Location = new Point(201, 73);
            panel12.Name = "panel12";
            panel12.Size = new Size(849, 75);
            panel12.TabIndex = 22;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(14, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Serach by Food Name";
            txtSearch.Size = new Size(355, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(49, 108, 181);
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(649, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(179, 46);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Food";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dgvFoodTable);
            panel6.Location = new Point(202, 154);
            panel6.Name = "panel6";
            panel6.Size = new Size(847, 404);
            panel6.TabIndex = 23;
            // 
            // dgvFoodTable
            // 
            dgvFoodTable.AllowUserToAddRows = false;
            dgvFoodTable.AllowUserToDeleteRows = false;
            dgvFoodTable.BackgroundColor = SystemColors.HighlightText;
            dgvFoodTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodTable.Columns.AddRange(new DataGridViewColumn[] { FoodID, FoodName, Price, StockQuantity, Category, EditAction, DeleteAction });
            dgvFoodTable.Location = new Point(7, 16);
            dgvFoodTable.Name = "dgvFoodTable";
            dgvFoodTable.ReadOnly = true;
            dgvFoodTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodTable.Size = new Size(834, 380);
            dgvFoodTable.TabIndex = 0;
            dgvFoodTable.CellContentClick += dgvFoodTable_CellContentClick;
            // 
            // FoodID
            // 
            FoodID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FoodID.DataPropertyName = "FoodID";
            FoodID.HeaderText = "Food ID";
            FoodID.Name = "FoodID";
            FoodID.ReadOnly = true;
            // 
            // FoodName
            // 
            FoodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FoodName.DataPropertyName = "FoodName";
            FoodName.HeaderText = "Food Name";
            FoodName.Name = "FoodName";
            FoodName.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "PricePerUnit";
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // StockQuantity
            // 
            StockQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockQuantity.DataPropertyName = "Quantity";
            StockQuantity.HeaderText = "Stock Quantity";
            StockQuantity.Name = "StockQuantity";
            StockQuantity.ReadOnly = true;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // EditAction
            // 
            EditAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EditAction.HeaderText = "";
            EditAction.Name = "EditAction";
            EditAction.ReadOnly = true;
            EditAction.Resizable = DataGridViewTriState.True;
            EditAction.SortMode = DataGridViewColumnSortMode.Automatic;
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
            DeleteAction.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteAction.Text = "Delete";
            DeleteAction.UseColumnTextForButtonValue = true;
            // 
            // FormManuOfFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 561);
            Controls.Add(panel6);
            Controls.Add(panel12);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormManuOfFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manu Of Food";
            FormClosed += FormManuOfFood_FormClosed;
            Load += FormManuOfFood_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFoodTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label10;
        private Panel panel5;
        private Label lblWlcName;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnExpenses;
        private PictureBox pictureBox8;
        protected Button btnOverview;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        protected Button btnManu;
        private Button btnLogOut;
        private Button btnUsers;
        private Button btnSalesHistory;
        private Panel panel12;
        private Button btnAdd;
        private TextBox txtSearch;
        private Panel panel6;
        private DataGridView dgvFoodTable;
        private DataGridViewTextBoxColumn FoodID;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn StockQuantity;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewButtonColumn EditAction;
        private DataGridViewButtonColumn DeleteAction;
        private PictureBox pictureBox11;
        private Button btnAttendance;
    }
}