using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Forms
{
    public partial class FrmLogin : Form
    {
        public static bool isOpen = false;
        DataAccess da;

        public FrmLogin()
        {
            InitializeComponent();
            // Initialize your database connection
            da = new DataAccess();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both the Phone and Password fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                string query = $"SELECT * FROM Users WHERE Phone='{phone}' AND Password='{password}';";
                DataTable dt = da.ExecuteQueryTable(query);
                DataRow userRow = dt.Rows[0];




                if (dt.Rows.Count == 1)
                {
                    string role = dt.Rows[0]["Role"].ToString();

                    if (role == "Admin")
                    {
                        MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Redirect to Admin Dashboard
                        new FrmAdminDashboard(userRow).Show();
                        isOpen = false;
                        FrmAdminDashboard.isOpen = true;

                        this.Hide();
                    }
                    else if (role == "Manager")
                    {
                        MessageBox.Show("Welcome, Employee!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Redirect to Employee Dashboard
                        new FormManagerDashboard(userRow).Show();
                        this.Hide();
                        isOpen = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid role detected.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Phone or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

