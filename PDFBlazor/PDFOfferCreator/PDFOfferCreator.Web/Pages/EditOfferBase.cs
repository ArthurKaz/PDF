using Microsoft.AspNetCore.Components;
using PDFOfferCreator.Model;
using PDFOfferCreator.Web.Services;

namespace PDFOfferCreator.Web.Pages
{
    public class EditOfferBase : ComponentBase
    {
        [Parameter]
        public string id { get; set; }
        public OfferData OfferData { get; set; } 
        [Inject]
        public IOfferDataService offerDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected PragimTech.Components.ConfirmBase LeaveConfirmation { get; set; } = new PragimTech.Components.ConfirmBase();
        public bool Saved = false;

        protected override async Task OnInitializedAsync()
        {
            OfferData = await offerDataService.GetOfferData(int.Parse(id));
            Saved = true;
        }

        protected async Task HandleValidSubmit()
        {
            var res = await offerDataService.UpdateOfferData(OfferData);
            Saved = true;
        }
        protected void ConfirmLeavePageClick(bool confirmed)
        {
            if (confirmed)
            {
                NavigationManager.NavigateTo("/");
            }
        }
        protected void LeavePageClick()
        {
            LeaveConfirmation.Show();
        }
    }
}
