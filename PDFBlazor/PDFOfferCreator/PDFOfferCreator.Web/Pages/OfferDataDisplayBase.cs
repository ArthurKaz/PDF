using Microsoft.AspNetCore.Components;
using PDFOfferCreator.Model;

namespace PDFOfferCreator.Web.Pages
{
    public class OfferDataDisplayBase : ComponentBase
    {
        [Parameter]
        public OfferData OfferData { get; set; }
    }
}
