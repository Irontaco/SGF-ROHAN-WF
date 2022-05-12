using SGF_ROHAN_WF.Controller;
using SGF_ROHAN_WF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGF_ROHAN_WF
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DataPersistence dataPersistence = new DataPersistence();

            Application.Run(new CreateQuotation(dataPersistence));
        }
    }
}
