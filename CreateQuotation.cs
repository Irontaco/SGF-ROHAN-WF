using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Quotation newQuotation = new Quotation();

            newQuotation.EmissionDate = DateTime.Now;

            DateEmitted.Text = newQuotation.EmissionDate.ToString();



        }
    }
}
