using SGF_ROHAN_WF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGF_ROHAN_WF.Controller
{
    public class QuotationRepositorySessionHandler : IQuotationRepository
    {
        private readonly DataPersistence dataPersistence;
        private Dictionary<int, Quotation> QuotationData;

        public QuotationRepositorySessionHandler(DataPersistence dataPers)
        {
            dataPersistence = dataPers;
            QuotationData = new Dictionary<int, Quotation>();
        }

        public bool CreateQuotation(Quotation quo)
        {
            if(quo != null)
            {
                quo.Id = QuotationData.Count + 1;
                QuotationData.Add(quo.Id, quo);

                return OnQuotationDataChanged();
            }
            
            return false;
        }

        private bool OnQuotationDataChanged()
        {
            return dataPersistence.CommitChanges();
        }

        public bool DeleteQuotation(int id)
        {
            if (id > 0)
            {
                try
                {
                    QuotationData.Remove(id);
                    return OnQuotationDataChanged();

                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("We've been given wrong data as the dictionary entry.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cotización válida para eliminar.");
                return false;
            }
        }

        public List<Quotation> GetAllQuotations()
        {
            List<Quotation> quotations = new List<Quotation>();
            try
            {
                foreach (KeyValuePair<int, Quotation> quoEntry in QuotationData)
                {
                    quotations.Add(quoEntry.Value);
                }

                return quotations;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                return quotations;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return quotations;

            }
        }

        public Quotation GetQuotationFromId(int id)
        {
            foreach (KeyValuePair<int, Quotation> KVP in QuotationData)
            {
                if (KVP.Value.Id == id)
                {
                    return KVP.Value;
                }
            }

            return null;
        }

        public bool UpdateQuotation(int id, Quotation updatedQuotationData)
        {
            try
            {
                foreach (KeyValuePair<int, Quotation> KVP in QuotationData)
                {
                    if (KVP.Key == id)
                    {
                        QuotationData[KVP.Key] = updatedQuotationData;
                        return OnQuotationDataChanged();
                    }
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("El cliente entregado tiene información inválida.");
                return false;
            }

            //No matches.
            //TODO: This function shouldn't really ever trigger without having checked if the ID is valid first.
            return false;
        }
    }
}
