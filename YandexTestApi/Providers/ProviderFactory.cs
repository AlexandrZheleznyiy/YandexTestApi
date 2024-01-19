
using YandexTestApi.Providers.Yandex;

namespace YandexTestApi.Providers
{
    public static class ProviderClientFactory
    {
        public static IProviderClient Create(Providers provider)
        {
            switch (provider)
            {
                case Providers.Yandex:
                    return new YandexClient();
                default:
                    throw new Exception("Клиент для провайдера не реализован");
            }
        }
    }
}
