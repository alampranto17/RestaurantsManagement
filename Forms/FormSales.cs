using Microsoft.IdentityModel.Tokens;
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
    public partial class FormSales : Form
    {
        public static bool isOpen = false;
        private DataAccess da;
        private DataRow currentUser;
        public FormSales()
        {
            InitializeComponent();
            da = new DataAccess();
            this.PopulateGridView();
            this.ShowInitialInfo();
            this.ClearAll();

        }

        public FormSales(DataRow row) : this()
        {
            currentUser = row;
            lblWlcName.Text = "Welcome ," + currentUser["Name"];
        }

        public void PopulateGridView(string query = "SELECT * From Sales ORDER BY SaleDate DESC;")
        {
            try
            {

                DataTable dt = this.da.ExecuteQueryTable(query);



                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for the given search criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvSale.DataSource = null; // Clear gridview if no data
                    return;
                }

                this.dgvSale.AutoGenerateColumns = false;
                this.dgvSale.DataSource = dt;



            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopulateGridViewOnAction()
        {

            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            string part = "";

            if (!this.txtSearch.Text.IsNullOrEmpty())
                part = $"SalesmanName LIKE '%{this.txtSearch.Text}%' AND ";

            string query = $@"SELECT * From Sales
                       WHERE {part} CONVERT(DATE, SaleDate)BETWEEN '{startDate}' AND '{endDate}'
                      ORDER BY SaleDate DESC;";


            


            PopulateGridView(query);
        }



        public void ShowInitialInfo()
        {
            try
            {
                // Today's sales
                DataTable dt = this.GetTodaysSales();
                decimal tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr["TotalAmount"]);
                this.lblThisDay.Text = $"{tot.ToString("F2")} TK";

                // This week's sales
                dt = this.GetThisWeeksSales();
                tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr["TotalAmount"]);
                this.lblThisWeeK.Text = $"{tot.ToString("F2")} TK";


                // This year's sales
                dt = this.GetThisYearsSales();
                tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr["TotalAmount"]);
                this.lblBetweenDates.Text = $"{tot.ToString("F2")} TK";

                // Between selected dates
                string startDate = this.dtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00");
                string endDate = this.dtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59");
                dt = this.GetSales(startDate, endDate);
                tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr["TotalAmount"]);
                this.lblBetweenDates.Text = $"{tot.ToString("F2")} TK";
                this.lblStartDate.Text = this.dtpStartDate.Value.ToString("dd-MM-yyyy");
                this.lblEndDate.Text = this.dtpEndDate.Value.ToString("dd-MM-yyyy");
                this.dgvSale.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            this.dtpStartDate.Text = (new DateTime(2015, 1, 1)).ToString();
            this.dtpEndDate.Text = DateTime.Now.ToString();
            this.txtSearch.Clear();
            this.ShowInitialInfo();
            this.PopulateGridView();
            this.dgvSale.ClearSelection();
        }

        public DataTable GetSales(string startDate, string endDate)
        {

            string query = $"SELECT * FROM Sales WHERE SaleDate BETWEEN '{startDate}' AND '{endDate}';";


            return this.da.ExecuteQueryTable(query);
        }


        public DataTable GetTodaysSales()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string startDate = today + " 00:00:00";
            string endDate = today + " 23:59:59";

            return GetSales(startDate, endDate);
        }

        public DataTable GetThisWeeksSales()
        {
            DateTime today = DateTime.Now;
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek + 1); // Adjust based on desired week start
            DateTime endOfWeek = startOfWeek.AddDays(6);
            string startDate = startOfWeek.ToString("yyyy-MM-dd") + " 00:00:00";
            string endDate = endOfWeek.ToString("yyyy-MM-dd") + " 23:59:59";

            return GetSales(startDate, endDate);
        }

        public DataTable GetThisYearsSales()
        {
            DateTime today = DateTime.Now;
            DateTime startOfYear = new DateTime(today.Year, 1, 1);
            DateTime endOfYear = new DateTime(today.Year, 12, 31);
            string startDate = startOfYear.ToString("yyyy-MM-dd") + " 00:00:00";
            string endDate = endOfYear.ToString("yyyy-MM-dd") + " 23:59:59";

            return GetSales(startDate, endDate);
        }



        private void FormSales_Load(object sender, EventArgs e)
        {
            this.ClearAll();
            this.ShowInitialInfo();
        }

        private void FormSales_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Refresh();
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


        //delete query
        public void DeleteSale(string saleId)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete sale with ID: {saleId}?", "Delete Sale Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            try
            {
                // update stock first

                string sql = $@"DELETE SD
                                FROM SaleDetails SD
                                INNER JOIN Sales S ON SD.SaleID = S.SaleID
                                WHERE S.SaleID = '{saleId}';";
                int cnt = this.da.ExecuteDMLQuery(sql);
                sql = $@"DELETE S
                            FROM Sales S
                            WHERE S.SaleID = '{saleId}';";


                int snt = this.da.ExecuteDMLQuery(sql);
                if (cnt == 1 && snt == 1)
                {
                    MessageBox.Show($"Sale with ID: {saleId} has been successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show($"Failed to remove Sale with ID: {saleId}. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvSale.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvSale.Columns[e.ColumnIndex].Name == "Details")
            {
                //MessageBox.Show("Details");
                if (this.dgvSale.SelectedRows.Count > 0)
                {

                    string saleId = this.dgvSale.Rows[e.RowIndex].Cells["SaleId"].Value.ToString();

                    //this.Visible = false;

                    //MessageBox.Show("Details"+saleId);

                    if (!FormInvoices.isOpen)
                    {
                        FormInvoices.isOpen = true;
                        new FormInvoices(saleId, this).Show();
                    }
                }
            }

            // delete
            if (e.RowIndex >= 0 && dgvSale.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvSale.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                //MessageBox.Show("Delete");
                if (this.dgvSale.SelectedRows.Count > 0)
                {
                    string saleId = this.dgvSale.CurrentRow.Cells[0].Value.ToString();
                    this.DeleteSale(saleId);
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormAddSales(currentUser, this).Show();
            isOpen = false;
            FormAddSales.isOpen = true;
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }
    }
}
