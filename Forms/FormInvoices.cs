using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf.IO;

namespace Forms
{
    public partial class FormInvoices : Form
    {
        private string saleid;
        private DataAccess da;

        private string time;
        private decimal totalAmount;
        private decimal givemAmount;
        private decimal change;
        private string createBy;
        public static bool isOpen = false;

        public FormSales FormSales {  get; set; }

        public FormInvoices()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        public FormInvoices(string salesid) : this()
        {
            this.saleid = salesid;

            string sql = $@"
                SELECT SD.SaleID, F.FoodID, F.FoodName, SD.QuantitySold, F.PricePerUnit, 
                (SD.QuantitySold * F.PricePerUnit) AS LineTotal
                FROM manu F 
                JOIN SaleDetails SD ON F.FoodID = SD.FoodID 
                WHERE SD.SaleID = '{this.saleid}';";

            this.PopulateGridView(sql);
            this.ShowInitialInfo(saleid);
        }

       public FormInvoices(string salesid,FormSales fs) : this(salesid)
        {
            this.saleid = saleid;
            this.FormSales = fs;
        }

        public void PopulateGridView(string query = "")
        {
            try
            {
                DataTable dt = this.da.ExecuteQueryTable(query);
                this.dgvSale.AutoGenerateColumns = false;
                this.dgvSale.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowInitialInfo(string saleId)
        {
            try
            {
                DataTable dt = this.da.ExecuteQueryTable($"SELECT * FROM Sales WHERE SaleId = '{saleId}'");
                DateTime fullDateTime = Convert.ToDateTime(dt.Rows[0]["SaleDate"]);
                time = fullDateTime.ToString("hh:mm tt") + " " + fullDateTime.ToString("dd-MM-yyyy");
                totalAmount = Convert.ToDecimal(dt.Rows[0]["totalAmount"]);
                givemAmount = Convert.ToDecimal(dt.Rows[0]["GivenAmount"]);
                change = Convert.ToDecimal(dt.Rows[0]["changeAmount"]);
                createBy = dt.Rows[0]["SalesmanName"].ToString();

                this.lblSaleId.Text = saleId;
                this.lblTime.Text = time;
                this.lblMethod.Text = "Cash";
                this.lblSalesBy.Text = createBy;

                this.lblGrand.Text = totalAmount.ToString("F2") + " TK";
                this.lblGiven.Text = givemAmount.ToString("F2") + " TK";
                this.lblChange.Text = change.ToString("F2") + " TK";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnPrint_Click_1(object sender, EventArgs e)
        {

            string directoryPath = @"D:\Restaurants Management\Pdf"; // Change this path if needed

            // Ensure the directory exists, create it if it doesn't
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string pdfPath = Path.Combine(directoryPath, $"PdfInvoice_{this.saleid}.pdf");

            try
            {
                // Create PDF document
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Invoice";

                // Add a page to the document
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Use regular font (no bold)
                XFont regularFont = new XFont("Verdana", 12);

                double yPosition = 40;

                // Title of the PDF
                gfx.DrawString("Invoice", regularFont, XBrushes.Black, new XPoint(page.Width / 2, yPosition));
                yPosition += 40;

                // Sale information
                gfx.DrawString($"Sale ID: {this.saleid}", regularFont, XBrushes.Black, 50, yPosition);
                gfx.DrawString($"Date & Time: {this.lblTime.Text}", regularFont, XBrushes.Black, 50, yPosition + 20);
                gfx.DrawString($"Salesman: {this.lblSalesBy.Text}", regularFont, XBrushes.Black, 50, yPosition + 40);
                gfx.DrawString($"Payment Method: {this.lblMethod.Text}", regularFont, XBrushes.Black, 50, yPosition + 60);
                yPosition += 100;

                // Table Header

                gfx.DrawString("Food Name", regularFont, XBrushes.Black, 150, yPosition);
                gfx.DrawString("Quantity", regularFont, XBrushes.Black, 300, yPosition);
                gfx.DrawString("Price Per Unit", regularFont, XBrushes.Black, 400, yPosition);
                gfx.DrawString("Line Total", regularFont, XBrushes.Black, 500, yPosition);
                yPosition += 20;

                // Table Data
                foreach (DataGridViewRow row in dgvSale.Rows)
                {
                    if (row.Cells[0].Value != null) // Ensure row has data
                    {
                        gfx.DrawString(row.Cells["FoodName"].Value?.ToString(), regularFont, XBrushes.Black, 150, yPosition);
                        gfx.DrawString(row.Cells["QuantitySold"].Value?.ToString(), regularFont, XBrushes.Black, 300, yPosition);
                        gfx.DrawString(row.Cells["UnitPrice"].Value?.ToString(), regularFont, XBrushes.Black, 400, yPosition);
                        gfx.DrawString(row.Cells["Total"].Value?.ToString(), regularFont, XBrushes.Black, 500, yPosition);
                        yPosition += 20;
                    }
                }

                // Footer with totals
                yPosition += 20;
                gfx.DrawString($"Grand Total: {this.lblGrand.Text}", regularFont, XBrushes.Black, 50, yPosition);
                gfx.DrawString($"Given Amount: {this.lblGiven.Text}", regularFont, XBrushes.Black, 50, yPosition + 20);
                gfx.DrawString($"Change: {this.lblChange.Text}", regularFont, XBrushes.Black, 50, yPosition + 40);

                // Save the PDF document to the specified path
                document.Save(pdfPath);

                // Open the generated PDF using the default PDF viewer
                Process.Start(new ProcessStartInfo(pdfPath) { UseShellExecute = true });

                // Inform the user about the successful creation of the invoice
                MessageBox.Show($"Invoice generated and opened successfully at: {pdfPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(FormSales!=null)
            {
                this.Hide();
                isOpen= false;
                return;
            }
            this.Close();
        }
    }

}



