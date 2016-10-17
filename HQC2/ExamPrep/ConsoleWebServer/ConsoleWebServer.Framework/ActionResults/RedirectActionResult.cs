namespace ConsoleWebServer.Framework.ActionResults
{
    using ConsoleWebServer.Framework.ActionResults.Contracts;
    using ConsoleWebServer.Framework.HttpUnits;
    using System.Collections.Generic;
    using System.Net;

    public class RedirectActionResult : ActionResult
    {
        public RedirectActionResult(HttpRequest request, string location)
            : base(request, string.Empty)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Location", location));
        }

        protected override string GetContent()
        {
            return this.Model.ToString();
        }

        protected override string GetContentType()
        {
            return "text/plain; charset=utf-8";
        }

        protected override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.Redirect;
        }
    }
}
