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

        Client SelectedClient;
        List<string> ListBoxClientNames;

        public CreateQuotation(DataPersistence dataPers)
        {
            dataPersistence = dataPers;
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            Quotation newQuotation = new Quotation();

            newQuotation.EmissionDate = DateTime.Now;

            DateEmitted.Text = newQuotation.EmissionDate.ToString();
            textBox_QuotationId.Text = "1";
            label_TotalPriceData.Text = "0 CLP";
            label_NetTotalData.Text = "0 CLP";
            label_IvaData.Text = "19.0 %";

            DataGridTableStyle dataGridStyle = new DataGridTableStyle();
            dataGridStyle.ReadOnly = false;

            DataGridBoolColumn dgCol = new DataGridBoolColumn();
            dgCol.ReadOnly = false;

            //DEBUG_CreateDummyData();

            UpdateListBoxContents();
            UpdateSelectedClientData();

            dataGridStyle.GridColumnStyles.Add(dgCol);

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

        private void dataGrid_Quotation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
