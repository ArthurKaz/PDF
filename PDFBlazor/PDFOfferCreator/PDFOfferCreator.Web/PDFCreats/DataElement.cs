namespace PDFOfferCreator.Web.PDFCreats
{
    public class DataElement
    {
        public readonly string Key;
        public string DataForReplace { get; set; } = "Not entered";
        public DataElement(string key)
        {
            Key = key;
        }
     }
}
