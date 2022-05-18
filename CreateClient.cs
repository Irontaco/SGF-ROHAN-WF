using SGF_ROHAN_WF.Controller;
using SGF_ROHAN_WF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGF_ROHAN_WF
{
    public partial class CreateClient : Form
    {
        DataPersistence DataPersistence;

        public CreateClient(DataPersistence dataPers)
        {

            DataPersistence = dataPers;
            InitializeComponent();

        }

        private void button_SaveClient_Click(object sender, EventArgs e)
        {
            Client newCli = new Client();

            newCli.Names = textBox_Names.Text;
            newCli.Surnames = textBox_Surnames.Text;
            newCli.Email = textBox_Email.Text;
            newCli.PhoneNumber = textBox_PhoneNumber.Text;
            newCli.RegisteredBusiness = textBox_RegisteredBusiness.Text;

            if (!IsInputDataValid())
            {
                Console.WriteLine("Some entry is empty right now");
                return;
            }

            if (DataPersistence.ClientRepositoryDbHandler.CreateClient(newCli))
            {
                Console.WriteLine("We created a new client successfully!");
            }
            else
            {
                Console.WriteLine("Something has gone wrong when creating the client.");
            }

        }

        private bool IsInputDataValid()
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(ctrl.Text))
                    {
                        return false;
                    }

                }
            }

            return true;
        }

        private void CreateClient_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Names_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
