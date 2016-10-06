namespace ConsoleWebServer.Framework.ActionResults
{
    using ConsoleWebServer.Framework.ActionResults.Contracts;
    using ConsoleWebServer.Framework.HttpUnits;

    public class ContentActionResult :ActionResult, IActionResult
    {
        public ContentActionResult(HttpRequest request, object model)
            :base(request, model)
        {
        }
 
        protected override string GetContent()
        {
            return this.Model.ToString();
        }

        protected override string GetContentType()
        {
            return "text/plain; charset=utf-8";
        }
    }
}