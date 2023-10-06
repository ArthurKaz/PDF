using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using PdfSharp.Fonts;
using System.IO;

namespace PDFCreator
{
    public class PDFPlaceholder
    {
        private List<FilleElement> fillerElement = new List<FilleElement>();
        public void AddFillerElement(FilleElement fillerElement) => this.fillerElement.Add(fillerElement);

        public void Fill(string template, string result)
        {
            PdfDocument document = PdfReader.Open(template);
            for (int pageIndex = 0; pageIndex < document.Pages.Count; pageIndex++)
            {
                PdfPage page = document.Pages[pageIndex];
                XGraphics gfx = XGraphics.FromPdfPage(page);
                foreach (var element in fillerElement)
                {
                    if (element.PageNumer == pageIndex + 1) // pageIndex починається з 0, тому додаємо 1
                    {
                        XFont font = new XFont("Helvetica", 10);
                        XBrush brush = XBrushes.Black;
                        gfx.DrawString(element.Text, font, brush, new XPoint(element.x, element.y));
                    }
                }
            }
            
            document.Save(result);
        }
    }
}