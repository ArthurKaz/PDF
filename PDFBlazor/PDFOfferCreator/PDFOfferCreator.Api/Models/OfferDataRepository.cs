using Microsoft.EntityFrameworkCore;
using PDFOfferCreator.Model;

namespace PDFOfferCreator.Api.Models
{
    public class OfferDataRepository : IOfferDataRepository
    {
        private readonly AppDbContext appDbContext;

        public OfferDataRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<OfferData>> GetAllOfferDataAsync()
        {
            return await appDbContext.OfferData.ToListAsync();
        }

        public async Task<OfferData> GetOfferDataByIdAsync(int id)
        {
            return await appDbContext.OfferData.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<OfferData> AddOfferDataAsync(OfferData offerData)
        {
            var result = await appDbContext.OfferData.AddAsync(offerData);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<OfferData> UpdateOfferDataAsync(OfferData offerData)
        {
            var existingOfferData = await GetOfferDataByIdAsync(offerData.Id);
            if (existingOfferData != null)
            {
                appDbContext.Entry(existingOfferData).CurrentValues.SetValues(offerData);
                await appDbContext.SaveChangesAsync();
            }
            return existingOfferData;
        }

        public async Task<OfferData> DeleteOfferDataAsync(int id)
        {
            var offerData = await GetOfferDataByIdAsync(id);
            if (offerData != null)
            {
                appDbContext.OfferData.Remove(offerData);
                await appDbContext.SaveChangesAsync();
            }
            return offerData;
        }
    }
}
