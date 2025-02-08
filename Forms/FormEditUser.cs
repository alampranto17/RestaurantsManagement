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
    public partial class FormEditUser : Form
    {
        
        public static bool isOpen = false;
        private DataAccess Da { get; set; }
        private FormUsers FormUsers { get; set; }
        private string userId;
        public FormEditUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            isOpen = true;
        }

        public FormEditUser(string userId, FormUsers frmUsers) : this()
        {
            this.FormUsers = frmUsers;
            this.ShowUser(userId);
            this.userId = userId;
        }

        private void ShowUser(string userId)
        {
            try
            {
                string query = $"SELECT * FROM Users WHERE UserId = '{userId}'";
                DataSet ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // done
                    this.txtUserId.Text = ds.Tables[0].Rows[0][0].ToString();
                    this.txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    this.txtPhone.Text = ds.Tables[0].Rows[0][2].ToString();
                    this.txtPassword.Text = ds.Tables[0].Rows[0][3].ToString();
                    string role = ds.Tables[0].Rows[0][4].ToString();
                    if (role == "Admin") this.chkAdmin.Checked = true;
                    else if (role == "Employee") this.chkManger.Checked = true;
                    else if (role == "Waiter") this.chkWaiter.Checked = true;
                }
                else
                {
                    // not found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearAll()
        {
            this.txtName.Clear();
            this.txtPhone.Clear();
            this.txtPassword.Clear();
            this.chkAdmin.Checked = false;
            this.chkManger.Checked = false;
            this.chkWaiter.Checked = false;
        }

        public bool IsValid()
        {
            string name = this.txtName.Text;
            string phone = this.txtPhone.Text;
            string password = this.txtPassword.Text;
            bool typeChecked = chkManger.Checked || chkAdmin.Checked || chkWaiter.Checked;
            if (name.IsNullOrEmpty() || phone.IsNullOrEmpty() || password.IsNullOrEmpty() || !typeChecked)
            {
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
                return;

            string id = this.txtUserId.Text;
            string name = this.txtName.Text;
            string phone = this.txtPhone.Text;
            string password = this.txtPassword.Text;
            string role = "";
            if (chkAdmin.Checked)
                role = "Admin";
            else if (chkManger.Checked)
                role = "Manager";
            else if (chkWaiter.Checked)
                role = "Waiter";

            try
            {
                string sql = $"UPDATE Users SET Name = '{name}',  Phone = '{phone}', Password = '{password}', Role = '{role}'  WHERE UserId = '{id}';";
                //MessageBox.Show(sql);
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt == 1)
                {
                    MessageBox.Show($"{name} has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    this.ClearAll();
                    
                    this.FormUsers.Visible = true;
                    this.FormUsers.AfterEdit(userId);
                    this.FormUsers.ClearAll();
                    isOpen = false;
                }
                else
                    MessageBox.Show($"Failed to update {name}. Please try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred edit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormUsers.ClearAll();
            this.Hide();
            isOpen = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
