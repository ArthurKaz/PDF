

namespace PDFCreator
{
    public class DocumentCreatorByTemplate
    {
        private string FileTemplatePath = "JUNO SOLAR.pdf";
        private FilleElement _name = new FilleElement(110, 100, 1);
        private FilleElement _surname = new FilleElement(110, 130, 1);
        private FilleElement _street = new FilleElement(110, 160, 1);
        private FilleElement _city = new FilleElement(110, 190, 1);

        private FilleElement _moduleType = new FilleElement(190, 582, 1);

        private FilleElement _batteryStorage = new FilleElement(215, 597, 1);

        private FilleElement _moduleTypePrice = new FilleElement(448, 582, 1);

        private FilleElement _batteryStoragePrice = new FilleElement(448, 597, 1);


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
            /*for (int i = 0; i < 1000; i+= 50)
            {
                for (int j = 0; j < 1000; j+= 50)
                {
                    var fileelement = new FilleElement(i, j, 1);
                    fileelement.Text = "i-" + i + "j-"+j;
                       drawingPages.AddFillerElement(fileelement);
                }
            }*/

            drawingPages.Fill(FileTemplatePath, newFilePath);
        }
        public void GetPDFDataCreateDocument(string template, string newPath)
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

            drawingPages.Fill(template, newPath);
            
        }
    }
}
