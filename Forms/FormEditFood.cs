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
    public partial class FormEditFood : Form
    {

        private FormManuOfFood FormManuOfFood
        {
            set; get;
        }


        DataAccess da;

        public FormEditFood()
        {
            InitializeComponent();
            this.da = new DataAccess();

        }
        public FormEditFood(FormManuOfFood formManuOfFood, string foodId) : this()
        {
            this.FormManuOfFood = formManuOfFood;
            this.PopulateTextBox(foodId);

        }
        private void PopulateTextBox(string FoodId)
        {
            try
            {
                string query = $"SELECT * FROM Manu WHERE FoodID = '{FoodId}';";
                DataSet dt = this.da.ExecuteQuery(query);


                if (dt == null || dt.Tables.Count == 0 || dt.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No data found for the given FoodID.");
                    return;
                }

                // Access the first table in the DataSet (usually, the first table contains the results)
                DataRow row = dt.Tables[0].Rows[0];

                // Check for DBNull and assign values to TextBox controls
                this.txtFoodId.Text = row["FoodID"] != DBNull.Value ? row["FoodID"].ToString() : "";
                this.txtFoodName.Text = row["FoodName"] != DBNull.Value ? row["FoodName"].ToString() : "";
                this.txtPrice.Text = row["PricePerUnit"] != DBNull.Value ? row["PricePerUnit"].ToString() : "";
                this.txtStockQuantity.Text = row["Quantity"] != DBNull.Value ? row["Quantity"].ToString() : "";
                this.cbCategory.Text = row["Category"] != DBNull.Value ? row["Category"].ToString() : "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Message error : " + ex);
            }
        }

        private void ClearAll()
        {

            this.txtFoodName.Text = null;
            this.txtPrice.Text = null;
            this.cbCategory.Text = null;
            this.txtStockQuantity.Text = null;
        }

        private bool IsValid()
        {
            string id = this.txtFoodId.Text;
            string Name = this.txtFoodName.Text;
            if (id.IsNullOrEmpty() || Name.IsNullOrEmpty())
            {
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            decimal price;
            bool isNumeric = decimal.TryParse(this.txtPrice.Text, out price);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid numerical price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            decimal quantity;
            isNumeric = decimal.TryParse(this.txtStockQuantity.Text, out quantity);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid numerical price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (price <= 0)
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManuOfFood.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(!IsValid())
                {
                    return;
                }
                string query = $"UPDATE Manu SET FoodName ='{this.txtFoodName.Text}',PricePerUnit ={Convert.ToInt64(this.txtPrice.Text)},Quantity = {Convert.ToInt64(this.txtStockQuantity.Text)},Category = '{this.cbCategory.Text}' WHERE FoodID = '{this.txtFoodId.Text}';";
                int u= da.ExecuteDMLQuery(query);
                if (u > 0)
                {
                    MessageBox.Show($"{this.txtFoodName.Text} is updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormManuOfFood.Visible=true;
                    FormManuOfFood.PopulateGridView();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }
        }
    }
}
