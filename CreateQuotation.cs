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
        public DataGridView DataGrid;

        public Dictionary<DataGridViewRow, Entry> RowEntryPairs;

        public CreateQuotation(DataPersistence dataPers)
        {
            CurrentQuotation = new Quotation();
            dataPersistence = dataPers;
            InitializeComponent();
            DataGrid = dataGrid_Quotation;
            RowEntryPairs = new Dictionary<DataGridViewRow, Entry>();

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            DateEmitted.Text = DateTime.Now.ToString();
            label_QuotationIdData.Text = dataPersistence.QuotationRepository.GetAllQuotations().Count.ToString();
            label_TotalPriceData.Text = "0 CLP";
            label_NetTotalData.Text = "0 CLP";
            label_IvaData.Text = "19.0 %";

            UpdateListBoxContents();
            UpdateSelectedClientData();

            p2_comboBox_ProductSpecifications3.SelectedIndex = 0;


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

            foreach (Client client in dataPersistence.ClientRepository.GetAllClients())
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
            SelectedClient = dataPersistence.ClientRepository.GetClientFromName(listBox_ClientNameList.SelectedItem.ToString());
            UpdateSelectedClientData();

        }

        private void Button_DeleteClient_Click(object sender, EventArgs e)
        {
            var DialogConfirmation = MessageBox.Show("Está seguro que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            
            if(DialogConfirmation == DialogResult.Yes)
            {
                dataPersistence.ClientRepository.DeleteClient(SelectedClient.Id);
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
                    if (!p2_textBox_ProductPrice.Text.All(char.IsDigit) 
                        || !p2_textBox_ProductDiscount.Text.All(char.IsDigit) 
                        || !p2_textBox_ProductQuantity.Text.All(char.IsDigit)
                        || !p2_textBox_ProductSpecifications1.Text.All(char.IsDigit)
                        || !p2_textBox_ProductSpecifications2.Text.All(char.IsDigit)
                        )
                    {
                        MessageBox.Show("No se pueden añadir valores no númericos al Precio, Descuento, o Específicaiones.");
                    }
                }
            }

            return true;

        }

        private void GenerateRowEntryPair()
        {

            //Gather the necessary data from the textboxes.
            string enProductName = p2_textBox_ProductName.Text;
            string enProductDescription = p2_TextBox_ProductDescription.Text;
            string enProductSpecifications = " (" + p2_textBox_ProductSpecifications1.Text + " x " + p2_textBox_ProductSpecifications2.Text + " " + p2_comboBox_ProductSpecifications3.SelectedItem.ToString() + ")";
            float enProductUnitPrice = int.Parse(p2_textBox_ProductPrice.Text);
            int entryQuantity = int.Parse(p2_textBox_ProductQuantity.Text);
            float entryDiscount = int.Parse(p2_textBox_ProductDiscount.Text);

            //Provide a new Product object and add it into a Quotation Entry.
            Product newProduct = new Product(enProductName, enProductDescription, enProductSpecifications, enProductUnitPrice);
            CurrentQuotation.AddNewEntryToProductEntries(newProduct, entryQuantity, entryDiscount, out Entry entry);

            //Gotta populate the new row.
            string ProductSpecSize = newProduct.ProductSpecifications;
            var index = DataGrid.Rows.Add();
            DataGrid.Rows[index].Cells["Item"].Value = RowEntryPairs.Count;
            DataGrid.Rows[index].Cells["Quantity"].Value = entry.Quantity;
            DataGrid.Rows[index].Cells["ProductName"].Value = newProduct.ProductName + ProductSpecSize;
            DataGrid.Rows[index].Cells["Description"].Value = newProduct.ProductDescription;
            DataGrid.Rows[index].Cells["UnitPrice"].Value = newProduct.UnitPrice;
            DataGrid.Rows[index].Cells["TotalPrice"].Value = entry.TotalPrice;
            DataGrid.Rows[index].Cells["Discount"].Value = entry.Discount;
            DataGrid.Rows[index].Cells["FinalPrice"].Value = entry.FinalPrice;

            RowEntryPairs.Add(DataGrid.Rows[index], entry);
            RecalculateFinalPriceData();

        }

        /// <summary>
        /// Updates the displayed rows in ascending Item order. 
        /// </summary>
        private void UpdateRowsFromEntryData()
        {
            
            Dictionary<DataGridViewRow, Entry> SortedD = new Dictionary<DataGridViewRow, Entry>();

            int index = 1;
            foreach(KeyValuePair<DataGridViewRow, Entry> KVP in RowEntryPairs)
            {
                KVP.Key.Cells["Item"].Value = index;
                SortedD.Add(KVP.Key, KVP.Value);
                index++;
            }

            //Clumsy, but this reorders the objects in a way where adding new ones won't be disordered.
            //(aka, new rows won't be added in-between objects due to internal dictionary ordering)
            RowEntryPairs = SortedD;

            DataGrid.Sort(DataGrid.Columns["Item"], ListSortDirection.Ascending);

        }

        private void p2_button_AddProductToQuotation_Click(object sender, EventArgs e)
        {
            if (!ValidateProductPanelTextBoxes())
            {
                return;
            }

            GenerateRowEntryPair();
            UpdateRowsFromEntryData();

        }


        private void dataGrid_Quotation_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow SelectedRow = e.Row;
        
            if (SelectedRow != null)
            {
                RowEntryPairs[SelectedRow].RemoveEntryFromQuotation();
                RowEntryPairs.Remove(SelectedRow);
            }

            UpdateRowsFromEntryData();
            RecalculateFinalPriceData();

        }

        private void RecalculateFinalPriceData()
        {
            float NetTotal = 0;
            float IVA = 19;

            foreach(Entry entry in CurrentQuotation.ProductEntries)
            {
                NetTotal += entry.FinalPrice;
            }

            float TotalPrice = NetTotal + (NetTotal * (IVA / 100));

            label_IvaData.Text = "19.0%";
            label_NetTotalData.Text = NetTotal.ToString();
            label_TotalPriceData.Text = TotalPrice.ToString();
        }

        private void button_SaveQuotation_Click(object sender, EventArgs e)
        {

            try
            {
                Client involvedClient = dataPersistence.ClientRepository.GetClientFromName(textBox_ClientNameSearchBar.Text);
                CurrentQuotation.Client = involvedClient;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!");
                return;
            }

            if(CurrentQuotation.ProductEntries.Count == 0)
            {
                MessageBox.Show("La cotización actual no tiene productos!");
                return;
            }

            if (dataPersistence.QuotationRepository.CreateQuotation(CurrentQuotation))
            {
                MessageBox.Show("Cotización guardada exitosamente!");
                return;

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
