namespace Forms
{
    partial class FormAddAttendances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAttendances));
            panel1 = new Panel();
            panel5 = new Panel();
            lblWlcName = new Label();
            lLabel = new Label();
            btnlogin = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dgvAttendances = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            chkstatus = new DataGridViewCheckBoxColumn();
            Okey = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendances).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(186, 216, 182);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(lLabel);
            panel1.Location = new Point(4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 79);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblWlcName);
            panel5.Location = new Point(692, 17);
            panel5.Name = "panel5";
            panel5.Size = new Size(346, 35);
            panel5.TabIndex = 6;
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
            // lLabel
            // 
            lLabel.AutoSize = true;
            lLabel.Font = new Font("Arial Narrow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lLabel.ForeColor = Color.DarkSlateGray;
            lLabel.Location = new Point(8, 17);
            lLabel.Name = "lLabel";
            lLabel.Size = new Size(177, 42);
            lLabel.TabIndex = 0;
            lLabel.Text = "Attendances";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Red;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.ForeColor = SystemColors.ControlLightLight;
            btnlogin.Location = new Point(737, 523);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(89, 26);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Back";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(492, 470);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._79z_2203_w012_n001_48c_p6_481;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(492, 470);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvAttendances);
            panel3.Location = new Point(501, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(547, 405);
            panel3.TabIndex = 7;
            // 
            // dgvAttendances
            // 
            dgvAttendances.AllowUserToAddRows = false;
            dgvAttendances.AllowUserToDeleteRows = false;
            dgvAttendances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendances.Columns.AddRange(new DataGridViewColumn[] { UserId, UserName, Date, Time, Role, chkstatus, Okey });
            dgvAttendances.Location = new Point(3, 4);
            dgvAttendances.Name = "dgvAttendances";
            dgvAttendances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendances.Size = new Size(538, 399);
            dgvAttendances.TabIndex = 0;
            dgvAttendances.CellContentClick += dgvAttendances_CellContentClick;
            // 
            // UserId
            // 
            UserId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "User Id";
            UserId.Name = "UserId";
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.DataPropertyName = "Name";
            UserName.HeaderText = "User Name";
            UserName.Name = "UserName";
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Time
            // 
            Time.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Time.DataPropertyName = "Time";
            Time.HeaderText = "Time";
            Time.Name = "Time";
            // 
            // Role
            // 
            Role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Role.DataPropertyName = "Role";
            Role.HeaderText = "Role";
            Role.Name = "Role";
            // 
            // chkstatus
            // 
            chkstatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            chkstatus.HeaderText = "Present";
            chkstatus.Name = "chkstatus";
            chkstatus.Resizable = DataGridViewTriState.True;
            // 
            // Okey
            // 
            Okey.HeaderText = " ";
            Okey.Name = "Okey";
            Okey.ReadOnly = true;
            Okey.Resizable = DataGridViewTriState.True;
            Okey.SortMode = DataGridViewColumnSortMode.Automatic;
            Okey.Text = "Okey";
            Okey.UseColumnTextForButtonValue = true;
            // 
            // FormAddAttendances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1054, 561);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnlogin);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormAddAttendances";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Attendance";
            FormClosed += FormAddAttendances_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendances).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lLabel;
        private Button btnlogin;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private DataGridView dgvAttendances;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewCheckBoxColumn chkstatus;
        private DataGridViewButtonColumn Okey;
        private Panel panel5;
        private Label lblWlcName;
    }
}