using ConfigurationAssignment.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationAssignment.Controllers
{
    public class HomeController(IOptions<SocialMediaLinksOptions> socialMediaLinksOptions) : Controller
    {
        private readonly IOptions<SocialMediaLinksOptions> _socialMediaOptions = socialMediaLinksOptions;
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            SocialMediaLinksOptions social = _socialMediaOptions.Value;
            ViewBag.FaceBook = social.Facebook;
            ViewBag.YouTube = social.Youtube;
            ViewBag.Twitter = social.Twitter;
            ViewBag.Instagram = social.Instagram;
            return View();
        }
    }
}
