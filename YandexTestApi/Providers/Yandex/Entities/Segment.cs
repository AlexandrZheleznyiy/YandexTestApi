
namespace YandexTestApi.Providers.Yandex.Entities
{
    public class Segment
    {
        public string Arrrival { get; set; }
        public Location From { get; set; }
        public YandexThread Thread { get; set; }
        public string Departure_Platform { get; set; }
        public string Stops { get; set; }
        public string Departure_Terminal { get; set; }
        public Location To { get; set; }
        public bool Has_Transfers { get; set; }
        public TicketsInfo Tickets_Info { get; set; }
        public int Duration { get; set; }
        public string Arrival_Terminal { get; set; }
        public string Start_Date { get; set; }
        public string Arrival_Platform { get; set; }

    }
}
