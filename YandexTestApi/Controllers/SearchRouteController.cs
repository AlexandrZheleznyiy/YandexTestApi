using Microsoft.AspNetCore.Mvc;
using YandexTestApi.Dto;
using YandexTestApi.Services;

namespace YandexTestApi.Controllers
{
    [ApiController]
    public class SearchRouteController : ControllerBase
    {
        private readonly OfferService _offerService;
        public SearchRouteController(OfferService offerService)
        {
            _offerService = offerService;
        }
        public async Task<IEnumerable<Offer>> GetOffers(OfferRequest request)
        {
            return await _offerService.GetOffers(request);
        }
    }
}
