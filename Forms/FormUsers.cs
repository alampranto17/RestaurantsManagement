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
    public partial class FormUsers : Form
    {
        public static bool isOpen = false;
        private DataAccess Da { get; set; }
        private DataRow currentUser;
        public FormUsers()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.cboUserType.SelectedIndex = 0;
            this.ShowInitialInfo();
        }

        public FormUsers(DataRow currentUser) : this()
        {
            this.currentUser = currentUser;
            this.lblWlcName.Text = "Welcome, " + currentUser["Name"];
        }

        public void PopulateGridView(string query = "SELECT * FROM Users")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(query);
                this.dgvUser.AutoGenerateColumns = false;
                this.dgvUser.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void PopulateGridViewOnAction()
        {
            string part = "";
            bool hasText = !string.IsNullOrEmpty(this.txtSearch.Text);
            int hasUserType = this.cboUserType.SelectedIndex;


            if (hasText)
            {
                part = $"WHERE Name LIKE '%{this.txtSearch.Text}%'";
            }


            if (hasUserType == 1)
            {
                part += (hasText ? " AND " : "WHERE ");
                part += $"Role = '{this.cboUserType.SelectedItem.ToString()}'";
            }
            else if (hasUserType == 2)
            {
                part += (hasText ? " AND " : "WHERE ");
                part += $"Role <> 'Admin'";
            }

            string query = $"SELECT * FROM Users {part}";
            this.PopulateGridView(query);
        }


        public void ShowInitialInfo()
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable("SELECT * FROM Users");
                int adminCnt = 0, empCnt = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Role"].ToString() == "Admin") adminCnt++;
                    else empCnt++;
                }
                //MessageBox.Show(adminCnt.ToString() + " " + empCnt.ToString());
                this.lblTotal.Text = (adminCnt + empCnt).ToString("D2");
                this.lblAdmin.Text = adminCnt.ToString("D2");
                this.lblEmp.Text = empCnt.ToString("D2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearAll()
        {
            this.txtSearch.Clear();
            this.cboUserType.SelectedIndex = 0;
            this.PopulateGridView();
            this.ShowInitialInfo();
        }


        public void DeleteUser(string userId)
        {
            string name = this.dgvUser.CurrentRow.Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to delete {name}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                string sql = $"DELETE FROM Users WHERE UserId = '{userId}'";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt == 1)
                {
                    MessageBox.Show($"{name} has been successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show($"Failed to remove {name}. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void AfterEdit(string userId)
        {
            

            try
            {
                string query = $"SELECT * FROM Users WHERE UserId = '{userId}'";
                DataTable dt = this.Da.ExecuteQueryTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("User data could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                currentUser = dt.Rows[0];

                // Update welcome label
                this.Invoke((MethodInvoker)delegate
                {
                    if (currentUser["Name"] != null)
                    {
                        this.lblWlcName.Text = "Welcome, " + currentUser["Name"].ToString();
                    }
                    else
                    {
                        this.lblWlcName.Text = "Welcome, User";
                    }
                    this.lblWlcName.Refresh();
                });

                // Check and handle role change
                if (currentUser["Role"] != null && currentUser["Role"].ToString() != "Admin")
                {
                    MessageBox.Show(
                        "Your status has been changed to 'Manager'. Please log in again with your new role.",
                        "Status Updated",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    if (!FrmLogin.isOpen)
                    {
                        new FrmLogin().Show();
                        this.Hide();
                        FrmLogin.isOpen = true;
                        isOpen = false;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cboUserType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // edit
            if (e.RowIndex >= 0 && dgvUser.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvUser.Columns[e.ColumnIndex].Name == "EditAction")
            {
                // edit operations
                //MessageBox.Show("Edit Form");
                if (this.dgvUser.SelectedRows.Count > 0)
                {
                    if (FormEditUser.isOpen)
                        return;
                    string userId = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
                    //this.Visible = false;
                    new FormEditUser(userId, this).Show();
                }
            }

            // delete
            if (e.RowIndex >= 0 && dgvUser.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvUser.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                // delete operations
                //MessageBox.Show(this.dgvInventory.CurrentRow.Cells[0].Value.ToString());
                if (this.dgvUser.SelectedRows.Count > 0)
                {
                    string userId = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
                    this.DeleteUser(userId);
                }
            }
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            this.dgvUser.ClearSelection();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!FormAddUser.isOpen)
            {
                new FormAddUser(this).Visible = true;
            }
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnExpense_Click(object sender, EventArgs e)
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

        private void FormUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

