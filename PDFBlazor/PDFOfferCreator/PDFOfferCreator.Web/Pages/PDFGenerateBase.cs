using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PDFOfferCreator.Model;
using PDFOfferCreator.Web.PDFCreats;
using PDFOfferCreator.Web.Services;

namespace PDFOfferCreator.Web.Pages
{
    public class PDFGenerateBase : ComponentBase
    {
        [Inject]
        public IJSRuntime js {  get; set; }
        [Inject]
        public IOfferDataService OfferDataService { get; set; }

        [Parameter]
        public string Id { get; set; }
        public MarkupString html = new MarkupString("<p>Hello world!</p>");

        public OfferData OfferData { get; set; }

        private string _code;
        protected override async Task OnInitializedAsync()
        {
            OfferData = await OfferDataService.GetOfferData(int.Parse(Id));
            string templateHtmlPath = "wwwroot/html/htmlpage.html";
            _code = await HtmlScanner.ReadHtmlFileAsync(templateHtmlPath);
            HTMLFiller filler = new HTMLFiller();
            _code = await filler.GetFilledData(OfferData, _code);
            html = new MarkupString(_code);
        }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public async Task DownloadPDF()
        {
            /*OfferData = null;
            HTMLToPDFСonverter converter = new HTMLToPDFСonverter(js);
            await converter.ConvertHtmlToPdf(_code);*/
            string encodedFileName = System.Net.WebUtility.UrlEncode(_code);

            NavigationManager.NavigateTo($"/loading/{encodedFileName}");
        }
    }
}
