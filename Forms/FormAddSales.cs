using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormAddSales : Form
    {
        public static bool isOpen = false;
        private DataAccess Da { get; set; }
        private DataTable addedMenuItemsTable;
        private decimal grandTotal;
        private DataRow currentUser;
        private FormSales FormSales;
        private FormManagerDashboard FormManagerDashboard
        {
            get; set;
        }

        private string who = "";



        public FormAddSales()
        {
            InitializeComponent();


            this.Da = new DataAccess();
            this.PopulateGridView();
            this.addedMenuItemsTable = new DataTable();
            this.addedMenuItemsTable.Columns.Add("ItemId", typeof(string));
            this.addedMenuItemsTable.Columns.Add("ItemName", typeof(string));
            this.addedMenuItemsTable.Columns.Add("Price", typeof(decimal));
            this.addedMenuItemsTable.Columns.Add("Quantity", typeof(decimal));
            this.addedMenuItemsTable.Columns.Add("Total", typeof(decimal));
            this.ShowGrandTotal();
            this.GenerateId();
            isOpen = true;
        }

        //admin
        public FormAddSales(DataRow currentUser, FormSales frmSls) : this()
        {
            this.currentUser = currentUser;
            this.FormSales = frmSls;
            this.lblWlcName.Text = "Welcome, " + currentUser["Name"].ToString();
            this.who = currentUser["Name"].ToString();

        }

        //employee
        public FormAddSales(DataRow currentUser, FormManagerDashboard frmmagDashboard) : this()
        {
            this.currentUser = currentUser;
            this.FormManagerDashboard = frmmagDashboard;
            this.lblWlcName.Text = "Welcome, " + currentUser["Name"].ToString();
            this.who = $"{currentUser["Name"]}";

        }

        public void GenerateId()
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable("SELECT MAX(SaleId) FROM Sales");
                if (dt.Rows[0][0] == DBNull.Value)
                {
                    this.lblSaleId.Text = "SALE-001";
                    return;
                }
                string[] temp = dt.Rows[0][0].ToString().Split("-");
                int id = Convert.ToInt32(temp[1]) + 1;
                this.lblSaleId.Text = $"S-{id:D3}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopulateGridView(string query = "SELECT * FROM Manu;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(query);
                this.dgvMenuItems.AutoGenerateColumns = false;
                this.dgvMenuItems.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void ShowGrandTotal()
        {
            decimal total = 0;
            foreach (DataRow row in this.addedMenuItemsTable.Rows)
            {
                total += Convert.ToDecimal(row["Total"]);
            }
            this.lblGrand.Text = total.ToString("F2") + " TK";
            this.grandTotal = total;
        }

        public void ClearAll()
        {
            this.txtSearch.Clear();
            this.PopulateGridView();
            this.addedMenuItemsTable.Clear();
            this.dgvAddedItems.AutoGenerateColumns = false;
            this.dgvAddedItems.DataSource = addedMenuItemsTable;
            this.ShowGrandTotal();
            this.txtGiven.Clear();
            this.txtChange.Clear();
            this.GenerateId();

        }


        private void txtGiven_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(this.txtGiven.Text, out decimal givenAmount) && givenAmount > 0)
            {
                this.txtChange.Text = (givenAmount - grandTotal).ToString("F2");
            }
            else
            {
                this.txtChange.Clear();
            }
        }

        private void dgvMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




            if (e.ColumnIndex == dgvMenuItems.Columns["AddAction"].Index && e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvMenuItems.Rows[e.RowIndex];
                    string foodId = row.Cells["FoodID"].Value.ToString();
                    string foodName = row.Cells["FoodName"].Value.ToString();
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    decimal quantity = 1; // Default quantity to 1
                    decimal total = price * quantity;

                    // Check stock availability
                    DataRow menuRow = ((DataTable)dgvMenuItems.DataSource).Rows[e.RowIndex];
                    decimal availableStock = Convert.ToDecimal(menuRow["Quantity"]);
                    if (availableStock < quantity)
                    {
                        MessageBox.Show("Not enough stock available for this item.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the item already exists in the cart
                    DataRow existingRow = addedMenuItemsTable.Rows
                        .Cast<DataRow>()
                        .FirstOrDefault(r => r["ItemId"].ToString() == foodId);

                    if (existingRow != null)
                    {
                        // Update quantity and total for existing row
                        decimal existingQuantity = Convert.ToDecimal(existingRow["Quantity"]);
                        existingRow["Quantity"] = existingQuantity + quantity;
                        existingRow["Total"] = (existingQuantity + quantity) * price;
                    }
                    else
                    {
                        // Add a new row to the cart
                        DataRow newRow = addedMenuItemsTable.NewRow();
                        newRow["ItemId"] = foodId;
                        newRow["ItemName"] = foodName;
                        newRow["Price"] = price;
                        newRow["Quantity"] = quantity;
                        newRow["Total"] = total;
                        addedMenuItemsTable.Rows.Add(newRow);
                    }

                    // Update stock
                    menuRow["Quantity"] = availableStock - quantity;

                    // Refresh DataGridView and Grand Total
                    this.dgvAddedItems.AutoGenerateColumns = false;
                    this.dgvAddedItems.DataSource = addedMenuItemsTable;
                    ShowGrandTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the item to the cart: {ex.Message}", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void dgvAddedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is valid and on the Remove button column
            if (e.RowIndex >= 0 && dgvAddedItems.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvAddedItems.Columns[e.ColumnIndex].Name == "RemoveAction")
            {
                try
                {
                    // Get the ItemId of the row to remove
                    string itemId = dgvAddedItems.Rows[e.RowIndex].Cells["ItemId"].Value.ToString();
                    int rowIndex = e.RowIndex; // e.RowIndex gives the row that triggered the event

                    // Find the corresponding row in the addedMenuItemsTable (DataTable)
                    DataRow rowToRemove = addedMenuItemsTable.Rows[rowIndex];

                    if (rowToRemove != null)
                    {
                        // Update stock in dgvMenuItems
                        decimal quantityToReturn = Convert.ToDecimal(rowToRemove["Quantity"]);
                        foreach (DataGridViewRow menuRow in dgvMenuItems.Rows)
                        {
                            if (menuRow.Cells["FoodID"].Value.ToString() == itemId)
                            {
                                decimal availableStock = Convert.ToDecimal(menuRow.Cells["StockQuantity"].Value);
                                menuRow.Cells["StockQuantity"].Value = availableStock + quantityToReturn;
                                break;
                            }
                        }

                        // Remove the row from addedMenuItemsTable
                        addedMenuItemsTable.Rows.Remove(rowToRemove);

                        // Refresh dgvAddedItems
                        dgvAddedItems.DataSource = null;
                        dgvAddedItems.DataSource = addedMenuItemsTable;

                        // Update Grand Total
                        ShowGrandTotal();
                    }
                    else
                    {
                        MessageBox.Show("Item not found in the cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bntConfirm_Click(object sender, EventArgs e)
        {
            // Check if there are any items in the cart
            if (this.addedMenuItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add items to the cart before confirming the sale.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate the given amount
            if (!decimal.TryParse(this.txtGiven.Text, out decimal givenAmount) || givenAmount < grandTotal)
            {
                MessageBox.Show("The given amount must be greater than or equal to the total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string saleId = this.lblSaleId.Text;

            try
            {
                // Save the sale to the Sales table
                string saleQuery = $@"INSERT INTO Sales (SaleID, SaleDate, TotalAmount, GivenAmount, ChangeAmount, SalesmanName) 
                              VALUES ('{saleId}', '{DateTime.Now}', {grandTotal}, {givenAmount}, {givenAmount - grandTotal}, '{who}')";
                this.Da.ExecuteDMLQuery(saleQuery);

                // Save sale details and update stock
                foreach (DataRow row in addedMenuItemsTable.Rows)
                {
                    string foodId = row["ItemId"].ToString();
                    int quantitySold = Convert.ToInt32(row["Quantity"]);

                    // Insert sale details
                    string itemQuery = $@"INSERT INTO SaleDetails (SaleID, FoodID, QuantitySold) 
                                   VALUES ('{saleId}', '{foodId}', {quantitySold})";
                    this.Da.ExecuteDMLQuery(itemQuery);

                    // Update stock in manu table
                    string stockUpdateQuery = $@"UPDATE manu 
                                          SET Quantity = Quantity - {quantitySold} 
                                          WHERE FoodID = '{foodId}' AND Quantity >= {quantitySold}";
                    int rowsAffected = this.Da.ExecuteDMLQuery(stockUpdateQuery);

                    if (rowsAffected == 0)
                    {
                        throw new Exception($"Insufficient stock for FoodID '{foodId}'.");
                    }
                }

                // Provide feedback to the user
                MessageBox.Show("Sale successfully added and stock updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearAll();
                new FormInvoices(saleId).Show();
                FormInvoices.isOpen = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = this.txtSearch.Text.Trim();

            // Base query for manu search by FoodName
            string query = @"SELECT * 
                     FROM manu";

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += $@" WHERE FoodName LIKE '%{searchTerm}%'";
            }



            // Populate the DataGridView with the filtered data
            this.PopulateGridView(query);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (FormManagerDashboard != null)
            {
                this.Hide();
                isOpen = false;
                FormManagerDashboard.Show();
                this.ClearAll();
                return;
            }



            if (!FormSales.isOpen)
            {
                new FormSales(currentUser).Show();
                this.ClearAll();
                isOpen = false;
                FormSales.isOpen = true;
                this.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void FormAddSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

