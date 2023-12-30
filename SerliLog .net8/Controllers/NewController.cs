using Microsoft.AspNetCore.Mvc;

namespace SerliLog_.net8.Controllers
{
    public class NewController : Controller
    {
        private readonly ILogger<NewController> _logger;

        public NewController(ILogger<NewController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("New page has started");
            _logger.LogError("error page has started");
            _logger.LogCritical("Critical");
            _logger.LogWarning("Warning");
            return View();
        }
    }
}
