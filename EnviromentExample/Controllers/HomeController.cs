using Microsoft.AspNetCore.Mvc;

namespace EnviromentExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        // inject to constructor
        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        // demo UseDeveloperExceptionPage 
        //[Route("some-route")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.Current = _webHostEnvironment.EnvironmentName;
            return View();
        }

        
        [Route("some-route")]
        public IActionResult Other()
        {
            return View();
        }
    }
}
