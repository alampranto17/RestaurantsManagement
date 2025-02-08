namespace Forms
{
    partial class FormAddUser
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
            panel6 = new Panel();
            panel1 = new Panel();
            chkWaiter = new RadioButton();
            chkManger = new RadioButton();
            chkAdmin = new RadioButton();
            label8 = new Label();
            btnClear = new Button();
            btnCancel = new Button();
            txtPassword = new TextBox();
            asrer = new Label();
            txtPhone = new TextBox();
            sd = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtUserId = new TextBox();
            label4 = new Label();
            bntAdd = new Button();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(panel1);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(btnClear);
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(txtPassword);
            panel6.Controls.Add(asrer);
            panel6.Controls.Add(txtPhone);
            panel6.Controls.Add(sd);
            panel6.Controls.Add(txtName);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtUserId);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(bntAdd);
            panel6.Location = new Point(4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(784, 448);
            panel6.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.Controls.Add(chkWaiter);
            panel1.Controls.Add(chkManger);
            panel1.Controls.Add(chkAdmin);
            panel1.Location = new Point(27, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 88);
            panel1.TabIndex = 19;
            
            // 
            // chkWaiter
            // 
            chkWaiter.AutoSize = true;
            chkWaiter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkWaiter.Location = new Point(0, 56);
            chkWaiter.Name = "chkWaiter";
            chkWaiter.Size = new Size(73, 25);
            chkWaiter.TabIndex = 3;
            chkWaiter.TabStop = true;
            chkWaiter.Text = "Waiter";
            chkWaiter.UseVisualStyleBackColor = true;
            // 
            // chkManger
            // 
            chkManger.AutoSize = true;
            chkManger.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkManger.Location = new Point(0, 28);
            chkManger.Name = "chkManger";
            chkManger.Size = new Size(90, 25);
            chkManger.TabIndex = 1;
            chkManger.TabStop = true;
            chkManger.Text = "Manager";
            chkManger.UseVisualStyleBackColor = true;
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAdmin.Location = new Point(0, 3);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(74, 25);
            chkAdmin.TabIndex = 0;
            chkAdmin.TabStop = true;
            chkAdmin.Text = "Admin";
            chkAdmin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 18);
            label8.Name = "label8";
            label8.Size = new Size(236, 45);
            label8.TabIndex = 18;
            label8.Text = "Add New User";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(337, 384);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 42);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 50, 49);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(194, 384);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 42);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ScrollBar;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(398, 227);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(287, 29);
            txtPassword.TabIndex = 8;
            // 
            // asrer
            // 
            asrer.AutoSize = true;
            asrer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asrer.Location = new Point(396, 198);
            asrer.Name = "asrer";
            asrer.Size = new Size(76, 21);
            asrer.TabIndex = 7;
            asrer.Text = "Password";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.ScrollBar;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(31, 227);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(287, 29);
            txtPhone.TabIndex = 6;
            // 
            // sd
            // 
            sd.AutoSize = true;
            sd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sd.Location = new Point(29, 198);
            sd.Name = "sd";
            sd.Size = new Size(57, 21);
            sd.TabIndex = 5;
            sd.Text = "Phone:";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ScrollBar;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(398, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 29);
            txtName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(396, 117);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 3;
            label5.Text = "Name:";
            // 
            // txtUserId
            // 
            txtUserId.BackColor = SystemColors.ScrollBar;
            txtUserId.Enabled = false;
            txtUserId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserId.Location = new Point(31, 146);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(287, 29);
            txtUserId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 117);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 1;
            label4.Text = "User ID:";
            // 
            // bntAdd
            // 
            bntAdd.BackColor = Color.Green;
            bntAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntAdd.ForeColor = Color.White;
            bntAdd.Location = new Point(480, 384);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(114, 42);
            bntAdd.TabIndex = 0;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
            // 
            // FormAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add mployee";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panel1;
        private RadioButton chkManger;
        private RadioButton chkAdmin;
        private Label label8;
        private Button btnClear;
        private Button btnCancel;
        private TextBox txtPassword;
        private Label asrer;
        private TextBox txtPhone;
        private Label sd;
        private TextBox txtName;
        private Label label5;
        private TextBox txtUserId;
        private Label label4;
        private Button bntAdd;
        private RadioButton chkWaiter;
    }
}