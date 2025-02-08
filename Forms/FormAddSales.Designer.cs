namespace Forms
{
    partial class FormAddSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSales));
            lblSaleId = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtChange = new TextBox();
            txtGiven = new TextBox();
            btnClear = new Button();
            btnCancel = new Button();
            bntConfirm = new Button();
            dgvAddedItems = new DataGridView();
            ItemId = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            PricePerUnit = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            RemoveAction = new DataGridViewButtonColumn();
            lblGrand = new Label();
            label5 = new Label();
            dgvMenuItems = new DataGridView();
            FoodID = new DataGridViewTextBoxColumn();
            FoodName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            StockQuantity = new DataGridViewTextBoxColumn();
            AddAction = new DataGridViewButtonColumn();
            panel2 = new Panel();
            panel5 = new Panel();
            lblWlcName = new Label();
            label9 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAddedItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSaleId
            // 
            lblSaleId.AutoSize = true;
            lblSaleId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaleId.ForeColor = Color.Black;
            lblSaleId.Location = new Point(85, 16);
            lblSaleId.Name = "lblSaleId";
            lblSaleId.Size = new Size(80, 21);
            lblSaleId.TabIndex = 63;
            lblSaleId.Text = "SALE-001";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 16);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 62;
            label4.Text = "Sale ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(160, 372);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 61;
            label3.Text = "Change:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(160, 340);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 60;
            label2.Text = "Given Amount:";
            // 
            // txtChange
            // 
            txtChange.BackColor = SystemColors.Info;
            txtChange.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChange.Location = new Point(286, 372);
            txtChange.Name = "txtChange";
            txtChange.PlaceholderText = "Change";
            txtChange.Size = new Size(127, 27);
            txtChange.TabIndex = 59;
            // 
            // txtGiven
            // 
            txtGiven.BackColor = SystemColors.Info;
            txtGiven.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiven.Location = new Point(287, 340);
            txtGiven.Name = "txtGiven";
            txtGiven.PlaceholderText = "Given Amount";
            txtGiven.Size = new Size(128, 27);
            txtGiven.TabIndex = 5;
            txtGiven.TextChanged += txtGiven_TextChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(170, 435);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 42);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 50, 49);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(39, 435);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 42);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // bntConfirm
            // 
            bntConfirm.BackColor = Color.Green;
            bntConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntConfirm.ForeColor = Color.White;
            bntConfirm.Location = new Point(301, 435);
            bntConfirm.Name = "bntConfirm";
            bntConfirm.Size = new Size(114, 42);
            bntConfirm.TabIndex = 11;
            bntConfirm.Text = "Confirm";
            bntConfirm.UseVisualStyleBackColor = false;
            bntConfirm.Click += bntConfirm_Click;
            // 
            // dgvAddedItems
            // 
            dgvAddedItems.AllowUserToAddRows = false;
            dgvAddedItems.AllowUserToDeleteRows = false;
            dgvAddedItems.AllowUserToOrderColumns = true;
            dgvAddedItems.BackgroundColor = SystemColors.HighlightText;
            dgvAddedItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddedItems.Columns.AddRange(new DataGridViewColumn[] { ItemId, ItemName, PricePerUnit, Quantity, Total, RemoveAction });
            dgvAddedItems.Location = new Point(12, 50);
            dgvAddedItems.Name = "dgvAddedItems";
            dgvAddedItems.ReadOnly = true;
            dgvAddedItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAddedItems.Size = new Size(399, 242);
            dgvAddedItems.TabIndex = 0;
            dgvAddedItems.CellContentClick += dgvAddedItems_CellContentClick;
            // 
            // ItemId
            // 
            ItemId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemId.DataPropertyName = "ItemId";
            ItemId.HeaderText = "Food ID";
            ItemId.Name = "ItemId";
            ItemId.ReadOnly = true;
            // 
            // ItemName
            // 
            ItemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemName.DataPropertyName = "ItemName";
            ItemName.HeaderText = "Food Name";
            ItemName.Name = "ItemName";
            ItemName.ReadOnly = true;
            // 
            // PricePerUnit
            // 
            PricePerUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PricePerUnit.DataPropertyName = "Price";
            PricePerUnit.HeaderText = "Price ";
            PricePerUnit.Name = "PricePerUnit";
            PricePerUnit.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // RemoveAction
            // 
            RemoveAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RemoveAction.HeaderText = "";
            RemoveAction.Name = "RemoveAction";
            RemoveAction.ReadOnly = true;
            RemoveAction.Text = "Remove";
            RemoveAction.UseColumnTextForButtonValue = true;
            // 
            // lblGrand
            // 
            lblGrand.AutoSize = true;
            lblGrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrand.ForeColor = Color.Black;
            lblGrand.Location = new Point(285, 309);
            lblGrand.Name = "lblGrand";
            lblGrand.Size = new Size(27, 21);
            lblGrand.TabIndex = 58;
            lblGrand.Text = "TK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(160, 309);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 57;
            label5.Text = "Grand Total:";
            // 
            // dgvMenuItems
            // 
            dgvMenuItems.AllowUserToAddRows = false;
            dgvMenuItems.AllowUserToDeleteRows = false;
            dgvMenuItems.BackgroundColor = SystemColors.HighlightText;
            dgvMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuItems.Columns.AddRange(new DataGridViewColumn[] { FoodID, FoodName, Price, StockQuantity, AddAction });
            dgvMenuItems.Location = new Point(13, 116);
            dgvMenuItems.Name = "dgvMenuItems";
            dgvMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenuItems.Size = new Size(594, 280);
            dgvMenuItems.TabIndex = 0;
            dgvMenuItems.CellContentClick += dgvMenuItems_CellContentClick;
            // 
            // FoodID
            // 
            FoodID.DataPropertyName = "FoodId";
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
            StockQuantity.HeaderText = "Stock";
            StockQuantity.Name = "StockQuantity";
            StockQuantity.ReadOnly = true;
            // 
            // AddAction
            // 
            AddAction.HeaderText = "";
            AddAction.Name = "AddAction";
            AddAction.ReadOnly = true;
            AddAction.Resizable = DataGridViewTriState.True;
            AddAction.SortMode = DataGridViewColumnSortMode.Automatic;
            AddAction.Text = "Add";
            AddAction.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(186, 216, 182);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label9);
            panel2.ForeColor = Color.DarkSlateGray;
            panel2.Location = new Point(12, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(1059, 56);
            panel2.TabIndex = 55;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblWlcName);
            panel5.Location = new Point(643, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 35);
            panel5.TabIndex = 4;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(9, 9);
            label9.Name = "label9";
            label9.Size = new Size(222, 38);
            label9.TabIndex = 1;
            label9.Text = "Add New Sale";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(txtSearch);
            panel6.Controls.Add(dgvMenuItems);
            panel6.Location = new Point(12, 76);
            panel6.Name = "panel6";
            panel6.Size = new Size(628, 497);
            panel6.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(13, 428);
            label7.Name = "label7";
            label7.Size = new Size(607, 20);
            label7.TabIndex = 5;
            label7.Text = "Instruction: Double-click on the 'Quantity' column to select the desired quantity, then click 'Add'.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 17F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(277, 16);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 4;
            label1.Text = "List of Foods";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(13, 59);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Serach by Food Name";
            txtSearch.Size = new Size(318, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblSaleId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtChange);
            panel1.Controls.Add(txtGiven);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(bntConfirm);
            panel1.Controls.Add(dgvAddedItems);
            panel1.Controls.Add(lblGrand);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(646, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 497);
            panel1.TabIndex = 57;
            // 
            // FormAddSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 577);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAddSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Sales";
            FormClosed += FormAddSales_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvAddedItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSaleId;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtChange;
        private TextBox txtGiven;
        private Button btnClear;
        private Button btnCancel;
        private Button bntConfirm;
        private DataGridView dgvAddedItems;
        private Label lblGrand;
        private Label label5;
        private DataGridView dgvMenuItems;
        private Panel panel2;
        private Panel panel5;
        private Label lblWlcName;
        private Label label9;
        private Panel panel6;
        private Label label7;
        private Label label1;
        private TextBox txtSearch;
        private Panel panel1;
        private DataGridViewTextBoxColumn FoodID;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn StockQuantity;
        private DataGridViewButtonColumn AddAction;
        private DataGridViewTextBoxColumn ItemId;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn PricePerUnit;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn RemoveAction;
    }
}