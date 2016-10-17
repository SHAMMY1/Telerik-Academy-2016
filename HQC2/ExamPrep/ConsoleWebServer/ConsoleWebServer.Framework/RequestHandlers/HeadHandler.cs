namespace ConsoleWebServer.Framework.RequestHandlers
{
    using System;
    using System.Linq;
    using System.Net;
    using ConsoleWebServer.Framework.HttpUnits;
    using ConsoleWebServer.Framework.RequestHandlers.Contracts;
    using ConsoleWebServer.Framework.ActionResults;

    public class HeadHandler : RequestHandler
    {
        protected override bool CanHandle(HttpRequest request)
        {
            return request.Method.ToLower() == "head";
        }

        protected override HttpUnits.HttpResponse Handle(HttpRequest request)
        {
            return new ContentActionResult(request, string.Empty).GetResponse();
        }
    }
}
