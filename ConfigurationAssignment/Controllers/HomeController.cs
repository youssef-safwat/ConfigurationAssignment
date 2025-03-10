using ConfigurationAssignment.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationAssignment.Controllers
{
    public class HomeController(IOptions<SocialMediaLinksOptions> socialMediaLinksOptions) : Controller
    {
        private readonly SocialMediaLinksOptions _socialMediaOptions = socialMediaLinksOptions.Value;
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            SocialMediaLinksOptions social = _socialMediaOptions;
            ViewBag.Social = social;
            return View();
        }
    }
}
