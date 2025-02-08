using Microsoft.Identity.Client;
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
    public partial class FrmAdminDashboard : System.Windows.Forms.Form
    {
        public static bool isOpen = false;
        DataRow currentUser
        {
            set; get;
        }





        DataAccess da;
        public FrmAdminDashboard()
        {
            InitializeComponent();
            da = new DataAccess();
            this.TotalProfit();
            this.TotalSale();
            this.totalExpense();
        }
        public FrmAdminDashboard(DataRow currentUser) : this()
        {

            this.currentUser = currentUser;

            lblWlcName.Text = "Welcome ," + currentUser["Name"];
        }


        public string TotalProfit()
        {
            string total = "";
            try
            {

                LblProfit.Text = Convert.ToString(Convert.ToDecimal(this.TotalSale()) -Convert.ToDecimal(this.totalExpense()));
                LblProfit.Text += " TK";



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            return total;

        }


        public string TotalSale()
        {

           
                string sql = $@"SELECT 
                        SUM(Sales.TotalAmount) AS Sales
                        FROM 
                    Sales;";
                DataTable dt = da.ExecuteQueryTable(sql);
                DataRow dr = dt.Rows[0];
                lblSale.Text = dr["Sales"].ToString();
                

                return lblSale.Text;

          

        }

        public string totalExpense()
        {
           
                string sql = $@"SELECT 
                        SUM(Expenses.Amount) AS Expense
                        FROM 
                     Expenses;";
                DataTable dt = da.ExecuteQueryTable(sql);
                DataRow dr = dt.Rows[0];
                lblExpense.Text = dr["Expense"].ToString();
                

                return lblExpense.Text;

           

        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void FrmAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                FrmLogin.isOpen = true;
                new FrmLogin().Show();
                this.Hide();
                isOpen = false;
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            if(!FormAttendance.isOpen)
            {
                new FormAttendance(currentUser).Show();
                FormAttendance.isOpen = true;

                this.Hide();
                isOpen=false;
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }
        }
    }

}
