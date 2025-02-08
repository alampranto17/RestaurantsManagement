using System;
using System.Data;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormEditExpense : Form
    {
        public static bool isOpen = false;
        private DataAccess Da { get; set; }
        private FormExpense FrmExp { get; set; }

        DataRow currentUser;

        public FormEditExpense()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            isOpen = true;
        }

        public FormEditExpense(string expenseId, FormExpense frmExp, DataRow row) : this()
        {
            this.FrmExp = frmExp;
            this.ShowExpense(expenseId);
            this.currentUser = row;
            
        }

        public void ClearAll()
        {
            this.txtAmount.Clear();
            this.txtDescription.Clear();
            this.cboCategory.SelectedIndex = -1;
            this.dtpDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            this.dtpTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ShowExpense(string expenseId)
        {
            try
            {
                string query = $"SELECT * FROM Expenses WHERE ExpenseId = '{expenseId}'";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count > 0)
                {
                    this.txtExpenseId.Text = dt.Rows[0]["ExpenseID"].ToString();
                    this.txtAmount.Text = dt.Rows[0]["Amount"].ToString();
                    this.cboCategory.Text = dt.Rows[0]["Category"].ToString();
                    this.txtDescription.Text = dt.Rows[0]["Description"].ToString();

                    DateTime fullDateTime = Convert.ToDateTime(dt.Rows[0]["ExpenseDate"]);
                    this.dtpDate.Value = fullDateTime;
                    this.dtpTime.Text = fullDateTime.ToString("HH:mm:ss");
                }
                else
                {
                    MessageBox.Show("Expense not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsValid()
        {
            if (this.cboCategory.SelectedIndex == -1 || string.IsNullOrEmpty(this.txtDescription.Text))
            {
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(this.txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive numerical amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (this.txtDescription.Text.Length > 100)
            {
                MessageBox.Show("Description cannot exceed 100 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (!this.IsValid()) return;

            string id = this.txtExpenseId.Text;
            string description = this.txtDescription.Text;
            decimal amount = Convert.ToDecimal(this.txtAmount.Text);
            string category = this.cboCategory.SelectedItem.ToString();
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string time = dtpTime.Value.ToString("HH:mm:ss");
            string dateTime = $"{date} {time}";

            try
            {
                string sql = $@"UPDATE Expenses
                                SET ExpenseDate = '{dateTime}',
                                    Category = '{category}',
                                    Description = '{description}',
                                    Amount = {amount},
                                    CreatedBy = '{currentUser["Name"]}'
                                WHERE ExpenseID = '{id}'";

                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt > 0)
                {
                    MessageBox.Show($"Expense ID {id} has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    this.ClearAll();
                    this.FrmExp.ClearAll();
                    this.FrmExp.Visible = true;
                    isOpen = false;
                }
                else
                {
                    MessageBox.Show($"Failed to update Expense ID {id}. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.FrmExp.ClearAll();
            this.FrmExp.Visible = true;
            this.FrmExp.PopulateGridViewOnAction();
            this.Visible = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
