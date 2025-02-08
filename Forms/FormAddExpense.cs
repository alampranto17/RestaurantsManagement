using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormAddExpense : Form
    {
        DataRow currentUser;
        DataAccess Da;
        public static bool isOpen = false;

        FormExpense FormExpense;

        private FormManagerDashboard FormManagerDashboard {  get; set; }
        public FormAddExpense()
        {
            InitializeComponent();
            Da = new DataAccess();
            this.GenerateId();
            this.dtpDate.MaxDate = DateTime.Today;
            this.dtpTime.MaxDate = DateTime.Now;
        }

        public FormAddExpense(FormExpense formExpense, DataRow row) : this()
        {
            this.FormExpense = formExpense;
            currentUser = row;
        }

        public FormAddExpense(FormManagerDashboard fm,DataRow row)
        {
            this.currentUser = row;
           this.FormManagerDashboard= fm;
        }

        public void GenerateId()
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable("SELECT MAX(ExpenseId) FROM Expenses");
                if (dt.Rows[0][0].ToString().IsNullOrEmpty())
                {
                    this.txtExpenseId.Text = "E-001";
                    return;
                }
                string[] temp = dt.Rows[0][0].ToString().Split("-");
                int id = Convert.ToInt32(temp[1]) + 1;
                this.txtExpenseId.Text = $"E-{id.ToString("D3")}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearAll()
        {
            this.GenerateId();
            this.txtAmount.Clear();
            this.cboCategory.SelectedIndex = -1;
            this.txtDescription.Clear();
            this.chkCurrentTime.Checked = true;
            this.dtpDate.Enabled = false;
            this.dtpTime.Enabled = false;
            this.dtpDate.MaxDate = DateTime.Today;
            this.dtpTime.MaxDate = DateTime.Now;
            this.dtpDate.Text = DateTime.Today.ToString();
            this.dtpTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(FormManagerDashboard!=null)
            {
                this.Visible = false;
                isOpen = false;
                this.ClearAll();
                FormManagerDashboard.Show();

                return;
            }


            this.Visible = false;
            isOpen = false;
            FormExpense.PopulateGridViewOnAction();
            FormExpense.ClearAll();
        }

        private void chkCurrentTime_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCurrentTime.Checked == true)
            {
                this.dtpDate.Enabled = false;
                this.dtpTime.Enabled = false;
            }
            else
            {
                this.dtpDate.Enabled = true;
                this.dtpTime.Enabled = true;
                this.dtpDate.MaxDate = DateTime.Today;
                this.dtpTime.MaxDate = DateTime.Now;
                this.dtpDate.Text = DateTime.Today.ToString();
                this.dtpTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            }
        }

        public bool IsValid()
        {
            string id = this.txtExpenseId.Text;
            string description = this.txtDescription.Text;

            if (this.cboCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category to proceed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string category = this.cboCategory.SelectedItem.ToString();

            if (description.IsNullOrEmpty())
            {
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal amount;
            bool isNumeric = decimal.TryParse(this.txtAmount.Text, out amount);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid numerical amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Amount must be a positive value.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (description.Length > 100)
            {
                MessageBox.Show("Description cannot exceed 100 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
                return;

            try
            {
                string id = this.txtExpenseId.Text;
                string description = this.txtDescription.Text;
                string category = this.cboCategory.SelectedItem.ToString();
                decimal amount = Convert.ToDecimal(this.txtAmount.Text);
                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                if (!this.chkCurrentTime.Checked)
                {
                    string date = dtpDate.Value.ToString("yyyy-MM-dd");
                    string time = dtpTime.Value.ToString("HH:mm:ss");
                    dateTime = $"{date} {time}";
                }

                string sql = $@"INSERT INTO Expenses
                     ([ExpenseID]
                    ,[ExpenseDate]
                    ,[Category]
                    ,[Description]
                    ,[Amount]
                    ,[CreatedBy])
                        VALUES
                    ('{id}','{dateTime}','{category}','{description}',{amount},'{currentUser["Name"]}')";

                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt > 0)
                {
                    MessageBox.Show($"Expense #{id} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.ClearAll();


                }
                else
                {
                    MessageBox.Show($"Failed to add Expense #{id}. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
