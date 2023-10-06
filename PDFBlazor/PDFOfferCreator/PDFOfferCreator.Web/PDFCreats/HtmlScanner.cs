namespace PDFOfferCreator.Web.PDFCreats
{
    public class HtmlScanner
    {
        public static async Task<string> ReadHtmlFileAsync(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string fileContent = await reader.ReadToEndAsync();
                    return fileContent;
                }
            }
            catch (Exception)
            {
                return "Nothing found";
            }
        }
    }
}
