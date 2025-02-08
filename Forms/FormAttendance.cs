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
    public partial class FormAttendance : Form
    {
        DataAccess Da;

        DataRow currentUser;

        public static bool isOpen = false;
        public FormAttendance()
        {
            InitializeComponent();
            Da = new DataAccess();
            this.PopulateGridView();
            this.lblTotal.Text = GetTotalAbsences();
            this.lblEmp.Text = GetTotalPresent();
        }

        public FormAttendance(DataRow row) : this()
        {
            this.currentUser = row;
            lblWlcName.Text = "Welcome ," + currentUser["Name"];
        }


        public void PopulateGridView(string query = "SELECT A.AttendanceID, U.UserId, U.Name, U.Role, A.AttendanceDate, A.Status FROM Attendance A JOIN Users U ON A.UserId = U.UserId ORDER BY A.AttendanceDate DESC;")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(query);




                this.dgvUser.AutoGenerateColumns = false;
                this.dgvUser.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopulateGridViewOnAction()
        {
            string part = "";

            int hasUserType = this.cboUserType.SelectedIndex;





            if (hasUserType == 1)
            {
                part += "WHERE ";
                part += $"Status = '{this.cboUserType.SelectedItem.ToString()}'";
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                part += $"AND AttendanceDate='{date}'";
            }
            else if (hasUserType == 2)
            {
                part += "WHERE ";
                part += $"Status <> 'Present'";
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                part += $"AND AttendanceDate='{date}'";
            }
            else if (hasUserType == 0)
            {
                {
                    part = "";
                }
            }
            string query = $"SELECT A.AttendanceID, U.UserId, U.Name, U.Role, A.AttendanceDate, A.Status FROM Attendance A JOIN Users U ON A.UserId = U.UserId {part} ORDER BY A.AttendanceDate DESC;";
            this.PopulateGridView(query);
        }





        public string GetTotalAbsences()
        {
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                string query = $"SELECT COUNT(DISTINCT UserID) AS TotalAbsences FROM Attendance WHERE Status = 'Absent' AND AttendanceDate='{date}';";

                DataTable dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["TotalAbsences"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return "0";
        }

        public string GetTotalPresent()
        {
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                string query = $"SELECT COUNT(DISTINCT UserID) AS TotalPresent FROM Attendance WHERE Status = 'Present' AND AttendanceDate='{date}';";

                DataTable dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["TotalPresent"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return "0";
        }


        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUser.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvUser.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                // delete operations
                //MessageBox.Show(this.dgvInventory.CurrentRow.Cells[0].Value.ToString());
                if (this.dgvUser.SelectedRows.Count > 0)
                {
                    string Id = this.dgvUser.CurrentRow.Cells["AttendanceID"].Value.ToString();
                    this.DeleteUser(Id);


                }
            }
        }

        public void DeleteUser(string id)
        {
            try
            {
                string sql = $"DELETE A FROM Attendance A JOIN Users U ON A.UserId = U.UserId WHERE A.AttendanceID={id};";
                int u = this.Da.ExecuteDMLQuery(sql);
                if (u > 0)
                {
                    MessageBox.Show("Delete Done");
                    this.PopulateGridView();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!FormAddAttendances.isOpen)
            {
                FormAddAttendances.isOpen = true;
                new FormAddAttendances(currentUser, this).Show();
                isOpen = false;
                this.Hide();

            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }


        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            this.Refresh();
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

        private void FormAttendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
