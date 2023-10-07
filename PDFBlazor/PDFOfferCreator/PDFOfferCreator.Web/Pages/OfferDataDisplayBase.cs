using Microsoft.AspNetCore.Components;
using PDFOfferCreator.Model;
using PDFOfferCreator.Web.Services;
using PragimTech.Components;

namespace PDFOfferCreator.Web.Pages
{
    public class OfferDataDisplayBase : ComponentBase
    {
        [Parameter]
        public OfferData OfferData { get; set; }
        [Inject]
        public IOfferDataService OfferDataService { get; set; }

        [Inject] 
        public NavigationManager NavigationManager { get; set; }

        protected  void DeleteClick()
        {
            /* await OfferDataService.DeleteOfferData(OfferData.Id);
             NavigationManager.NavigateTo("/alloffers", true);*/
            DeleteConfirmation.Show();
        }
        protected async Task ConfirmDeleteClick(bool confirmed)
        {
            if (confirmed)
            {
                await OfferDataService.DeleteOfferData(OfferData.Id);
                NavigationManager.NavigateTo("/alloffers", true);
            }
        }

        protected ConfirmBase DeleteConfirmation { get; set; } = new ConfirmBase();

        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await OfferDataService.DeleteOfferData(OfferData.Id);
                NavigationManager.NavigateTo("/alloffers", true);
            }
        }
    }
}
