using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SGF_ROHAN_WF.Controller;
using SGF_ROHAN_WF.Model;

namespace SGF_ROHAN_WF
{
    public partial class CreateQuotation : Form
    {

        DataPersistence dataPersistence;


        Quotation CurrentQuotation;
        Client SelectedClient;
        List<string> ListBoxClientNames;

        public DataTable CurrentDataTable;

        public CreateQuotation(DataPersistence dataPers)
        {
            CurrentQuotation = new Quotation();
            dataPersistence = dataPers;
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            DateEmitted.Text = "Aún no emitida";
            textBox_QuotationId.Text = "1";
            label_TotalPriceData.Text = "0 CLP";
            label_NetTotalData.Text = "0 CLP";
            label_IvaData.Text = "19.0 %";
            p2_Combobox_Scale.SelectedIndex = 0;


            CurrentDataTable = new DataTable();
            //DEBUG_CreateDummyData();

            UpdateListBoxContents();
            UpdateSelectedClientData();


        }



        //Calls PDF generator
        private void button_GeneratePDF_Click(object sender, EventArgs e)
        {

            PdfDocument doc = new PdfDocument();

            PdfPage page = doc.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

            graph.DrawString("test", font, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);

            doc.Save("test.pdf");
            Process.Start("test.pdf");

        }


        private void button_NewClient_Click(object sender, EventArgs e)
        {
            CreateClient clientForm = new CreateClient(dataPersistence);
            clientForm.FormClosed += ClientForm_FormClosed;

            clientForm.ShowDialog();

        }

        //Defines what happens once we close the child window.
        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateListBoxContents();
        }

        //Updates the contents of the main Quotation window - need to call this everytime we close a child window.
        //TODO: Test for overlapping data.
        private void UpdateListBoxContents()
        {
            ListBoxClientNames = new List<string>();

            if(dataPersistence.ClientRepositoryDbHandler.GetAllClients() == null)
            {
                listBox_ClientNameList.DataSource = null;
                return;
            }

            foreach (Client client in dataPersistence.ClientRepositoryDbHandler.GetAllClients())
            {
                if (!client.IsDeleted)
                {
                    ListBoxClientNames.Add(client.FullName);
                }
            }

            listBox_ClientNameList.DataSource = ListBoxClientNames;

            return;
        }

        private void UpdateSelectedClientData()
        {
            if (SelectedClient == null)
            {
                textBox_ClientNameSearchBar.Text = "";
                label_EmailData.Text = "";
                label_PhoneNumberData.Text = "";
                label_RegisteredBusinessData.Text = "";

                return;
            }
            else
            {
                textBox_ClientNameSearchBar.Text = SelectedClient.Id + " - " + SelectedClient.FullName;
                label_EmailData.Text = SelectedClient.Email;
                label_PhoneNumberData.Text = SelectedClient.PhoneNumber;
                label_RegisteredBusinessData.Text = SelectedClient.RegisteredBusiness;
            }

        }

        private void listBox_ClientNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedClient = new Client();
            SelectedClient.Names = (string)listBox_ClientNameList.SelectedValue;
            UpdateSelectedClientData();

        }

        private void Button_DeleteClient_Click(object sender, EventArgs e)
        {
            var DialogConfirmation = MessageBox.Show("Está seguro que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            
            if(DialogConfirmation == DialogResult.Yes)
            {
                dataPersistence.ClientRepositoryDbHandler.DeleteClient(SelectedClient.Names);
                UpdateListBoxContents();
            }
            else
            {
                return;
            }
        }

        private bool ValidateProductPanelTextBoxes()
        {
            foreach(Control ctrl in panel2.Controls)
            {
                if(ctrl is TextBox)
                {
                    if(String.IsNullOrWhiteSpace(ctrl.Text))
                    {
                        MessageBox.Show("Existen valores vacíos en el producto a registrar, por favor corregir!");
                        return false;

                    }
                    if (!p2_textBox_ProductPrice.Text.All(char.IsDigit) || !p2_textBox_ProductDiscount.Text.All(char.IsDigit) || !p2_textBox_ProductQuantity.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("No se pueden añadir valores no númericos al Precio o Descuento.");
                    }
                }
            }

            return true;

        }

        private void CreateQuotationFromFormData()
        {

        }

        private bool GenerateEntryFromFormData()
        {
            string enProductName = p2_textBox_ProductName.Text;
            string enProductDescription = p2_TextBox_ProductDescription.Text;
            string enProductSpecifications = p2_TextBox_ProdSpecsHorizontal.Text + "x" + p2_Textbox_ProdSpecsVertical.Text + " " + p2_Combobox_Scale.SelectedItem.ToString();
            float enProductUnitPrice = int.Parse(p2_textBox_ProductPrice.Text);

            int entryQuantity = int.Parse(p2_textBox_ProductQuantity.Text);
            float entryDiscount = int.Parse(p2_textBox_ProductDiscount.Text);

            Product entryProduct = new Product(enProductName, enProductDescription, enProductSpecifications, enProductUnitPrice);

            if(CurrentQuotation.AddNewEntryFromProductData(entryProduct, entryQuantity, entryDiscount, true, out Entry generatedEntry))
            {
                var index = dataGrid_Quotation.Rows.Add();
                dataGrid_Quotation.Rows[index].Cells["Item"].Value = generatedEntry.ItemNumber;
                dataGrid_Quotation.Rows[index].Cells["Quantity"].Value = generatedEntry.Quantity;
                dataGrid_Quotation.Rows[index].Cells["ProductName"].Value = generatedEntry.RowProduct.ProductName + " (" + generatedEntry.RowProduct.ProductSpecifications + ")";
                dataGrid_Quotation.Rows[index].Cells["Description"].Value = generatedEntry.RowProduct.ProductDescription;
                dataGrid_Quotation.Rows[index].Cells["UnitPrice"].Value = generatedEntry.RowProduct.UnitPrice;
                dataGrid_Quotation.Rows[index].Cells["TotalPrice"].Value = generatedEntry.TotalPrice;
                dataGrid_Quotation.Rows[index].Cells["Discount"].Value = generatedEntry.Discount;
                dataGrid_Quotation.Rows[index].Cells["FinalPrice"].Value = generatedEntry.FinalPrice;

                return true;

            }

            return false;

        }


        private void p2_button_AddProductToQuotation_Click(object sender, EventArgs e)
        {
            if (ValidateProductPanelTextBoxes())
            {
                GenerateEntryFromFormData();

            }


        }

        private void dataGrid_Quotation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_DeleteEntry_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }
    }
}
