using PDFOfferCreator.Model;

namespace PDFOfferCreator.Api.Models
{
    public interface IOfferDataRepository
    {
        Task<IEnumerable<OfferData>> GetAllOfferDataAsync();
        Task<OfferData> GetOfferDataByIdAsync(int id);
        Task<OfferData> AddOfferDataAsync(OfferData offerData);
        Task<OfferData> UpdateOfferDataAsync(OfferData offerData);
        Task<OfferData> DeleteOfferDataAsync(int id);
    }
}
