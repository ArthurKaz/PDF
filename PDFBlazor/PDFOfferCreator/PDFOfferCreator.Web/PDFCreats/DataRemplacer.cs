namespace PDFOfferCreator.Web.PDFCreats
{
    public class DataRemplacer
    {
        private List<DataElement> _dataElements = new List<DataElement>();
        public void AddDataElemnt(DataElement dataElement) => _dataElements.Add(dataElement);

        public string ReplaceAllData(string input)
        {
            string result = input;
            foreach(var dataElement in _dataElements)
            {
                result = result.Replace(dataElement.Key, dataElement.DataForReplace);
            }
            return result;
        }
    }
}
