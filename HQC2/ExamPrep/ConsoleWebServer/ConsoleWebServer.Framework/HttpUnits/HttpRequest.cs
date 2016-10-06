namespace ConsoleWebServer.Framework.HttpUnits
{
    using System;
    using System.Linq;
    using System.Text;
    using ConsoleWebServer.Framework;
    using ConsoleWebServer.Framework.HttpUnits.Contracts;

    public class HttpRequest : HttpUnit
    {


        public HttpRequest(string method, string uri, Version httpVersion)
            : base(httpVersion)
        {
            this.Uri = uri;
            this.Method = method;
            this.Action = new ActionDescriptor(uri);
        }

        public string Method { get; private set; }

        public string Uri{get;set;}

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(
                string.Format(
                    "{0} {1} {2}{3}",
                    this.Method,
                    this.Action,
                    "HTTP/",
                    this.ProtocolVersion));
            var headerStringBuilder = new StringBuilder();
            foreach (var key in this.Headers.Keys)
            {
                headerStringBuilder.AppendLine(string.Format("{0}: {1}", key, string.Join("; ", this.Headers[key])));
            }

            sb.AppendLine(headerStringBuilder.ToString());
            return sb.ToString();
        }

        public ActionDescriptor Action { get; private set; }


    }
}