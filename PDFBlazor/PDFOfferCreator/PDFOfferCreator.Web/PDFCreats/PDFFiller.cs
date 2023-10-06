using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PDFOfferCreator.Model;

namespace PDFOfferCreator.Web.PDFCreats
{
    public class PDFFiller
    {
        private const string templateHtmlPath = "wwwroot/html/htmlpage.html";
        private readonly IJSRuntime JS;

        private DataElement _name = new DataElement("Name");
        private DataElement _surname = new DataElement("Surname");
        private DataElement _street = new DataElement("Street");
        private DataElement _city = new DataElement("City");

        private DataElement _moduleType = new DataElement("-+ModuleType_+");

        private DataElement _batteryStorage = new DataElement("-+BatteryStorage+-");

        private DataElement _moduleTypePrice = new DataElement("ModuleTypePrice");

        private DataElement _batteryStoragePrice = new DataElement("BatteryStoragePrice");


        public string Name { set { _name.DataForReplace = value; } }
        public string Surname { set { _surname.DataForReplace = value; } }
        public string Street { set { _street.DataForReplace = value; } }
        public string City { set { _city.DataForReplace = value; } }

        public string ModuleTypeName { set { _moduleType.DataForReplace = value; } }

        public string BatteryStorageName { set { _batteryStorage.DataForReplace = value; } }

        public string ModuleTypePrice { set { _moduleTypePrice.DataForReplace = value; } }

        public string BatteryStoragePrice { set { _batteryStoragePrice.DataForReplace = value; } }
        private string ResultHTML = "";

        public event Action FileDownloaded;

        public PDFFiller(IJSRuntime jS)
        {
            JS = jS;
        }
        public async Task<bool> FillData(OfferData offer)
        {
            Name = offer.Name;
            Surname = offer.Surname;
            Street = offer.Street;
            City = offer.City;
            ModuleTypeName = GetModuleName(offer.ModuleType);
            BatteryStorageName = GetBatteryStorageName(offer.BatteryStorage);
            ModuleTypePrice = GetModulePrice(offer.ModuleType);
            BatteryStoragePrice = GetBatteryStoragePrice(offer.BatteryStorage);
            ResultHTML = await HtmlScanner.ReadHtmlFileAsync(templateHtmlPath);
            ResultHTML =  ReplaceData(ResultHTML);
            return true;
        }
        public async Task Download()
        {
            HTMLToPDFСonverter hTMLToPDFСonverter = new HTMLToPDFСonverter(JS);
            await hTMLToPDFСonverter.ConvertHtmlToPdf(ResultHTML);
            FileDownloaded?.Invoke();
        }

        private string ReplaceData(string htmlContent)
        {
            DataRemplacer dataRemplacer = new DataRemplacer();
            dataRemplacer.AddDataElemnt(_name);
            dataRemplacer.AddDataElemnt(_surname);
            dataRemplacer.AddDataElemnt(_street);
            dataRemplacer.AddDataElemnt(_city);

            dataRemplacer.AddDataElemnt(_moduleType);
            dataRemplacer.AddDataElemnt(_batteryStorage);
            dataRemplacer.AddDataElemnt(_moduleTypePrice);
            dataRemplacer.AddDataElemnt(_batteryStoragePrice);
            return dataRemplacer.ReplaceAllData(htmlContent);
        }
        private string GetModuleName(ModuleType moduleType)
        {
            switch (moduleType)
            {
                case ModuleType.JinkoSolar:
                    return "(Bsp. Jinko Solar)";
                case ModuleType.HeckertSolar:
                    return "(Bsp. Heckert Solar)";
                case ModuleType.PhonoSolar:
                    return "(Bsp. Phono Solar)";
                default: return null;
            }
        }
        private string GetModulePrice(ModuleType moduleType)
        {
            switch (moduleType)
            {
                case ModuleType.JinkoSolar:
                    return "1.000€";
                case ModuleType.PhonoSolar:
                    return "2.000€";
                case ModuleType.HeckertSolar:
                    return "3.000€";

                default: return null;
            }
        }
        private string GetBatteryStorageName(BatteryStorage batteryStorage)
        {
            switch (batteryStorage)
            {
                case BatteryStorage.FivekWh: return "(Bsp. 5 kWh)";
                case BatteryStorage.TenkWh: return "(Bsp. 10 kWh)";
                case BatteryStorage.FifteenWh: return "(Bsp. 15 kWh)";
                default: return null;
            }
        }
        private string GetBatteryStoragePrice(BatteryStorage batteryStorage)
        {
            switch (batteryStorage)
            {
                case BatteryStorage.FivekWh: return "1.500€";
                case BatteryStorage.TenkWh: return "2.500€";
                case BatteryStorage.FifteenWh: return "3.500€";
                default: return null;
            }
        }
        /*public async Task TestCreatePdf()
        {
            var htmlContent = await ReadHtmlFileAsync(templateHtml);
            ConvertHtmlToPdf(htmlContent);
        }*/
        /* public async Task<string> ReadHtmlFileAsync(string filePath)
         {
             try
             {
                 using (StreamReader reader = new StreamReader(filePath))
                 {
                     string fileContent = await reader.ReadToEndAsync();
                     return fileContent;
                 }
             }
             catch (Exception ex)
             {
                 return "";
             }
         }*/


    }
}
