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
    public partial class FormManagerDashboard : Form
    {
        public static bool isOpen = false;
        DataRow currentUser;
        public FormManagerDashboard()
        {
            InitializeComponent();
        }

        public FormManagerDashboard(DataRow row) : this()
        {
            this.currentUser = row;
            lblWlcName.Text = "Welcome ," + currentUser["Name"];
        }

        private void btnSalesAdd_Click(object sender, EventArgs e)
        {
            new FormAddSales(currentUser, this).Show();
            this.Hide();
            FormAddSales.isOpen = true;


        }

        private void FormManagerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
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



        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (!FrmLogin.isOpen)
            {
                new FrmLogin().Show();

                isOpen = false;
                FrmLogin.isOpen = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Can't Open Add Form window");
            }
        }

        private void btnAttendence_Click(object sender, EventArgs e)
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
    }
}
