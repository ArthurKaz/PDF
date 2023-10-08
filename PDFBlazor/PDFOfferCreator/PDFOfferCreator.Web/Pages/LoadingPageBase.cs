using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PDFOfferCreator.Web.PDFCreats;

namespace PDFOfferCreator.Web.Pages
{
    public class LoadingPageBase : ComponentBase
    {
        [Parameter]
        public string html {  get; set; }
        [Parameter]
        public string fileName { get; set; }
        [Inject]
        public IJSRuntime js { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public string DecodedHTML => System.Net.WebUtility.UrlDecode(html);

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(10);
            HTMLToPDFСonverter converter = new HTMLToPDFСonverter(js);
            await converter.ConvertHtmlToPdf(DecodedHTML, fileName);
            NavigationManager.NavigateTo("/");
        }

    }
}
