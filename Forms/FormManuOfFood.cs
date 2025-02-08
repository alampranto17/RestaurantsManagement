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
    public partial class FormManuOfFood : System.Windows.Forms.Form
    {
        private DataAccess da;
        DataRow currentUser;
        public static bool isOpen = false;



        public FormManuOfFood()
        {
            InitializeComponent();
            da = new DataAccess();
            PopulateGridView();
        }

        public FormManuOfFood(DataRow row) : this()
        {
            this.currentUser = row;

            lblWlcName.Text = "Welcome ," + currentUser["Name"];
        }

        public void PopulateGridView(string query = "SELECT * FROM Manu")
        {
            try
            {
                DataSet ds = this.da.ExecuteQuery(query);
                this.dgvFoodTable.AutoGenerateColumns = false;
                this.dgvFoodTable.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopulateGridViewOnAction()
        {
            string part = "";
            if (!this.txtSearch.Text.IsNullOrEmpty())
            {
                part = $"WHERE FoodName LIKE '%{this.txtSearch.Text}%'";
            }
            string query = $"SELECT * FROM Manu {part}";
            this.PopulateGridView(query);
        }

        public void ClearAll()
        {
            this.txtSearch.Clear();
            this.PopulateGridView();
        }

        public void DeleteFood(string FoodId)
        {
            string FoodName = this.dgvFoodTable.CurrentRow.Cells[1].Value.ToString();


            DialogResult result = MessageBox.Show($"Are you sure you want to delete {FoodName}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            string sql = $"DELETE FROM Manu WHERE FoodID = '{FoodId}'";
            int cnt = this.da.ExecuteDMLQuery(sql);
            if (cnt == 1)
            {
                MessageBox.Show($"{FoodName} has been removed successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PopulateGridViewOnAction();
            }
            else
            {
                MessageBox.Show($"Failed to remove {FoodName}. Please try again.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFoodTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // edit
            if (e.RowIndex >= 0 && dgvFoodTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvFoodTable.Columns[e.ColumnIndex].Name == "EditAction")
            {
                // edit operations
                //MessageBox.Show("Edit Form");
                if (this.dgvFoodTable.SelectedRows.Count > 0)
                {
                    //Check open or not 
                    string FoodId = this.dgvFoodTable.CurrentRow.Cells[0].Value.ToString();
                    new FormEditFood(this, FoodId).Visible = true;
                    //this.Visible = false;

                }
            }
            else if (e.RowIndex >= 0 && dgvFoodTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvFoodTable.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                // MessageBox.Show("Deleted message");
                string FoodId = this.dgvFoodTable.CurrentRow.Cells[0].Value.ToString();
                this.DeleteFood(FoodId);
            }

        }

        private void FormManuOfFood_Load(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!FormAddFood.isOpen)
            {
                FormAddFood.isOpen = true;
                new FormAddFood(this).Show();
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }



        }

        private void FormManuOfFood_FormClosed(object sender, FormClosedEventArgs e)
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
            this.Refresh();
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

        private void btnUsers_Click(object sender, EventArgs e)
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

        private void btnExpenses_Click(object sender, EventArgs e)
        {

            if (!FormExpense.isOpen)
            {
                FormExpense.isOpen = true;
                new FormExpense(currentUser).Show();
                this.Hide();
                isOpen = false;
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (!FrmLogin.isOpen)
            {
                new FrmLogin().Show();

                isOpen = false;
                FrmLogin.isOpen = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
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


