using Microsoft.AspNetCore.Components;
using PDFOfferCreator.Model;
using PDFOfferCreator.Web.Services;

namespace PDFOfferCreator.Web.Pages
{
    public class AddOfferBase : ComponentBase
    {
        public OfferData OfferData { get; set; } = new OfferData();
        [Inject]
        public  IOfferDataService offerDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async Task HandleValidSubmit()
        {
            var res = await offerDataService.CreateOfferData(OfferData);
            NavigationManager.NavigateTo("/");
        }
    }
}
