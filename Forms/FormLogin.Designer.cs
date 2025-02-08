namespace Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            chkShowPass = new CheckBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            txtPhone = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(chkShowPass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPhone);
            panel1.Cursor = Cursors.IBeam;
            panel1.Location = new Point(401, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 482);
            panel1.TabIndex = 3;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Cursor = Cursors.Hand;
            chkShowPass.Font = new Font("Segoe UI", 12F);
            chkShowPass.ForeColor = SystemColors.ControlLightLight;
            chkShowPass.Location = new Point(73, 298);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(138, 25);
            chkShowPass.TabIndex = 12;
            chkShowPass.Text = "Show Password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(120, 493);
            label4.Name = "label4";
            label4.Size = new Size(381, 20);
            label4.TabIndex = 11;
            label4.Text = "**Please contact with an admin for Login Credentials.";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(70, 260);
            txtPassword.Margin = new Padding(10, 19, 89, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Enter Your Password";
            txtPassword.Size = new Size(296, 32);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(73, 229);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(66, 145);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 7;
            label3.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 33.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(66, 58);
            label1.Name = "label1";
            label1.Size = new Size(164, 74);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MintCream;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(77, 349);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(272, 37);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Info;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(69, 175);
            txtPhone.Margin = new Padding(10, 19, 89, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Enter Your Phone";
            txtPhone.Size = new Size(297, 32);
            txtPhone.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 482);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log-In";
            FormClosed += FrmLogin_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox chkShowPass;
        private Label label4;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button btnLogin;
        private TextBox txtPhone;
        private PictureBox pictureBox1;
    }
}
