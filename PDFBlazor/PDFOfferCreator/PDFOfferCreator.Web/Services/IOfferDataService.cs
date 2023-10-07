using PDFOfferCreator.Model;

namespace PDFOfferCreator.Web.Services
{
    public interface IOfferDataService
    {
        Task<IEnumerable<OfferData>> GetOfferDatas();
        Task<OfferData> GetOfferData(int id);
        Task<OfferData> UpdateOfferData(OfferData e);
        Task<OfferData> CreateOfferData(OfferData e);
    }
}
