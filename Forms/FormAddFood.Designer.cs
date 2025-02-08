namespace Forms
{
    partial class FormAddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddFood));
            panel6 = new Panel();
            cbCategory = new ComboBox();
            label1 = new Label();
            label8 = new Label();
            btnClear = new Button();
            btnCancel = new Button();
            txtStockQuantity = new TextBox();
            asrer = new Label();
            txtPrice = new TextBox();
            sd = new Label();
            txtFoodName = new TextBox();
            label5 = new Label();
            txtFoodId = new TextBox();
            label4 = new Label();
            bntAdd = new Button();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(cbCategory);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(btnClear);
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(txtStockQuantity);
            panel6.Controls.Add(asrer);
            panel6.Controls.Add(txtPrice);
            panel6.Controls.Add(sd);
            panel6.Controls.Add(txtFoodName);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtFoodId);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(bntAdd);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(794, 449);
            panel6.TabIndex = 30;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = SystemColors.ScrollBar;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Main Course", "Appetizers", "Desserts", "Snacks", "Soft Drinks" });
            cbCategory.Location = new Point(436, 199);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(277, 29);
            cbCategory.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(440, 169);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 19;
            label1.Text = "Category :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(252, 19);
            label8.Name = "label8";
            label8.Size = new Size(246, 45);
            label8.TabIndex = 18;
            label8.Text = "Add New Food";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(334, 393);
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
            btnCancel.Location = new Point(180, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 42);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.BackColor = SystemColors.ScrollBar;
            txtStockQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockQuantity.Location = new Point(75, 289);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(287, 29);
            txtStockQuantity.TabIndex = 8;
            // 
            // asrer
            // 
            asrer.AutoSize = true;
            asrer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asrer.Location = new Point(73, 260);
            asrer.Name = "asrer";
            asrer.Size = new Size(118, 21);
            asrer.TabIndex = 7;
            asrer.Text = "Stock Quantity :";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.ScrollBar;
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(73, 200);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(287, 29);
            txtPrice.TabIndex = 6;
            // 
            // sd
            // 
            sd.AutoSize = true;
            sd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sd.Location = new Point(77, 171);
            sd.Name = "sd";
            sd.Size = new Size(51, 21);
            sd.TabIndex = 5;
            sd.Text = "Price :";
            // 
            // txtFoodName
            // 
            txtFoodName.BackColor = SystemColors.ScrollBar;
            txtFoodName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFoodName.Location = new Point(440, 119);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(287, 29);
            txtFoodName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(438, 90);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 3;
            label5.Text = "Food Name:";
            // 
            // txtFoodId
            // 
            txtFoodId.BackColor = SystemColors.ScrollBar;
            txtFoodId.Enabled = false;
            txtFoodId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFoodId.Location = new Point(73, 119);
            txtFoodId.Name = "txtFoodId";
            txtFoodId.ReadOnly = true;
            txtFoodId.Size = new Size(287, 29);
            txtFoodId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 90);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 1;
            label4.Text = "Food ID:";
            // 
            // bntAdd
            // 
            bntAdd.BackColor = Color.Green;
            bntAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntAdd.ForeColor = Color.White;
            bntAdd.Location = new Point(488, 393);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(114, 42);
            bntAdd.TabIndex = 0;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
            // 
            // FormAddFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 447);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAddFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Manu";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Label label8;
        private Button btnClear;
        private Button btnCancel;
        private TextBox txtStockQuantity;
        private Label asrer;
        private TextBox txtPrice;
        private Label sd;
        private TextBox txtFoodName;
        private Label label5;
        private TextBox txtFoodId;
        private Label label4;
        private Button bntAdd;
        private Label label1;
        private ComboBox cbCategory;
    }
}