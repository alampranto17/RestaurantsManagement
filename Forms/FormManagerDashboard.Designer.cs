namespace Forms
{
    partial class FormManagerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagerDashboard));
            panel1 = new Panel();
            panel5 = new Panel();
            lblWlcName = new Label();
            btnAddFood = new Button();
            btnlogin = new Button();
            btnAttendence = new Button();
            btnSalesAdd = new Button();
            lLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(186, 216, 182);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnAddFood);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(btnAttendence);
            panel1.Controls.Add(btnSalesAdd);
            panel1.Controls.Add(lLabel);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 117);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblWlcName);
            panel5.Location = new Point(678, 16);
            panel5.Name = "panel5";
            panel5.Size = new Size(346, 35);
            panel5.TabIndex = 7;
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
            // btnAddFood
            // 
            btnAddFood.Cursor = Cursors.Hand;
            btnAddFood.FlatStyle = FlatStyle.Popup;
            btnAddFood.Location = new Point(363, 81);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(75, 23);
            btnAddFood.TabIndex = 6;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(186, 216, 182);
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.Location = new Point(591, 81);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Log-Out";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnAttendence
            // 
            btnAttendence.Cursor = Cursors.Hand;
            btnAttendence.FlatStyle = FlatStyle.Popup;
            btnAttendence.Location = new Point(476, 81);
            btnAttendence.Name = "btnAttendence";
            btnAttendence.Size = new Size(85, 23);
            btnAttendence.TabIndex = 4;
            btnAttendence.Tag = "";
            btnAttendence.Text = "Attendence";
            btnAttendence.UseVisualStyleBackColor = true;
            btnAttendence.Click += btnAttendence_Click;
            // 
            // btnSalesAdd
            // 
            btnSalesAdd.Cursor = Cursors.Hand;
            btnSalesAdd.FlatStyle = FlatStyle.Popup;
            btnSalesAdd.Location = new Point(261, 81);
            btnSalesAdd.Name = "btnSalesAdd";
            btnSalesAdd.Size = new Size(75, 23);
            btnSalesAdd.TabIndex = 2;
            btnSalesAdd.Text = "Sales";
            btnSalesAdd.UseVisualStyleBackColor = true;
            btnSalesAdd.Click += btnSalesAdd_Click;
            // 
            // lLabel
            // 
            lLabel.AutoSize = true;
            lLabel.Font = new Font("Arial Narrow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lLabel.ForeColor = Color.DarkSlateGray;
            lLabel.Location = new Point(9, 16);
            lLabel.Name = "lLabel";
            lLabel.Size = new Size(167, 42);
            lLabel.TabIndex = 0;
            lLabel.Text = "Dashboard ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8002227;
            pictureBox1.Location = new Point(166, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(667, 423);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 561);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormManagerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormManagerDashboard";
            FormClosed += FormManagerDashboard_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lLabel;
        private Button btnAttendence;
        private Button btnSalesAdd;
        private Button btnlogin;
        private PictureBox pictureBox1;
        private Button btnAddFood;
        private Panel panel5;
        private Label lblWlcName;
    }
}