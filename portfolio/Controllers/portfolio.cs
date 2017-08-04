using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace portfolio.Controllers
{
    public class portfolioController : Controller
    {
        [HttpGetAttribute]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        [Route("projects")]
        public IActionResult Projects()
        {
            return View();
        }

        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}