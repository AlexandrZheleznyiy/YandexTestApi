using YandexTestApi.Dto;

namespace YandexTestApi.Providers.Yandex
{
    public class YandexProvider : IProviderClient
    {
        public async Task<IEnumerable<Offer>> GetOffers(OfferRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
