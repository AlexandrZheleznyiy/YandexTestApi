namespace YandexTestApi.Providers.Yandex.Entities
{
    public class YandexThread
    {
        public string Uid { get; set; }
        public string Title { get; set; }
        public Interval Interval { get; set; }
        public string Number { get; set; }
        public string Short_Title { get; set; }
        public string Thread_Metod_Link { get; set; }
        public Carrier Carrier { get; set; }
        public string Transport_Type { get; set; }
        public string Vehicle { get; set; }
        public TransportSubtype TransportSubtype { get; set; }
        public string Express_Type { get; set; }
    }
}
