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
    public partial class FormAddFood : System.Windows.Forms.Form
    {
        public static bool isOpen=false;

        private FormManagerDashboard FormManagerDashboard
        {
            set;get;
        }

        private FormManuOfFood FormManuOfFood
        {
            get; set;
        }
        DataAccess da;
        public FormAddFood()
        {
            InitializeComponent();
            da = new DataAccess();
            GenerateFoodID();
        }

       

        public FormAddFood(FormManuOfFood Fm):this()
        {
            this.FormManuOfFood= Fm;
        }

        public FormAddFood(FormManagerDashboard fM) : this()
        {
            this.FormManagerDashboard = fM;
        }


        private void GenerateFoodID()
        {
            try
            {
                string query = "select Max(FoodID) from Manu;";
                DataTable dt = this.da.ExecuteQueryTable(query);
                if (dt.Rows[0][0].ToString().IsNullOrEmpty())
                {
                    this.txtFoodId.Text = "F-001";
                    return;
                }
                string[] temp = dt.Rows[0][0].ToString().Split("-");
                int id = Convert.ToInt32(temp[1]) + 1;
                this.txtFoodId.Text = $"F-{id.ToString("D3")}";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Generate To Food Id Error : " + ex.Message);
            }

        }

        public void ClearAll()
        {
            this.GenerateFoodID();
            this.txtFoodName.Clear();
            this.txtPrice.Clear();
            this.txtStockQuantity.Clear();
            this.cbCategory.SelectedIndex=-1;
        }







        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(this.FormManagerDashboard!=null)
            {
                this.Hide();
                isOpen = false;
                FormManagerDashboard.Show();
                return;
            }

            this.Hide();
            FormManuOfFood.Show();
            FormManuOfFood.PopulateGridView();
            FormAddFood.isOpen = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private bool IsValid()
        {
            string id = this.txtFoodId.Text;
            string Name= this.txtFoodName.Text;
            if (id.IsNullOrEmpty() || Name.IsNullOrEmpty())
            {
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            decimal price;
            bool isNumeric= decimal.TryParse(this.txtPrice.Text, out price);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid numerical price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            decimal quantity;
            isNumeric = decimal.TryParse(this.txtStockQuantity.Text, out quantity);    
            if(!isNumeric)
            {
                MessageBox.Show("Please enter a valid numerical price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(price<=0)
            {
                MessageBox.Show("Price must be a positive value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (quantity < 0)
            {
                MessageBox.Show("Stock quantity must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Category must be selected.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            return true;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(!IsValid())
                {
                    return;

                }
                

                String query = $"Insert Into Manu (FoodID,FoodName,Category,PricePerUnit,Quantity) values ('{this.txtFoodId.Text}','{this.txtFoodName.Text}','{this.cbCategory.Text}',{Convert.ToInt64(this.txtPrice.Text)},{Convert.ToInt64(this.txtStockQuantity.Text)});";
                int u =da.ExecuteDMLQuery(query);
                if (u > 0)
                {
                    MessageBox.Show("SuccessFully! Food is Add","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show("Fail! Food isn't Add", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Food Add Error : "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
