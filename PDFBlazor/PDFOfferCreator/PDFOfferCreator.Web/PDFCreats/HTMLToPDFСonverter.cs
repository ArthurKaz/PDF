using Microsoft.JSInterop;

namespace PDFOfferCreator.Web.PDFCreats
{
    public class HTMLToPDFСonverter
    {
        private readonly IJSRuntime JS;
        public HTMLToPDFСonverter(IJSRuntime jS)
        {
            JS = jS;
        }
        public async Task ConvertHtmlToPdf(string htmlData, string filename)
        {
            var render = new ChromePdfRenderer();
            var doc = render.RenderHtmlAsPdf(htmlData);
            var fullFileName = filename + ".pdf";
            using var streamRef = new DotNetStreamReference(stream: doc.Stream);
            await JS.InvokeVoidAsync("SubmitHTML", fullFileName, streamRef);
        }
    }
}
