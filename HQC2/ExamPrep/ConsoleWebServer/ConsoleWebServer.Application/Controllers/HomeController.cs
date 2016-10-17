namespace ConsoleWebServer.Application.Controllers
{
    using ConsoleWebServer.Framework.ActionResults;
    using ConsoleWebServer.Framework.ActionResults.Contracts;
    using ConsoleWebServer.Framework.Controllers;
    using ConsoleWebServer.Framework.HttpUnits;

    public class HomeController : Controller
    {
        public HomeController(HttpRequest request) : base(request)
        {
        }

        public IActionResult Index(string param)
        {
            return this.Content("Home page :)");
        }

        public IActionResult LivePage(string param)
        {
            var contentResult = new ContentActionResult(this.Request, "Live page with no caching");

            return new ActionResultWithoutCachingDecorator(contentResult);
        }

        public IActionResult LivePageForAjax(string param)
        {
            var contentResult = new ContentActionResult(this.Request, "Live page with no caching and CORS");

            var contentResultCors = new ActionResultWithCorsDecorator(contentResult, "*");

            return new ActionResultWithoutCachingDecorator(contentResultCors);
        }

        public IActionResult Forum(string param)
        {
            return this.Redirect("https://telerikacademy.com/Forum/Home");
        }
    }
}