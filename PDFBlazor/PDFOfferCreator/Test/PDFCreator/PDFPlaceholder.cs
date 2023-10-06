using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Drawing;
using System.IO;

namespace PDFCreator
{
    public class PDFPlaceholder
    {
        private List<FilleElement> fillerElement = new List<FilleElement>();
        public void AddFillerElement(FilleElement fillerElement) => this.fillerElement.Add(fillerElement);

        public void FillAndSaveUsingSyncfusion(string inputFilePath, string outputFilePath)
        {
        }
    }
}
