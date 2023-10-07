using Microsoft.AspNetCore.Components;
using PDFOfferCreator.Model;
using PDFOfferCreator.Web.Services;

namespace PDFOfferCreator.Web.Pages
{
    public class DisplayAllOfferDataBase : ComponentBase
    {
        [Inject]
        public IOfferDataService OfferDataService { get; set; }
        public List<OfferData> OfferDatas { get; set; }

        protected override async Task OnInitializedAsync()
        {
            OfferDatas = (await OfferDataService.GetOfferDatas()).ToList();
        }
    }
}
