namespace ConsoleWebServer.Framework.ActionResults
{
    using System;
    using ConsoleWebServer.Framework.ActionResults.Contracts;

    public class ActionResultWithoutCachingDecorator : ActionResultDecorator
    {
        public ActionResultWithoutCachingDecorator(IActionResult actionResult)
            : base(actionResult)
        {
        }

        protected override void UpdateResponse(HttpUnits.HttpResponse resultHttpResponse)
        {
            resultHttpResponse.AddHeader("Cache-Control", "private, max-age=0, no-cache");
        }
    }
}
