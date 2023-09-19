using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PDFCreator
{
    public class PDFPlaceholder
    {
        private List<FillerElement> fillerElement = new List<FillerElement>();
        public void AddFillerElement(FillerElement fillerElement) => this.fillerElement.Add(fillerElement);

        public void Fill(string template, string result)
        {
            using (PdfReader reader = new PdfReader(template))
            {
                Rectangle size = reader.GetPageSizeWithRotation(1);
                using (Document document = new Document(size))
                {
                    using (FileStream fs = new FileStream(result, FileMode.Create, FileAccess.Write))
                    {
                        using (PdfWriter writer = PdfWriter.GetInstance(document, fs))
                        {
                            document.Open();
                            PdfContentByte cb = writer.DirectContent;
                            
                            for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber++)
                            {
                                SetFontProperties(cb);
                                if (HasTextOnPage(pageNumber, out List<FillerElement> foundFillerElements))
                                {
                                    AddAllTextToPdf(cb, foundFillerElements);
                                }
                                PdfImportedPage page = writer.GetImportedPage(reader, pageNumber);
                                AddImportedPageToPdf(cb, page);
                                document.NewPage();
                            }
                            document.Close();
                        }
                    }
                }
            }
        }
        private bool HasTextOnPage(int page, out List<FillerElement> foundPageElements)
        {
            foundPageElements = new List<FillerElement>();
            bool isFound = false;
            foreach(var pageElement in fillerElement)
            {
                if (pageElement.PageNumer == page)
                {
                    foundPageElements.Add(pageElement);
                    isFound = true;
                }
            }
            return isFound;
        }
        private void SetFontProperties(PdfContentByte cb)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.BLACK);
            cb.SetFontAndSize(bf, 10);
        }
        private void AddAllTextToPdf(PdfContentByte cb, List<FillerElement> fillerElements)
        {
            cb.BeginText();
            foreach (var item in fillerElements)
            {
                AddTextToPdf(cb, item.Text, item.x, item.y);
            }
            cb.EndText();
        }

        private void AddTextToPdf(PdfContentByte cb, string text, float x, float y)
        {
            cb.ShowTextAligned(1, text, x, y, 0);
        }

        private void AddImportedPageToPdf(PdfContentByte cb, PdfImportedPage page)
        {
            cb.AddTemplate(page, 0, 0);
        }
    }
}
