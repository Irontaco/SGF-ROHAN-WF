using MigraDoc.DocumentObjectModel;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SGF_ROHAN_WF.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF_ROHAN_WF.Controller
{
    public class PdfGenerator
    {
        PdfData DocData;

        public void GenerateSamplePdf(Quotation quo, string fname)
        {
            string fullfilename = fname + ".pdf";

            DocData = new PdfData(quo, fname);
            DocData.BuildDocumentStyles();
            DocData.BuildDocumentLayout();
            DocData.GenerateClientInformation();
            DocData.GenerateTableHeaders();
            DocData.PopulateTableData();
            DocData.GeneratePriceTable();

            var pdf = new MigraDoc.Rendering.PdfDocumentRenderer(true);

            pdf.Document = DocData.ActiveDocument;
            pdf.RenderDocument();

            pdf.Save(fullfilename);

            Process.Start(fullfilename);
        }

    }
}
