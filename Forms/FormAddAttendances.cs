using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class FormAddAttendances : Form
    {
        DataAccess Da;
        DataRow currentUser;
        public static bool isOpen = false;
        FormAttendance FormAttendance { get; set; }

        FormManagerDashboard FormManagerDashboard { get; set; }


        public FormAddAttendances()
        {
            InitializeComponent();
            Da = new DataAccess();
            this.PopulateGridView();


        }

        public FormAddAttendances(DataRow row, FormAttendance formAttendance) : this()
        {
            this.currentUser = row;
            lblWlcName.Text = "Welcome ," + currentUser["Name"];
           this. FormAttendance = formAttendance;
        }

        public FormAddAttendances(DataRow row,FormManagerDashboard formManagerDashboard): this()
        {
            this.currentUser = row;
            lblWlcName.Text = "Welcome ," + currentUser["Name"];
            this.FormManagerDashboard = formManagerDashboard;
        }


        public void PopulateGridView(string query = "SELECT UserId, Name,Role FROM Users WHERE Role IN ('Waiter', 'Manager');")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(query);
                dt.Columns.Add("Date", typeof(string));
                dt.Columns.Add("Time", typeof(string));

                foreach (DataRow row in dt.Rows)
                {

                    row["Date"] = DateTime.Now.ToString("dd-MM-yyyy");
                    row["Time"] = DateTime.Now.ToString("hh:mm tt");

                }

                this.dgvAttendances.AutoGenerateColumns = false;
                this.dgvAttendances.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAttendances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != dgvAttendances.Columns["Okey"].Index || e.RowIndex < 0)
                return;

            var result = MessageBox.Show("Are you sure you want to confirm this attendance?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;


            dgvAttendances.CommitEdit(DataGridViewDataErrorContexts.Commit);


            bool isChecked = dgvAttendances.Rows[e.RowIndex].Cells["chkStatus"].Value is bool checkedValue && checkedValue;


            string userId = dgvAttendances.Rows[e.RowIndex].Cells["UserId"].Value?.ToString() ?? "N/A";
            string date = dgvAttendances.Rows[e.RowIndex].Cells["Date"].Value?.ToString() ?? "N/A";
            string time = dgvAttendances.Rows[e.RowIndex].Cells["Time"].Value?.ToString() ?? "N/A";
            string attendanceStatus = isChecked ? "Present" : "Absent";
            string formattedDateTime = $"{date} {time}";

            // Display attendance information
            string sql = $"INSERT INTO Attendance (UserId, AttendanceDate, Status) VALUES ('{userId}','{formattedDateTime}','{attendanceStatus}')";
            int u = this.Da.ExecuteDMLQuery(sql);
            if (u == 1)
            {
                MessageBox.Show("Successfully ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fail! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (FormManagerDashboard != null)
            {
                if (!FormManagerDashboard.isOpen)
                {
                    FormManagerDashboard.Show();
                    FormManagerDashboard.isOpen = true;
                    isOpen = false;
                    this.Hide();
                    return;
                }

            }



            if (!FormAttendance.isOpen)
            {
                FormAttendance.Show();
                FormAttendance.isOpen = true;
                isOpen = false;
                this.Hide();
                this.PopulateGridView();

            }

        }

        private void FormAddAttendances_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
