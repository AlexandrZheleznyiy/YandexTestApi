using YandexTestApi.Dto;

namespace YandexTestApi.Providers
{
    public interface IProviderClient
    {
        Task<IEnumerable<Offer>> GetOffers(OfferRequest request);
    }
}
