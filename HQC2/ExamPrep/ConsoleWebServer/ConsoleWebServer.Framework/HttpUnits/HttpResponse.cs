namespace ConsoleWebServer.Framework.HttpUnits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using ConsoleWebServer.Framework.HttpUnits.Contracts;

    public class HttpResponse : HttpUnit
    {
        private readonly string serverEngineName;

        public HttpResponse(
            Version httpVersion,
            HttpStatusCode statusCode,
            string body,
            string contentType = "text/plain; charset=utf-8")
            :base(httpVersion)
        {
            serverEngineName = "ConsoleWebServer";
            Headers = new SortedDictionary<string, ICollection<string>>();
            Body = body;
            StatusCode = statusCode;
            AddHeader("Server", serverEngineName);
            AddHeader("Content-Length", body.Length.ToString());
            AddHeader("Content-Type", contentType);
        }

        public HttpStatusCode StatusCode { get; private set; }

        public string Body { get; private set; }

        public string StatusCodeAsString
        {
            get
            {
                return this.StatusCode.ToString();
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(
                string.Format(
                    "{0}{1} {2} {3}",
                    "HTTP/",
                    ProtocolVersion,
                    (int)StatusCode,
                    StatusCodeAsString));
            var headerStringBuilder = new StringBuilder();

            foreach (var key in Headers.Keys)
            {
                headerStringBuilder.AppendLine(string.Format("{0}: {1}", key, string.Join("; ", Headers[key])));
            }

            stringBuilder.AppendLine(headerStringBuilder.ToString());

            if (!string.IsNullOrWhiteSpace(Body))
            {
                stringBuilder.AppendLine(Body);
            }

            return stringBuilder.ToString();
        }
    }
}