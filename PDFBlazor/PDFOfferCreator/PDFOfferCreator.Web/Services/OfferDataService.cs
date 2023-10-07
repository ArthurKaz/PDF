using PDFOfferCreator.Model;
using System.Net.Http;

namespace PDFOfferCreator.Web.Services
{
    public class OfferDataService : IOfferDataService
    {
        private readonly HttpClient _httpClient;
        public OfferDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<OfferData> CreateOfferData(OfferData e)
        {
            var response = await _httpClient.PostAsJsonAsync<OfferData>("api/offerdata", e);
            OfferData offerData = await response.Content.ReadFromJsonAsync<OfferData>();
            return offerData;
        }

        public async Task DeleteOfferData(int id)
        {
            await _httpClient.DeleteAsync($"api/offerdata/{id}");
        }

        public async Task<OfferData> GetOfferData(int id)
        {
            return await _httpClient.GetFromJsonAsync<OfferData>($"api/offerdata/{id}");
        }

        public async Task<IEnumerable<OfferData>> GetOfferDatas()
        {
            return await _httpClient.GetFromJsonAsync<OfferData[]>("api/offerdata");
        }

        public async Task<OfferData> UpdateOfferData(OfferData e)
        {
            var response = await _httpClient.PutAsJsonAsync<OfferData>("api/offerdata", e);
            OfferData employee = await response.Content.ReadFromJsonAsync<OfferData>();
            return employee;
        }
    }
}
