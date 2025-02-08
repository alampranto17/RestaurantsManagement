namespace Forms
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            label10 = new Label();
            lblTotal = new Label();
            panel9 = new Panel();
            txtSearch = new TextBox();
            btnAdd = new Button();
            cboUserType = new ComboBox();
            panel12 = new Panel();
            label5 = new Label();
            lblAdmin = new Label();
            panel8 = new Panel();
            dgvUser = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            EditAction = new DataGridViewButtonColumn();
            DeleteAction = new DataGridViewButtonColumn();
            panel6 = new Panel();
            label2 = new Label();
            lblEmp = new Label();
            panel3 = new Panel();
            label9 = new Label();
            panel5 = new Panel();
            lblWlcName = new Label();
            panel2 = new Panel();
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
            btnUsers = new Button();
            btnSalesHistory = new Button();
            panel9.SuspendLayout();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 20);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 0;
            label10.Text = "Total Users";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(12, 44);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 37);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "00";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(49, 108, 181);
            panel9.Controls.Add(lblTotal);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(204, 69);
            panel9.Name = "panel9";
            panel9.Size = new Size(276, 97);
            panel9.TabIndex = 47;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(12, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Serach by Name";
            txtSearch.Size = new Size(296, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(49, 108, 181);
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(540, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 37);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New User";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // cboUserType
            // 
            cboUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUserType.FormattingEnabled = true;
            cboUserType.Items.AddRange(new object[] { "All", "Admin", "Employee" });
            cboUserType.Location = new Point(704, 23);
            cboUserType.Name = "cboUserType";
            cboUserType.Size = new Size(121, 23);
            cboUserType.TabIndex = 4;
            cboUserType.SelectedIndexChanged += cboUserType_SelectedIndexChanged_1;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(cboUserType);
            panel12.Controls.Add(btnAdd);
            panel12.Controls.Add(txtSearch);
            panel12.Location = new Point(203, 173);
            panel12.Name = "panel12";
            panel12.Size = new Size(843, 78);
            panel12.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(15, 17);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 7;
            label5.Text = "Total Admin";
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.White;
            lblAdmin.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmin.ForeColor = Color.Black;
            lblAdmin.Location = new Point(15, 43);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(53, 37);
            lblAdmin.TabIndex = 8;
            lblAdmin.Text = "00";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(lblAdmin);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(485, 68);
            panel8.Name = "panel8";
            panel8.Size = new Size(278, 98);
            panel8.TabIndex = 48;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AllowUserToOrderColumns = true;
            dgvUser.BackgroundColor = SystemColors.HighlightText;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { UserId, UserName, Phone, Password, Role, EditAction, DeleteAction });
            dgvUser.Location = new Point(6, 9);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(833, 280);
            dgvUser.TabIndex = 0;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // UserId
            // 
            UserId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "User ID";
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.DataPropertyName = "Name";
            UserName.HeaderText = "Name";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Role
            // 
            Role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Role.DataPropertyName = "Role";
            Role.HeaderText = "Role";
            Role.Name = "Role";
            Role.ReadOnly = true;
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
            panel6.Controls.Add(dgvUser);
            panel6.Location = new Point(203, 256);
            panel6.Name = "panel6";
            panel6.Size = new Size(843, 300);
            panel6.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 17);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 7;
            label2.Text = "Total Employee";
            // 
            // lblEmp
            // 
            lblEmp.AutoSize = true;
            lblEmp.BackColor = Color.White;
            lblEmp.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmp.ForeColor = Color.Black;
            lblEmp.Location = new Point(21, 43);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(53, 37);
            lblEmp.TabIndex = 8;
            lblEmp.Text = "00";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblEmp);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(769, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 98);
            panel3.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(9, 9);
            label9.Name = "label9";
            label9.Size = new Size(217, 38);
            label9.TabIndex = 1;
            label9.Text = "All Users List";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblWlcName);
            panel5.Location = new Point(489, 9);
            panel5.Name = "panel5";
            panel5.Size = new Size(346, 35);
            panel5.TabIndex = 5;
            // 
            // lblWlcName
            // 
            lblWlcName.AutoSize = true;
            lblWlcName.Dock = DockStyle.Right;
            lblWlcName.Font = new Font("Arial", 13F, FontStyle.Bold);
            lblWlcName.ForeColor = Color.DarkSlateGray;
            lblWlcName.Location = new Point(124, 0);
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
            panel2.ForeColor = Color.DarkSlateGray;
            panel2.Location = new Point(202, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(844, 56);
            panel2.TabIndex = 51;
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
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(btnSalesHistory);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 551);
            panel1.TabIndex = 54;
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
            btnUsers.BackColor = Color.RoyalBlue;
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
            // FormUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 561);
            Controls.Add(panel1);
            Controls.Add(panel12);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee List";
            FormClosed += FormUsers_FormClosed;
            Load += FormUsers_Load;
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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

        private Label label10;
        private Label lblTotal;
        private Panel panel9;
        private TextBox txtSearch;
        private Button btnAdd;
        private ComboBox cboUserType;
        private Panel panel12;
        private Label label5;
        private Label lblAdmin;
        private Panel panel8;
        private DataGridView dgvUser;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewButtonColumn EditAction;
        private DataGridViewButtonColumn DeleteAction;
        private Panel panel6;
        private Label label2;
        private Label lblEmp;
        private Panel panel3;
        private Label label9;
        private Panel panel5;
        private Label lblWlcName;
        private Panel panel2;
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
        private Button btnUsers;
        private PictureBox pictureBox11;
        private Button btnAttendance;
    }
}