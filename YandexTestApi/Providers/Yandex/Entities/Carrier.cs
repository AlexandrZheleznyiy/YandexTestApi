using System.Security;

namespace YandexTestApi.Providers.Yandex.Entities
{
    public class Carrier
    {
        public int Code { get; set; }
        public string Contacts { get; set; }
        public string Url { get; set; }
        public string url_svg { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public Codes Codes { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }
        public string Email { get; set; }

    }

}
