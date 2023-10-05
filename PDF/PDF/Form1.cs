
using System.Windows.Forms;
using BusinessLogic;
using iText.Signatures;
using PDFCreator;
namespace PDF
{
    public partial class Form1 : Form
    {
        private string newFile => Name.Text + Surname.Text + ".pdf";

        public Form1()
        {
            InitializeComponent();
            ModuleTypeComboBox.SelectedIndex = 0;
            BatteryStorageComboBox.SelectedIndex = 0;
            ModuleType moduleType = (ModuleType)ModuleTypeComboBox.SelectedIndex;
            modulePrice.Text = GetModulePrice(moduleType);
            BatteryStorage batteryStorage = (BatteryStorage)BatteryStorageComboBox.SelectedIndex;
            batteryPrice.Text = GetBatteryStoragePrice(batteryStorage);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if(Validate(out string message) == false)
            {
                MessageBox.Show(message);
            }
            else
            {
                CreatePDFFile();
            }
        }

        private void CreatePDFFile()
        {
            DocumentCreatorByTemplate documentTemplate = new DocumentCreatorByTemplate();

            documentTemplate.Name = Name.Text;
            documentTemplate.Surname = Surname.Text;
            documentTemplate.Street = Street.Text;
            documentTemplate.City = City.Text;

            ModuleType moduleType = (ModuleType)ModuleTypeComboBox.SelectedIndex;
            BatteryStorage batteryStorage = (BatteryStorage)BatteryStorageComboBox.SelectedIndex;
            documentTemplate.ModuleType = GetModuleName(moduleType);
            documentTemplate.BatteryStorage = GetBatteryStorageName(batteryStorage);
            documentTemplate.ModuleTypePrice = GetModulePrice(moduleType);
            documentTemplate.BatteryStoragePrice = GetBatteryStoragePrice(batteryStorage);

            documentTemplate.CreateDocument(newFile);
        }

        private bool Validate(out string message)
        {

            message = "Ok";
            if (Name.Text == string.Empty)
            {
                message = "Name cant be empty";
                return false;
            }
            if (Surname.Text == string.Empty)
            {
                message = "Surname cant be empty";
                return false;
            }
            if (City.Text == string.Empty)
            {
                message = "City cant be empty";
                return false;
            }
            if (Street.Text == string.Empty)
            {
                message = "Street cant be empty";
                return false;
            }
            return true;
        }
        private string GetModuleName(ModuleType moduleType) {
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

        private void ModuleTypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ModuleType moduleType = (ModuleType)ModuleTypeComboBox.SelectedIndex;
            modulePrice.Text = GetModulePrice(moduleType);
           
        }

        private void BatteryStorageComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BatteryStorage batteryStorage = (BatteryStorage)BatteryStorageComboBox.SelectedIndex;
            batteryPrice.Text = GetBatteryStoragePrice(batteryStorage);
        }

        private void Name_TextChanged(object sender, System.EventArgs e)
        {
            MessageBox.Show("changed");
        }
    }
}