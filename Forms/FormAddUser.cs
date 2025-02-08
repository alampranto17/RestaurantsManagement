using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormAddUser : Form
    {
        DataAccess da;
        public  static bool isOpen=  false;
        private FormUsers FormUsers
        {
            set;get;
        }

      

        public FormAddUser()
        {
            InitializeComponent();
            da = new DataAccess();
            this.GenerateId();
        }
        public FormAddUser(FormUsers users):this()
        {
            this.FormUsers = users;
        }

        private void ClearAll()
        {
            this.GenerateId();
            this.txtName.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.chkAdmin.Checked = false;
            this.chkManger.Checked = false;
            this.chkWaiter.Checked = false; 
        }

        private void GenerateId()
        {
            try
            {
                string query = $"select Max(UserId) from Users;";
                DataTable dt = this.da.ExecuteQueryTable(query);
                if (dt.Rows[0][0].ToString().IsNullOrEmpty())
                {
                    this.txtUserId.Text = "U-001";
                    return;
                }
                string[] temp = dt.Rows[0][0].ToString().Split("-");
                int id = Convert.ToInt32(temp[1]) + 1;
                this.txtUserId.Text = $"U-{id.ToString("D3")}";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message Occur : ", "Error", MessageBoxButtons.OK);
            }
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormUsers.ClearAll();
            this.Hide();
            isOpen= false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        bool IsValidPhoneNumber(string number)
        {
            // Simple pattern: must be 10-15 digits, optionally starting with a '+'
            string pattern = @"^\+?\d{10,15}$";
            return Regex.IsMatch(number, pattern);
        }


        private bool IsValid()
        {
            string id = this.txtUserId.Text;
            string Name = this.txtName.Text;
            string Phone = this.txtPhone.Text;
            string Password = this.txtPassword.Text;
            bool typeChecked = this.chkManger.Checked || this.chkAdmin.Checked || this.chkWaiter.Checked;
           
            if (id.IsNullOrEmpty() || Name.IsNullOrEmpty() || Password.IsNullOrEmpty() || !typeChecked)
            {
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!IsValidPhoneNumber(Phone))
            {
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }




        private void bntAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValid())
                {
                    return;

                }
                string id = this.txtUserId.Text;
                string name = this.txtName.Text;
                string phone = this.txtPhone.Text;
                string password = this.txtPassword.Text;
                string role = "";
                if (this.chkAdmin.Checked)
                    role = "Admin";
                else if (this.chkManger.Checked)
                    role = "Manager";
                else if (this.chkWaiter.Checked)
                    role = "waiter";

                string query = $"insert into  users (UserId,Name,Phone,Role,Password) Values ('{id}','{name}','{phone}','{role}','{password}');";
                int u=this.da.ExecuteDMLQuery(query);
                if(u==1)
                {
                    MessageBox.Show("Successfully! Data is Add","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.ClearAll();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data is not Add", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

       
    }
}
