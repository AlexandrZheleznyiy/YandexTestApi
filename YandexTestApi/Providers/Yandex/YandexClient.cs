using YandexTestApi.Dto;

namespace YandexTestApi.Providers.Yandex
{
    public class YandexClient : IProviderClient
    {
        public HttpClient Client { get; set; }
        public string ApiKey { get; set; }
        public YandexClient()
        {
            ApiKey = "40172e53-7e9b-425c-a56b-967e3543ce57";
            Client = new HttpClient()
            {
                BaseAddress = new Uri("https://api.rasp.yandex.net/v3.0/search/")
            };
        }
        public async Task<IEnumerable<Offer>> GetOffers(OfferRequest request)
        {
            IEnumerable<Offer> result;
            using(Client)
            {
                string parametres = $"?apikey={ApiKey}&from={request.From}&to={request.To}";
                var response = await Client.GetAsync(Client.BaseAddress + parametres);
            }
        }

    }
}
