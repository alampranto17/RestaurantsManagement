using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormExpense : Form
    {
        public static bool isOpen = false;
        DataRow currentUser;
        DataAccess Da;
        public FormExpense()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ShowInitialInfo();
            this.PopulateGridView();
            this.dtpStartDate.Text = (new DateTime(2015, 1, 1)).ToString();
            this.dtpEndDate.Text = DateTime.Now.ToString();
        }

        public FormExpense(DataRow row) : this()
        {
            this.currentUser = row;
            lblWlcName.Text = "Welcome ," + currentUser["Name"];

        }

        public void PopulateGridView(string query = "SELECT * FROM Expenses ORDER BY ExpenseDate DESC")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(query);
                dt.Columns.Add("Date", typeof(string));
                dt.Columns.Add("Time", typeof(string));
                dt.Columns.Add("CreatedByName", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    DateTime fullDateTime = Convert.ToDateTime(row["ExpenseDate"]);
                    row["Date"] = fullDateTime.ToString("dd-MM-yyyy");
                    row["Time"] = fullDateTime.ToString("hh:mm tt");
                    DataTable dt2 = this.Da.ExecuteQueryTable($"SELECT Name FROM Users WHERE UserId = '{row["CreatedBy"]}'");

                }
                this.dgvExpense.AutoGenerateColumns = false;
                this.dgvExpense.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopulateGridViewOnAction()
        {
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59");
            string part = "";
            if (!this.txtSearch.Text.IsNullOrEmpty())
                part = $"Category LIKE '%{this.txtSearch.Text}%' AND ";
            string query = $"SELECT * FROM Expenses WHERE {part} ExpenseDate BETWEEN '{startDate}' AND '{endDate}' ORDER BY ExpenseDate DESC;";
            this.PopulateGridView(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            this.PopulateGridViewOnAction();
            this.ShowInitialInfo();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            
            this.PopulateGridViewOnAction();
            this.ShowInitialInfo();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            
            this.PopulateGridViewOnAction();
            this.ShowInitialInfo();
        }

        public void ClearAll()
        {
            this.txtSearch.Clear();
            this.ShowInitialInfo();
            this.PopulateGridView();
            this.dtpStartDate.Text = (new DateTime(2015, 1, 1)).ToString();
            this.dtpEndDate.Text = DateTime.Now.ToString();
        }

        public DataTable GetExpenses(string startDate, string endDate)
        {
            string query = $"SELECT * FROM Expenses WHERE ExpenseDate BETWEEN '{startDate}' AND '{endDate}';";
            return this.Da.ExecuteQueryTable(query);
        }

        public DataTable GetTodaysExpenses()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string startDate = today + " 00:00:00";
            string endDate = today + " 23:59:59";
            return GetExpenses(startDate, endDate);
        }

        public DataTable GetThisWeeksExpenses()
        {
            DateTime today = DateTime.Now;
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek - 1);
            DateTime endOfWeek = startOfWeek.AddDays(6);
            string startDate = startOfWeek.ToString("yyyy-MM-dd") + " 00:00:00";
            string endDate = endOfWeek.ToString("yyyy-MM-dd") + " 23:59:59";
            return GetExpenses(startDate, endDate);
        }

        public DataTable GetThisYearsExpenses()
        {
            DateTime today = DateTime.Now;
            DateTime startOfYear = new DateTime(today.Year, 1, 1);
            DateTime endOfYear = new DateTime(today.Year, 12, 31);
            string startDate = startOfYear.ToString("yyyy-MM-dd") + " 00:00:00";
            string endDate = endOfYear.ToString("yyyy-MM-dd") + " 23:59:59";
            return GetExpenses(startDate, endDate);
        }

        public void ShowInitialInfo()
        {
            try
            {
                decimal totalExpense = 0;

                // Today's expenses
                DataTable dt = this.GetTodaysExpenses();
                totalExpense = dt.AsEnumerable().Sum(row => row.Field<decimal>("Amount"));
                this.lblThisDay.Text = $"{totalExpense.ToString("F2")} TK";

                // This week's expenses
                dt = this.GetThisWeeksExpenses();
                totalExpense = dt.AsEnumerable().Sum(row => row.Field<decimal>("Amount"));
                this.lblThisWeeK.Text = $"{totalExpense.ToString("F2")} TK";

                //this year's 
                dt = this.GetThisYearsExpenses();
                decimal tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr["Amount"]);
                this.lblThisYear.Text = $"{tot.ToString("F2")} TK";

                // Between selected dates
                string startDate = this.dtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00");
                string endDate = this.dtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59");
                dt = this.GetExpenses(startDate, endDate);
                tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr["Amount"]);
                this.lblThisYear.Text = $"{tot.ToString("F2")} TK";
                this.lblStartDate.Text = this.dtpStartDate.Value.ToString("dd-MM-yyyy");
                this.lblEndDate.Text = this.dtpEndDate.Value.ToString("dd-MM-yyyy");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteExpense(string expenseId)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete expense ID {expenseId}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                string sql = $"DELETE FROM Expenses WHERE ExpenseId = '{expenseId}'";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt == 1)
                {
                    MessageBox.Show($"Expense ID {expenseId} has been successfully removed.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show($"Failed to remove Expense ID {expenseId}.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvExpense.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvExpense.Columns[e.ColumnIndex].Name == "EditAction")
            {
                if (this.dgvExpense.SelectedRows.Count > 0)
                {
                    if (FormEditExpense.isOpen == true)
                        return;
                    string expenseId = this.dgvExpense.CurrentRow.Cells[0].Value.ToString();
                    new FormEditExpense(expenseId, this, currentUser).Show();
                }
            }

            if (e.RowIndex >= 0 && dgvExpense.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvExpense.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                if (this.dgvExpense.SelectedRows.Count > 0)
                {
                    string expenseId = this.dgvExpense.CurrentRow.Cells[0].Value.ToString();
                    this.DeleteExpense(expenseId);
                }
            }
        }

        private void FormExpense_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {

            if (!FrmAdminDashboard.isOpen)
            {
                FrmAdminDashboard.isOpen = true;
                new FrmAdminDashboard(currentUser).Show();
                this.Hide();
                isOpen = false;
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }
        }

        private void btnManu_Click(object sender, EventArgs e)
        {

            if (!FormManuOfFood.isOpen)
            {
                FormManuOfFood.isOpen = true;
                new FormManuOfFood(currentUser).Show();
                this.Hide();
                isOpen = false;
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {

            if (!FormSales.isOpen)
            {
                FormSales.isOpen = true;
                new FormSales(currentUser).Show();
                this.Hide();
                isOpen = false;
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            if (!FormUsers.isOpen)
            {
                FormUsers.isOpen = true;
                new FormUsers(currentUser).Show();
                this.Hide();
                isOpen = false;
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (!FrmLogin.isOpen)
            {
                new FrmLogin().Show();

                isOpen = false;
                FrmLogin.isOpen = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!FormAddExpense.isOpen)
            {
                new FormAddExpense(this, currentUser).Show();
                FormAddExpense.isOpen = true;

            }

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            if (!FormAttendance.isOpen)
            {
                new FormAttendance(currentUser).Show();
                FormAttendance.isOpen = true;

                this.Hide();
                isOpen = false;
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }
        }
    }
}
