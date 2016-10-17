namespace ConsoleWebServer.Framework.ActionResults.Contracts
{
    using System.Collections.Generic;
    using ConsoleWebServer.Framework.HttpUnits;
    using System.Net;

    public abstract class ActionResult : IActionResult
    {
        public HttpRequest Request { get; private set; }

        public readonly object Model;

        public ICollection<KeyValuePair<string, string>> ResponseHeaders { get; private set; }
 
        public ActionResult(HttpRequest request, object model)
        {
            this.ResponseHeaders = new Dictionary<string, string>();
            this.Request = request;
            this.Model = model;
        }

        public HttpResponse GetResponse()
        {
            var response = new HttpResponse(this.Request.ProtocolVersion, GetStatusCode(), GetContent(), GetContentType());

            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }

        protected virtual HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.OK;
        }

        protected abstract string GetContent();

        protected abstract string GetContentType();

    }
}
