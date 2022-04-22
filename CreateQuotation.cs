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


        public CreateQuotation()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            List<string> clientNames = new List<string>();

            /*
            Client client1 = new Client();
            client1.Id = 1;
            client1.Names = "Rodrigo Lazaro";
            client1.Surnames = "Nuñez Mendez";
            client1.RegisteredBusiness = "";
            client1.Email = "rodrigo.nunez@gmail.com";
            client1.PhoneNumber = "+569 2222 1111";

            Client client2 = new Client();
            client2.Id = 2;
            client2.Names = "Teresa Estefania";
            client2.Surnames = "Lopez Garcia";
            client2.RegisteredBusiness = "";
            client2.Email = "teresa.lopez@gmail.com";
            client2.PhoneNumber = "+569 3333 4444";

            Client client3 = new Client();
            client3.Id = 3;
            client3.Names = "Walter Fabian";
            client3.Surnames = "Torres Alvarado";
            client3.RegisteredBusiness = "";
            client3.Email = "walter.torres@gmail.com";
            client3.PhoneNumber = "+569 5555 6666";

            clientNames.Add(client1.FullName);
            clientNames.Add(client2.FullName);
            clientNames.Add(client3.FullName);
            */

            DataPersistence dataPers = new DataPersistence();

            List<Client> Clients = dataPers.FetchClientsFromSavedData();

            foreach (Client client in Clients)
            {
                clientNames.Add(client.FullName);
            }

            Quotation newQuotation = new Quotation();

            newQuotation.EmissionDate = DateTime.Now;

            DateEmitted.Text = newQuotation.EmissionDate.ToString();
            listBox_ClientNameList.DataSource = clientNames;
            textBox_QuotationId.Text = "1";
            label_TotalPriceData.Text = "0 CLP";
            label_NetTotalData.Text = "0 CLP";
            label_IvaData.Text = "19.0 %";

            DataGridTableStyle dataGridStyle = new DataGridTableStyle();
            dataGridStyle.MappingName = "Items";

            DataGridBoolColumn dgCol = new DataGridBoolColumn();
            dgCol.HeaderText = "Item";
            dgCol.MappingName = "Current";

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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
