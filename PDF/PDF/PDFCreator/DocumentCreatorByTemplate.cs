using static iText.Kernel.Pdf.Colorspace.PdfSpecialCs;

namespace PDFCreator
{
    public class DocumentCreatorByTemplate
    {
        private string FileTemplatePath = "JUNO SOLAR.pdf";
        private FillerElement _name = new FillerElement(110, 730, 1);
        private FillerElement _surname = new FillerElement(110, 710, 1);
        private FillerElement _street = new FillerElement(110, 690, 1);
        private FillerElement _city = new FillerElement(110, 670, 1);

        private FillerElement _moduleType = new FillerElement(230, 260, 1);

        private FillerElement _batteryStorage = new FillerElement(245, 245,1);

        private FillerElement _moduleTypePrice = new FillerElement(480, 260, 1);

        private FillerElement _batteryStoragePrice = new FillerElement(480, 245, 1);


        public string Name { set { _name.Text = value; } }
        public string Surname { set { _surname.Text = value; } }
        public string Street { set { _street.Text = value; } }
        public string City { set { _city.Text = value; } }

        public string ModuleType { set { _moduleType.Text = value; } }

        public string BatteryStorage { set { _batteryStorage.Text = value; } }

        public string ModuleTypePrice { set { _moduleTypePrice.Text = value; } }

        public string BatteryStoragePrice { set { _batteryStoragePrice.Text = value; } }

        public void CreateDocument(string newFilePath)
        {
            PDFPlaceholder drawingPages = new PDFPlaceholder();
            drawingPages.AddFillerElement(_name);
            drawingPages.AddFillerElement(_surname);
            drawingPages.AddFillerElement(_street);
            drawingPages.AddFillerElement(_city);
            drawingPages.AddFillerElement(_moduleType);
            drawingPages.AddFillerElement(_batteryStorage);
            drawingPages.AddFillerElement(_moduleTypePrice);
            drawingPages.AddFillerElement(_batteryStoragePrice);

            drawingPages.Fill(FileTemplatePath, newFilePath);
        }
    }
}
