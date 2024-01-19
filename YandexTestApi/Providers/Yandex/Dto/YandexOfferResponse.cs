using YandexTestApi.Providers.Yandex.Entities;

namespace YandexTestApi.Providers.Yandex.Dto
{
    public class YandexOfferResponse
    {
        public Pagination Pagination { get; set; }
        public List<Segment> Interval_Segments { get; set; }
        public List<Segment> Segments { get; set; }
        public Search Search { get; set; }

    }
}
