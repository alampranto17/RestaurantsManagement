namespace Forms
{
    partial class FormInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoices));
            panel2 = new Panel();
            btnPrint = new Button();
            panel4 = new Panel();
            label10 = new Label();
            lblMethod = new Label();
            panel3 = new Panel();
            label7 = new Label();
            lblSalesBy = new Label();
            panel6 = new Panel();
            dgvSale = new DataGridView();
            FoodName = new DataGridViewTextBoxColumn();
            QuantitySold = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            panel8 = new Panel();
            lblChange = new Label();
            label11 = new Label();
            panel7 = new Panel();
            label8 = new Label();
            lblGiven = new Label();
            panel5 = new Panel();
            lblGrand = new Label();
            label5 = new Label();
            lblTime = new Label();
            label4 = new Label();
            lblSaleId = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSale).BeginInit();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(btnPrint);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(lblTime);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblSaleId);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label9);
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(-62, -71);
            panel2.Name = "panel2";
            panel2.Size = new Size(862, 521);
            panel2.TabIndex = 46;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.ForestGreen;
            btnPrint.ForeColor = Color.AliceBlue;
            btnPrint.Location = new Point(755, 148);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(88, 26);
            btnPrint.TabIndex = 58;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label10);
            panel4.Controls.Add(lblMethod);
            panel4.Location = new Point(558, 118);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 28);
            panel4.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Right;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(99, 0);
            label10.Name = "label10";
            label10.Size = new Size(146, 21);
            label10.TabIndex = 49;
            label10.Text = "Payment Method:";
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Dock = DockStyle.Right;
            lblMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMethod.ForeColor = Color.Black;
            lblMethod.Location = new Point(245, 0);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(44, 21);
            lblMethod.TabIndex = 50;
            lblMethod.Text = "Cash";
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lblSalesBy);
            panel3.Location = new Point(559, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 28);
            panel3.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Right;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 47;
            label7.Text = "Sales By:";
            // 
            // lblSalesBy
            // 
            lblSalesBy.AutoSize = true;
            lblSalesBy.Dock = DockStyle.Right;
            lblSalesBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesBy.ForeColor = Color.Black;
            lblSalesBy.Location = new Point(76, 0);
            lblSalesBy.Name = "lblSalesBy";
            lblSalesBy.Size = new Size(213, 21);
            lblSalesBy.TabIndex = 48;
            lblSalesBy.Text = "Faysal Ahammed Chowdhury";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dgvSale);
            panel6.Controls.Add(btnBack);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel5);
            panel6.Location = new Point(75, 174);
            panel6.Name = "panel6";
            panel6.Size = new Size(773, 347);
            panel6.TabIndex = 46;
            // 
            // dgvSale
            // 
            dgvSale.AllowUserToAddRows = false;
            dgvSale.AllowUserToDeleteRows = false;
            dgvSale.AllowUserToOrderColumns = true;
            dgvSale.BackgroundColor = SystemColors.HighlightText;
            dgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSale.Columns.AddRange(new DataGridViewColumn[] { FoodName, QuantitySold, UnitPrice, Total });
            dgvSale.Location = new Point(3, 8);
            dgvSale.Name = "dgvSale";
            dgvSale.ReadOnly = true;
            dgvSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSale.Size = new Size(767, 229);
            dgvSale.TabIndex = 57;
            // 
            // FoodName
            // 
            FoodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FoodName.DataPropertyName = "FoodName";
            FoodName.HeaderText = "ProductName";
            FoodName.Name = "FoodName";
            FoodName.ReadOnly = true;
            // 
            // QuantitySold
            // 
            QuantitySold.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuantitySold.DataPropertyName = "QuantitySold";
            QuantitySold.HeaderText = "QuantitySold";
            QuantitySold.Name = "QuantitySold";
            QuantitySold.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UnitPrice.DataPropertyName = "PricePerUnit";
            UnitPrice.HeaderText = "Unit Price";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.DataPropertyName = "LineTotal";
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.ForeColor = Color.AliceBlue;
            btnBack.Location = new Point(275, 283);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 43);
            btnBack.TabIndex = 56;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(lblChange);
            panel8.Controls.Add(label11);
            panel8.Location = new Point(482, 305);
            panel8.Name = "panel8";
            panel8.Size = new Size(275, 26);
            panel8.TabIndex = 55;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Dock = DockStyle.Right;
            lblChange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(205, 0);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(70, 21);
            lblChange.TabIndex = 56;
            lblChange.Text = "00.00 TK";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(14, 0);
            label11.Name = "label11";
            label11.Size = new Size(72, 21);
            label11.TabIndex = 55;
            label11.Text = "Change:";
            // 
            // panel7
            // 
            panel7.Controls.Add(label8);
            panel7.Controls.Add(lblGiven);
            panel7.Location = new Point(482, 273);
            panel7.Name = "panel7";
            panel7.Size = new Size(275, 26);
            panel7.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(3, 2);
            label8.Name = "label8";
            label8.Size = new Size(124, 21);
            label8.TabIndex = 53;
            label8.Text = "Given Amount:";
            // 
            // lblGiven
            // 
            lblGiven.AutoSize = true;
            lblGiven.Dock = DockStyle.Right;
            lblGiven.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGiven.ForeColor = Color.Black;
            lblGiven.Location = new Point(205, 0);
            lblGiven.Name = "lblGiven";
            lblGiven.Size = new Size(70, 21);
            lblGiven.TabIndex = 54;
            lblGiven.Text = "00.00 TK";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblGrand);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(482, 241);
            panel5.Name = "panel5";
            panel5.Size = new Size(275, 26);
            panel5.TabIndex = 53;
            // 
            // lblGrand
            // 
            lblGrand.AutoSize = true;
            lblGrand.Dock = DockStyle.Right;
            lblGrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrand.ForeColor = Color.Black;
            lblGrand.Location = new Point(205, 0);
            lblGrand.Name = "lblGrand";
            lblGrand.Size = new Size(70, 21);
            lblGrand.TabIndex = 52;
            lblGrand.Text = "00.00 TK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 5);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 51;
            label5.Text = "Grand Total:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(126, 141);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(99, 21);
            lblTime.TabIndex = 7;
            lblTime.Text = "23-Jan-2025";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(78, 141);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 6;
            label4.Text = "Time:";
            // 
            // lblSaleId
            // 
            lblSaleId.AutoSize = true;
            lblSaleId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaleId.ForeColor = Color.Black;
            lblSaleId.Location = new Point(115, 115);
            lblSaleId.Name = "lblSaleId";
            lblSaleId.Size = new Size(89, 21);
            lblSaleId.TabIndex = 5;
            lblSaleId.Text = "#SALE-001";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(78, 115);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 3;
            label2.Text = "NO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(442, 14);
            label1.Name = "label1";
            label1.Size = new Size(485, 38);
            label1.TabIndex = 2;
            label1.Text = "CHOWDHURY FILLING STATION";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(77, 76);
            label9.Name = "label9";
            label9.Size = new Size(144, 38);
            label9.TabIndex = 1;
            label9.Text = "INVOICE";
            // 
            // FormInvoices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInvoices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoices";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSale).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel4;
        private Label label10;
        private Label lblMethod;
        private Panel panel3;
        private Label label7;
        private Label lblSalesBy;
        private Panel panel6;
        private Panel panel8;
        private Label lblChange;
        private Label label11;
        private Panel panel7;
        private Label label8;
        private Label lblGiven;
        private Panel panel5;
        private Label lblGrand;
        private Label label5;
        private Label lblTime;
        private Label label4;
        private Label lblSaleId;
        private Label label2;
        private Label label1;
        private Label label9;
        private Button btnBack;
        private DataGridView dgvSale;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn QuantitySold;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Total;
        private Button btnPrint;
    }
}