using YandexTestApi.Dto;
using YandexTestApi.Providers;

namespace YandexTestApi.Services
{
    public class OfferService
    {
        public async Task<List<Offer>> GetOffers(OfferRequest request)
        {
            List<Offer> result = new();
            List<Providers.Providers> providers = Enum.GetValues(typeof(Providers.Providers)).Cast<Providers.Providers>().ToList();
            foreach(var provider in providers)
            {
                var providerClient = ProviderClientFactory.Create(provider);
                result.AddRange(await providerClient.GetOffers(request));
            }
            return result;
        }

    }
}
